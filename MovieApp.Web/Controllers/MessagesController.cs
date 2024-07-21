using Microsoft.AspNetCore.Mvc;
using MemoMate.Web.Models;
using MemoMate.Web.Models.Messages;
using MemoMate.Data;
using System.Linq;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using MemoMate.Web.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

namespace MemoMate.Web.Controllers
{
	[Authorize(Policy = "General")]
	public class MessagesController : Controller
	{
		private readonly MemoMateContext _context;
		public MessagesController(MemoMateContext context)
		{
			_context = context;
		}


		public async Task<IActionResult> Inbox()
		{
			UserMessagesModel model = await GetTalkedUsers();
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> GetMessages(string username, int skip)
		{
			if (string.IsNullOrEmpty(username))
				return NoContent();

			UserEntity selectedUser = await _context.Users.Where(u => u.Username == username).FirstOrDefaultAsync();
			int loggedID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

			if (selectedUser == null) return NoContent();
			SelectedUserMessages model = new SelectedUserMessages()
			{
				LoggedUser = await _context.Users.Where(u => u.ID == loggedID).FirstOrDefaultAsync(),
				User = selectedUser,
				Messages = await GetUserMessages(selectedUser.ID, skip, null)
			};
			if (model.Messages.Count == 0)
				return NoContent();

			return PartialView("_UserMessagesPartial", model);
		}

		private async Task<UserMessagesModel> GetTalkedUsers()
		{
			var loggedUser = await _context.Users.Where(u => u.ID == int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value)).FirstAsync();
			Dictionary<UserEntity, Message> messages = new Dictionary<UserEntity, Message>();
			List<int> userIds = await _context.Messages
									 .Where(m => m.UserFromID == loggedUser.ID || m.UserTargetID == loggedUser.ID)
									 .Select(m => m.UserFromID == loggedUser.ID ? m.UserTargetID : m.UserFromID)
									 .Distinct().ToListAsync();

			for (int i = 0; i < userIds.Count; i++)
			{
				int userID = userIds[i];
				var talkUser = await _context.Users.Where(u => u.ID == userID).FirstAsync();
				var lastMessage = await _context.Messages
									 .Where(m => (m.UserFromID == loggedUser.ID && m.UserTargetID == userID) || (m.UserFromID == userID && m.UserTargetID == loggedUser.ID))
									 .OrderByDescending(m => m.SentDate)
									 .FirstAsync();
				if (lastMessage.Content.Length > 50)
					lastMessage.Content = lastMessage.Content.Substring(0, 40);
				messages.Add(talkUser, lastMessage);
			}

			UserMessagesModel model = new UserMessagesModel()
			{
				LoggedUserEntity = loggedUser,
				Messages = messages
			};
			return model;
		}

		private async Task<List<Message>> GetUserMessages(int selectedUserId, int skip, int? take)
		{
			int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			return await _context.Messages.Where(m => (m.UserFromID == selectedUserId && m.UserTargetID == userId)
						 || (m.UserFromID == userId && m.UserTargetID == selectedUserId)).
						 OrderByDescending(m => m.SentDate)
						 .Skip(skip)
						 .Take(20)
						 .ToListAsync();
		}

		[HttpGet]
		public async Task<IActionResult> SendMessage(string username, string message)
		{
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(message))
				return NoContent();

			var targetUser = await _context.Users
								   .Where(u => u.Username == username)
								   .FirstOrDefaultAsync();
			if (targetUser == null)
				return NoContent();


			var fromUser = await _context.Users
								   .Where(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
								   .FirstOrDefaultAsync();

			Message newMessage = new Message()
			{
				SentDate = DateTime.Now,
				UserFromID = fromUser.ID,
				UserTargetID = targetUser.ID,
				Content = message
			};

			await _context.Messages.AddAsync(newMessage);
			await _context.SaveChangesAsync();

			var hubContext = HttpContext.RequestServices.GetService<IHubContext<ChatHub>>();

			// Kullanıcı adından kullanıcı kimliğine dönüşüm yaparak mesajı iletin
			await hubContext.Clients.User(targetUser.ID.ToString()).SendAsync("ReceiveMessage", fromUser.Username);

			SelectedUserMessages model = new SelectedUserMessages()
			{
				LoggedUser = await _context.Users.Where(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)).FirstOrDefaultAsync(),
				User = targetUser,
				Messages =
				new List<Message>
				{
					newMessage
				}
			};
			await SetMessageRead(read: false, fromID: fromUser.ID, targetID: targetUser.ID);
			return PartialView("_UserMessagesPartial", model);
		}



		[HttpGet]
		public async Task<IActionResult> GetLastMessage(string username)
		{
			if (string.IsNullOrEmpty(username))
				return NoContent();

			int loggedUserID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			UserEntity selectedUser = await _context.Users.Where(u => u.Username == username).FirstOrDefaultAsync();

			if (selectedUser == null) return NoContent();
			SelectedUserMessages model = new SelectedUserMessages()
			{
				LoggedUser = await _context.Users.Where(u => u.ID == loggedUserID).FirstOrDefaultAsync(),
				User = selectedUser,
				Messages = await GetUserMessages(selectedUser.ID, 0, 1)
			};
			if (model.Messages.Count == 0)
				return NoContent();

			await SetMessageRead(read: true, fromID: selectedUser.ID, targetID: loggedUserID);

			return PartialView("_UserMessagesPartial", model);
		}

		private async Task<bool> SetMessageRead(bool read, int fromID, int targetID)
		{
			var chatRead = await _context.ChatReads
						   .Where(cr => cr.FromID == fromID && cr.TargetID == targetID)
						   .FirstOrDefaultAsync();
			bool wasRead;
			if (chatRead == null)
			{
				wasRead = read;
				await _context.ChatReads.AddAsync(new ChatRead()
				{
					FromID = fromID,
					TargetID = targetID,
					IsRead = read,
				});
			}
			else
			{
				wasRead = chatRead.IsRead;
				chatRead.IsRead = read;
				_context.Update(chatRead);
			}

			await _context.SaveChangesAsync();

			return wasRead;
		}
		[HttpGet]
		public async Task<int> GetMessageCount()
		{
			return await _context.ChatReads
					.Where(m => m.TargetID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value) && !m.IsRead)
					.CountAsync();
		}
	}
}
