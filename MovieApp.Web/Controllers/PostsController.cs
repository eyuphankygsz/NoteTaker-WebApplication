using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MemoMate.Web.Models;
using MemoMate.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using MemoMate.Web.GeneralHelpers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using MemoMate.Web.Services;

namespace MemoMate.Web.Controllers
{
	[Authorize(Policy = "General")]
	public class PostsController : Controller
	{
		private readonly PostServices _postServices;
		private readonly MemoMateContext _context;
		private string[] themeNames;
		public PostsController(MemoMateContext context, PostServices postServices)
		{
			_context = context;
			_postServices = postServices;
		}

		public async Task<IActionResult> Index()
		{
			HttpContext.Session.SetString("moreposts", "yes");
			//if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
			//	  return RedirectToAction("Index", "Home");

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var postsYesterday = await _postServices.GetPostsDetails(p => p.Date >= today.AddDays(-1) && p.Date < today, 3);
			if (postsYesterday.Count == 0)
				postsYesterday.Add(NoFoundPost("No posts found...", "We couldn't find any posts shared yesterday... why..."));

			var postsCheckOut = await _postServices.GetPostsDetails(p => p.Date >= today && p.CheckOut, 3);

			if (postsCheckOut.Count == 0)
				postsCheckOut.Add(NoFoundPost("Nothing to check out.", "We tried to push our customers to give us money to show themselves up here but... we failed?"));

			var themename = await GetThemes();


			PostsViewModel model = new PostsViewModel()
			{
				LoggedUserEntity = user,
				PostsYesterday = postsYesterday,
				TodayTheme = themename[0],
				YesterdayThemeName = themename[1].Name,
				PostsCheckOut = postsCheckOut
			};

			return View(model); // Pass List<Note> to the view
		}

		public async Task<IActionResult> Rates()
		{

			//if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
			//  	return RedirectToAction("Index", "Home");

			var loggedUser = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value));

			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var randomPostToRate = await _context.Posts
									.Include(p => p.UserEntity)
									.Include(p => p.NoteEntity)
									.Where(p => p.UserID != loggedUser.ID &&
													p.Date >= today &&
														!_context.Rates.Any(r => r.PostID == p.ID && r.UserID == loggedUser.ID))
									.OrderBy(p => Guid.NewGuid()) //Random sıralama
									.Select(p => new PostDetailModel
									{
										PostID = p.ID,
										UserID = p.UserID,
										PostDate = p.Date,
										PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
										NoteContent = p.NoteEntity.Content,
										NoteTitle = p.NoteEntity.Title,
										Username = p.UserEntity.Username,
										UserPhoto = p.UserEntity.Photo,
										ThemeName = p.ThemeEntity.Name,
										Liked = _context.Likes.Any(l => l.UserID == loggedUser.ID && l.PostID == p.ID) ? "liked" : "unliked",
										IsOwned = p.UserID == loggedUser.ID,
										CanInteract = true
									})
									.FirstOrDefaultAsync();

			if (randomPostToRate != null)
			{
				randomPostToRate.FriendStatus = await _postServices.GetFriendStatus(loggedUser.ID, randomPostToRate.UserID);
				RateViewModel model = new RateViewModel() { LoggedUserEntity = loggedUser, RatePost = randomPostToRate };
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
			int user_id = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
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
			model.LoggedUserEntity = await _context.Users.Where(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)).FirstOrDefaultAsync();
			model.NewNote = new Note();
			model.ThemeName = (await GetThemes())[0].Name;
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Create(Note newNote)
		{
			if (!ModelState.IsValid || !IsPostValid(newNote))
			{
				MessageHelpers.SetError("We can't accept your note, sorry :(");
				return View(new CreateViewModel()
				{
					LoggedUserEntity = await _context.Users
					   .Where(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)).FirstOrDefaultAsync()
				});
			}

			_context.Notes.Add(newNote);
			await _context.SaveChangesAsync();

			int themeId = await _context.Themes.OrderByDescending(t => t.Id).Select(t => t.Id).FirstAsync();
			Post post = new Post()
			{
				UserID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value),
				NoteID = newNote.Id,
				Date = TimeHelpers.GetLocalDate(),
				RateCount = 0,
				RateUps = 0,
				CheckOut = false,
				ThemeID = themeId
			};
			_context.Posts.Add(post);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "Posts");
		}

		[HttpGet("Posts/Theme/{theme}")]
		public async Task<IActionResult> Theme(string theme)
		{
			if (string.IsNullOrEmpty(theme))
				return RedirectToAction("Posts", "Index");

			HttpContext.Session.SetString("moreposts", "yes");

			string themeName = _postServices.ReplaceTheme(theme);

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
			var theme_entity = await _context.Themes.Where(t => t.Name == themeName).FirstAsync();

			PostsViewModel model = new PostsViewModel()
			{
				LoggedUserEntity = user,
				TodayTheme = theme_entity,
			};
			return View(model);
		}

		private async Task<List<Theme>> GetThemes()
		{
			return await _context.Themes.OrderByDescending(t => t.Id).Take(2).ToListAsync();
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
				UserPhoto = "admin.jpg",
				Liked = "unliked",
				CanInteract = false
			};
		}


		[HttpGet]
		public async Task<IActionResult> LoadMoreData(string theme, int skip)
		{
			if (HttpContext.Session.GetString("moreposts") == "no") return NoContent();

			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			List<PostDetailModel> posts = new List<PostDetailModel>();

			int? themeId = await _context.Themes.Where(t => t.Name == _postServices.ReplaceTheme(theme)).Select(t => t.Id).FirstAsync();
			if (themeId != null)
				posts = await _postServices.GetPostsDetails(p => p.ThemeID == themeId.Value, 18, skip);

			if (posts.Count == 0)
			{
				HttpContext.Session.SetString("moreposts", "no");
				posts.Add(NoFoundPost("No posts about this title!", "Sorry, we could not find any new post :("));
			}

			return PartialView("_PostsPartial", posts);
		}

		private bool IsPostValid(Note note)
		{
			if (note.Title.Length < 5 || note.Title.Length > 30 || note.Content.Length < 30 || note.Content.Length > 250)
				return false;

			return true;
		}

		[HttpGet("Posts/Post/{id}")]
		public async Task<IActionResult> Post(string id)
		{
			if (!int.TryParse(id, out int postId))
				return RedirectToAction("Posts", "Index");

			var post = await _postServices.GetPostsDetails(p => p.ID == postId, 1);
			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));

			PostsViewModel model = new PostsViewModel()
			{
				LoggedUserEntity = user,
				PostsYesterday = post
			};
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> LikePost(int? postId)
		{
			if (postId == null) return Json(new { isSuccess = false });
			if (HttpContext.Session.GetString("LikeWait") == "wait") return Json(new { isSuccess = false });
			HttpContext.Session.SetString("LikeWait", "wait");
			var userId = (await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))).ID;
			var like = await _context.Likes.FirstOrDefaultAsync(l => l.PostID == postId && l.UserID == userId);

			if (like == null)
				_context.Add(new Like { PostID = postId.Value, UserID = userId });
			else
				_context.Remove(like);

			await _context.SaveChangesAsync();
			HttpContext.Session.SetString("LikeWait", "");
			return Json(new { isSuccess = true });
		}
	}
}
