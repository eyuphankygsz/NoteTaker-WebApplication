using MemoMate.Data;
using MemoMate.Web.Models.Search;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.Controllers
{
	public class SearchController : Controller
	{
		private readonly MemoMateContext _context;
		public SearchController(MemoMateContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Text(string text)
		{
			text = text.ToLower();
			var users = await _context.Users.Where(u => u.Username.ToLower().StartsWith(text))
				   .OrderBy(u => u.Username.StartsWith(text) ? 0 : 1)
				   .ThenBy(u => u.Username)
					.Select(u =>
						new SearchItemModel
						{
							ID = u.ID,
							ItemName = u.Username,
							Photo = u.Photo
						})
				   .Take(3)
				   .ToListAsync();
			var posts = await _context.Posts.Where(p => p.NoteEntity.Content.ToLower().Contains(text))
						.OrderBy(p => p.NoteEntity.Content.StartsWith(text) ? 0 : 1)
						.ThenBy(p => p.NoteEntity.Content)
						.Select(p =>
							new SearchItemModel
							{
								ID = p.ID,
								ItemName = p.NoteEntity.Title,
								Photo = p.UserEntity.Photo
							})
						.Take(3)
						.ToListAsync();
			var themes = await _context.Themes.Where(t => t.Name.ToLower().Contains(text))
						.OrderBy(t => t.Name.StartsWith(text) ? 0 : 1)
						.ThenBy(t => t.Name)
						.Select(t =>
							new SearchItemModel
							{
								ID = t.Id,
								ItemName = t.Name,
								Photo = t.PhotoURL
							})
						.Take(3)
						.ToListAsync();

			SearchModel model = new SearchModel()
			{
				FoundUsers = users,
				FoundPosts = posts,
				FoundThemes = themes
			};

			return PartialView("_SearchPartial", model);
		}
	}
}
