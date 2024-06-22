using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MemoMate.Web.Models;
using MemoMate.Data;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using MemoMate.Web.GeneralHelpers;

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
			if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
				return RedirectToAction("Index", "Home");

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId")));
			DateTime now = TimeHelpers.GetCurrentDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var postsToday = await _context.Posts
								  .Include(p => p.UserEntity)
								  .Include(p => p.NoteEntity)
								  .Where(p => p.Date >= today && p.Date < today.AddDays(1))
								  .Select(p => new PostDetailModel
								  {
									  PostID = p.ID,
									  PostDate = p.Date,
                                      PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
									  NoteContent = p.NoteEntity.Content,
									  NoteTitle = p.NoteEntity.Title,
									  Username = p.UserEntity.Username,
									  UserPhoto = p.UserEntity.Photo
								  })
								  .OrderByDescending(p => p.PostRate)
								  .Take(10)
								  .ToListAsync();

			var postsYesterday = await _context.Posts
									  .Include(p => p.UserEntity)
									  .Include(p => p.NoteEntity)
									  .Where(p => p.Date >= today.AddDays(-1) && p.Date < today)
									  .Select(p => new PostDetailModel
									  {
										  PostID = p.ID,
										  PostDate = p.Date,
										  PostRate = p.RateCount == 0 ? 0 : p.RateUps * 5 / (float)p.RateCount,
										  NoteContent = p.NoteEntity.Content,
										  NoteTitle = p.NoteEntity.Title,
										  Username = p.UserEntity.Username,
										  UserPhoto = p.UserEntity.Photo
									  })
									  .OrderByDescending(p => p.PostRate)
									  .Take(3)
									  .ToListAsync();

			PostsViewModel model = new PostsViewModel() { LoggedUserEntity = user, PostsToday = postsToday, PostsYesterday = postsYesterday };

			return View(model); // Pass List<Note> to the view
		}

		public async Task<IActionResult> Rates()
		{

			if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
				return RedirectToAction("Index", "Home");

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId")));
			DateTime now = TimeHelpers.GetCurrentDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var randomPostToRate = await _context.Posts
									.Include(p => p.UserEntity)
									.Include(p => p.NoteEntity)
									.Where(p => p.UserID != user.ID &&
												!_context.Rates.Any(r => r.PostID == p.ID && r.UserID == user.ID))
									.OrderBy(p => Guid.NewGuid()) //Random sıralama
									.Select(p => new PostDetailModel
									{
										PostID = p.ID,
										PostDate = p.Date,
										PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
										NoteContent = p.NoteEntity.Content,
										NoteTitle = p.NoteEntity.Title,
										Username = p.UserEntity.Username,
										UserPhoto = p.UserEntity.Photo
									})
									.FirstOrDefaultAsync();


			if (randomPostToRate != null)
			{
				RateViewModel model = new RateViewModel() { LoggedUserEntity = user, RatePost = randomPostToRate };
				return View(model);
			}
			else
			{
				return RedirectToAction("Index", "Posts");
			}

		}

		[HttpPost("RatePost")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> RatePost(RateViewModel ratedPost)
		{
			int user_id = int.Parse(HttpContext.Session.GetString("UserId"));
			int post_id = ratedPost.RatePost.PostID;

			Rate rate = new Rate() { PostID = post_id, UserID = user_id  };

			_context.Rates.Add(rate);

			var post = await _context.Posts.FindAsync(post_id);

			if (post == null)
				return NotFound(); // 404 sayfası

			if (ratedPost.like)
				post.RateUps++;

			post.RateCount++;

			_context.Posts.Update(post);
			await _context.SaveChangesAsync();


			return RedirectToAction("Rates");
		}

		[HttpGet]
		public async Task<IActionResult> Create()
		{
			CreateViewModel model = new CreateViewModel();
			model.LoggedUserEntity = await _context.Users.Where(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId"))).FirstOrDefaultAsync();
			model.NewNote = new Note();
			return View(model);
		}

        [HttpPost]
        public async Task<IActionResult> Create(Note newNote)
        {
            if (!ModelState.IsValid)
            {
                // Model geçersizse, hata işleme veya uygun bir işlem yapma
                return View(new CreateViewModel());
            }

            _context.Notes.Add(newNote);
            await _context.SaveChangesAsync();

            Post post = new Post()
            {
                UserID = int.Parse(HttpContext.Session.GetString("UserId")),
                NoteID = newNote.Id,
                Date = TimeHelpers.GetCurrentDate(),
                RateCount = 0,
                RateUps = 0
            };
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Posts");
        }

    }
}
