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
using MemoMate.Web.GeneralHelpers;
using Microsoft.AspNetCore.Http;

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

			if (selectedUser == null) return NoContent();
			SelectedUserMessages model = new SelectedUserMessages()
			{
				LoggedUser = await _context.Users.Where(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)).FirstOrDefaultAsync(),
				User = selectedUser,
				Messages = await GetUserMessages(selectedUser.ID, skip)
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
				messages.Add(talkUser, lastMessage);
			}

			UserMessagesModel model = new UserMessagesModel()
			{
				LoggedUserEntity = loggedUser,
				Messages = messages
			};
			return model;
		}

		private async Task<List<Message>> GetUserMessages(int selectedUserId, int skip)
		{
			int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			return await _context.Messages.Where(m => (m.UserFromID == selectedUserId && m.UserTargetID == userId)
						 || (m.UserFromID == userId && m.UserTargetID == selectedUserId)).
						 OrderByDescending(m => m.SentDate)
						 .Skip(skip)
						 .Take(20)
						 .ToListAsync();
		}
	}
}
