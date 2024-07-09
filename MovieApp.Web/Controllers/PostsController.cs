﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MemoMate.Web.Models;
using MemoMate.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using MemoMate.Web.GeneralHelpers;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MemoMate.Web.Controllers
{
	[Authorize(Policy = "General")]
	public class PostsController : Controller
	{
		private readonly MemoMateContext _context;
		private string[] themeNames;
		public PostsController(MemoMateContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			//if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
			//	  return RedirectToAction("Index", "Home");

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var postsYesterday = await GetPostsDetails(p => p.Date >= today.AddDays(-1) && p.Date < today, 3);
			if (postsYesterday.Count == 0)
				postsYesterday.Add(NoFoundPost("No posts found...", "We couldn't find any posts shared yesterday... why..."));

			var postsCheckOut = await GetPostsDetails(p => p.Date >= today && p.CheckOut, 3);

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

			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value));
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

		public async Task<List<PostDetailModel>> GetPostsDetails(Expression<Func<Post, bool>> whereCondition, int? take = null, int? skip = null, bool orderByRateDescending = true)
		{
			var query = _context.Posts
					.Include(p => p.UserEntity)
					.Include(p => p.NoteEntity)
					.Include(p => p.ThemeEntity)
					.Where(whereCondition);

			if (orderByRateDescending)
				query = query.OrderByDescending(p => p.RateUps / (p.RateCount == 0 ? 1 : p.RateCount));

			if (skip.HasValue)
				query = query.Skip(skip.Value);

			if (take.HasValue)
				query = query.Take(take.Value);


			return await query
					.Select(p => new PostDetailModel
					{
						PostID = p.ID,
						PostDate = p.Date,
						PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
						NoteContent = p.NoteEntity.Content,
						NoteTitle = p.NoteEntity.Title,
						Username = p.UserEntity.Username,
						UserPhoto = p.UserEntity.Photo,
						ThemeName = p.ThemeEntity.Name
					})
				 .ToListAsync();
		}
		private async Task<List<Theme>> GetThemes() {
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
				UserPhoto = "admin.jpg"
			};
		}


		[HttpGet]
		public async Task<IActionResult> LoadMoreData(int skip, int take)
		{
			DateTime now = TimeHelpers.GetLocalDate();
			DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			var posts = await GetPostsDetails(p => p.Date >= today, take, skip);

			return PartialView("_PostsPartial", posts);
		}

		private bool IsPostValid(Note note)
		{
			if (note.Title.Length < 5 || note.Title.Length > 30 || note.Content.Length < 30 || note.Content.Length > 250)
				return false;

			return true;
		}
	}
}
