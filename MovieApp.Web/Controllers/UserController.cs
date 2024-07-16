﻿using MemoMate.Data;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using MemoMate.Web.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MemoMate.Web.GeneralHelpers;

namespace MemoMate.Web.Controllers
{
	[Authorize(Policy = "General")]
	public class UserController : Controller
	{
		private readonly MemoMateContext _context;
		private readonly PostServices _postServices;
		public UserController(MemoMateContext context, PostServices postServices)
		{
			_context = context;
			_postServices = postServices;
		}

		[HttpGet("User/Details/{username}")]
		public async Task<IActionResult> Details(string username)
		{
			if (string.IsNullOrEmpty(username))
				return RedirectToAction("Index", "Home");

			var profile = await GetProfileAsync(username);

			if (profile == null)
				return NotFound();

			return View(profile);
		}
		[HttpGet]
		public async Task<IActionResult> Likes()
		{
			var loggedUser = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
			var likedPosts = await _context.Likes
								   .Include(l => l.PostEntiy)
								   .Where(l => l.UserID == loggedUser.ID)
								   .OrderByDescending(l => l.ID)
								   .Select(l => new PostDetailModel
								   {
									   PostID = l.PostEntiy.ID,
									   PostDate = l.PostEntiy.Date,
									   PostRate = l.PostEntiy.RateUps * 5f / (l.PostEntiy.RateCount == 0 ? 1 : l.PostEntiy.RateCount),
									   NoteContent = l.PostEntiy.NoteEntity.Content,
									   NoteTitle = l.PostEntiy.NoteEntity.Title,
									   Username = l.PostEntiy.UserEntity.Username,
									   UserPhoto = l.PostEntiy.UserEntity.Photo,
									   ThemeName = l.PostEntiy.ThemeEntity.Name,
									   Liked = _context.Likes.Any(l => l.UserID == loggedUser.ID && l.PostID == l.PostEntiy.ID) ? "liked" : "unliked",
									   IsFriend = _context.Friends.Any(f => (f.FirstUserID == loggedUser.ID && f.SecondUserID == l.PostEntiy.UserID)
																		 || (f.FirstUserID == l.PostEntiy.UserID && f.SecondUserID == l.PostEntiy.ID)) ? "fa-check" : "fa-plus",
									   IsOwned = l.PostEntiy.UserID == loggedUser.ID,
									   CanInteract = true
								   })
								   .ToListAsync();
			if (likedPosts == null || likedPosts.Count == 0)
			{
				MessageHelpers.SetWarning("You haven't liked any posts.");
				return RedirectToAction("Index", "Posts");
			}

			UserLikesModel model = new UserLikesModel()
			{
				Posts = likedPosts,
				LoggedUserEntity = loggedUser
			};
			return View(model);
		}


		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			HttpContext.Session.Clear();
			return RedirectToAction("Index", "Home");

		}

		private async Task<UserProfileViewModel> GetProfileAsync(string username)
		{
			var loggedUser = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
			var profile = await _context.Users
				.Where(u => u.Username == username)
				.Select(u => new UserProfileViewModel
				{
					LoggedUserEntity = loggedUser,
					Username = u.Username,
					CreationDate = u.CreateDate,
					Mail = u.Mail,
					Photo = u.Photo,
					Posts = u.Posts.Select(p => new PostDetailModel
					{
						PostID = p.ID,
						NoteTitle = p.NoteEntity.Title,
						NoteContent = p.NoteEntity.Content,
						PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
						PostDate = p.Date,
						Username = u.Username,
						UserPhoto = u.Photo,

					}).ToList()
				})
				.FirstOrDefaultAsync();

			return profile;
		}

		public async Task<IActionResult> Follow(string postId)
		{
			if (string.IsNullOrEmpty(postId))
				return Json(new { isSuccess = false });

			if (int.TryParse(postId, out var id))
			{
				HttpContext.Session.SetString("FollowWait", "false");
				if (HttpContext.Session.GetString("FollowWait") == "wait")
					return FollowError();
				HttpContext.Session.SetString("FollowWait", "wait");

				var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
				var followedUser = await _context.Posts
					   .Where(p => p.ID == id)
					   .Select(p => p.UserID)
					   .FirstAsync();

				if (userId == followedUser)
					return FollowError();

				var friend = await _context.Friends.Where(f => (f.FirstUserID == userId && f.SecondUserID == followedUser)
																|| (f.FirstUserID == followedUser && f.SecondUserID == userId)).FirstOrDefaultAsync();

				if (friend == null)
					_context.Add(new Friend { FirstUserID = userId, SecondUserID = followedUser });
				else
					_context.Remove(friend);

				await _context.SaveChangesAsync();
				HttpContext.Session.SetString("LikeWait", "");
				return Json(new { isSuccess = true });
			}
			else
			{
				MessageHelpers.SetWarning("No User Found.");
				return RedirectToAction("Index", "Posts");
			}
		}

		private JsonResult FollowError()
		{
			HttpContext.Session.SetString("LikeWait", "");
			return Json(new { isSuccess = false });
		}
		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> UsernameValidation(string username)
		{
			try
			{
				var isUsernameTaken = await _context.Users.AnyAsync(u => u.Username == username);
				return Json(new { isValid = !isUsernameTaken });
			}
			catch (Exception ex)
			{
				// Loglama için hata mesajı yazdırılabilir
				Console.WriteLine(ex.Message);
				return Json(new { isValid = false });
			}
		}

		[AllowAnonymous]

		[HttpPost]
		public async Task<IActionResult> UserMailValidation(string mail)
		{
			try
			{
				var isMailTaken = await _context.Users.AnyAsync(u => u.Mail == mail);
				return Json(new { isValid = !isMailTaken });
			}
			catch (Exception ex)
			{
				// Loglama için hata mesajı yazdırılabilir
				Console.WriteLine(ex.Message);
				return Json(new { isValid = false });
			}
		}

	}
}
