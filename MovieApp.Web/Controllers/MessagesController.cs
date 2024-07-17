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

		public async Task<IActionResult> Index()
		{
			var user = await _context.Users.Where(u => u.ID == int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value)).FirstAsync();
			Dictionary<User, List<Message>> messages = new Dictionary<User, List<Message>>();
			List<int> userIds = await _context.Messages
									 .Where(m => m.UserFromID == user.ID || m.UserTargetID == user.ID)
									 .Select(m => m.UserFromID == user.ID ? m.UserTargetID : m.UserFromID)
									 .Distinct().ToListAsync();


			for (int i = 0; i < userIds.Count; i++)
			{
				int userID = userIds[i];
				var talkUser = await _context.Users.Where(u => u.ID == userID).FirstAsync();
				var messageList = await _context.Messages
									 .Where(m => (m.UserFromID == user.ID && m.UserTargetID == userID) || (m.UserFromID == userID && m.UserTargetID == user.ID))
									 .ToListAsync();
				messages.Add(talkUser, messageList);
			}

			UserMessagesModel model = new UserMessagesModel()
			{
				LoggedUserEntity = user,
				Messages = messages
			};
			return View(model);
		}
	}
}
