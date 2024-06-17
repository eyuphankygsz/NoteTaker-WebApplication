using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MemoMate.Web.Models;
using MemoMate.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace MemoMate.Web.Controllers
{

	public class PostsController : Controller
	{
		private readonly MemoMateContext _context;

		public PostsController(MemoMateContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId")));

			var posts = await _context.Posts
				                  .Include(p => p.UserEntity)
								  .Include(p => p.NoteEntity)
								  .Select( p => new PostDetailModel
								  {
									  PostID = p.ID,
									  PostDate = p.Date,
									  NoteContent = p.NoteEntity.Content,
									  NoteTitle = p.NoteEntity.Title,
									  Username = p.UserEntity.Username,
									  UserPhoto = p.UserEntity.Photo
									  
								  })
								  .OrderByDescending(p => p.PostDate).Take(10).ToListAsync();

			PostsViewModel model = new PostsViewModel() { LoggedUserEntity = user, PostsDetails = posts };

			return View(model); // Pass List<Note> to the view
		}

	}

}
