using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MemoMate.Web.Models;
using MemoMate.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using MemoMate.Web.GeneralHelpers;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq.Expressions;

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
			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var postsToday = await GetPostsDetails(p => p.Date >= today , 18);
			if (postsToday.Count == 0)
				postsToday.Add(NoFoundPost("No new posts found.", "There is no new posts found today :( WHY DON'T YOU SHARE YOUR THOUGHTS !? :(((("));
			
			var postsYesterday = await GetPostsDetails(p => p.Date >= today.AddDays(-1) && p.Date < today,3);
			if (postsYesterday.Count == 0)
				postsYesterday.Add(NoFoundPost("No posts found...", "We couldn't find any posts shared yesterday... why..."));

			var postsCheckOut = await GetPostsDetails(p => p.Date >= today && p.CheckOut, 3);

			if (postsCheckOut.Count == 0)
				postsCheckOut.Add(NoFoundPost("Nothing to check out.", "We tried to push our customers to give us money to show themselves up here but... we failed?"));

			var themename = await _context.Themes.OrderByDescending(t => t.Id).Take(2).ToListAsync();

			PostsViewModel model = new PostsViewModel()
			{
				LoggedUserEntity = user,
				PostsToday = postsToday,
				PostsYesterday = postsYesterday,
				TodayThemeName = themename[0].Name,
				YesterdayThemeName = themename[1].Name,
				PostsCheckOut = postsCheckOut
			};

			return View(model); // Pass List<Note> to the view
		}

		public async Task<IActionResult> Rates()
		{

			if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
				return RedirectToAction("Index", "Home");

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId")));
			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var randomPostToRate = await _context.Posts
									.Include(p => p.UserEntity)
									.Include(p => p.NoteEntity)
									.Where(p => p.UserID != user.ID &&
													p.Date >= today &&
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
				MessageHelpers.SetInfo("Sorry, there is no new post found :(");
				return RedirectToAction("Index", "Posts");
			}

		}

		[HttpPost("RatePost")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> RatePost(RateViewModel ratedPost)
		{
			int user_id = int.Parse(HttpContext.Session.GetString("UserId"));
			int post_id = ratedPost.RatePost.PostID;

			Rate rate = new Rate() { PostID = post_id, UserID = user_id };

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
				return View(new CreateViewModel());

			_context.Notes.Add(newNote);
			await _context.SaveChangesAsync();

			Post post = new Post()
			{
				UserID = int.Parse(HttpContext.Session.GetString("UserId")),
				NoteID = newNote.Id,
				Date = TimeHelpers.GetLocalDate(),
				RateCount = 0,
				RateUps = 0
			};
			_context.Posts.Add(post);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "Posts");
		}

		public async Task<List<PostDetailModel>> GetPostsDetails( Expression<Func<Post, bool>> whereCondition, int? take = null, bool orderByRateDescending = true)
		{
			var query = _context.Posts
					.Include(p => p.UserEntity)
					.Include(p => p.NoteEntity)
					.Where(whereCondition)
					.Select(p => new PostDetailModel
					{
						PostID = p.ID,
						PostDate = p.Date,
						PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
						NoteContent = p.NoteEntity.Content,
						NoteTitle = p.NoteEntity.Title,
						Username = p.UserEntity.Username,
						UserPhoto = p.UserEntity.Photo
					});

			if (orderByRateDescending)
				query = query.OrderByDescending(p => p.PostRate);

			if (take.HasValue)
				query = query.Take(take.Value);

			return await query.ToListAsync();
		}
		private PostDetailModel NoFoundPost(string title, string message)
		{
			return new PostDetailModel
			{
				NoteTitle = title,
				NoteContent = message,
				PostDate = TimeHelpers.GetLocalDate(),
				PostRate = 0,
				Username = "admin",
				UserPhoto = "admin.jpg"
			};
		}


		[HttpGet]
		public async Task<IActionResult> LoadMoreData(int skip, int take)
		{
			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var query = _context.Posts
					.Include(p => p.UserEntity)
					.Include(p => p.NoteEntity)
					.Where(p.Date >= today)
					.Select(p => new PostDetailModel
					{
						PostID = p.ID,
						PostDate = p.Date,
						PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
						NoteContent = p.NoteEntity.Content,
						NoteTitle = p.NoteEntity.Title,
						Username = p.UserEntity.Username,
						UserPhoto = p.UserEntity.Photo
					});

			var posts = await _context.Posts
				.OrderByDescending(p => p.Postra)
				.Skip(skip)
				.Take(take)
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
				.ToListAsync();

			// HTML partial view ile dönülecek
			return PartialView("_PostPartial", posts);
		}

	}
}
