using MemoMate.Data;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly MemoMateContext _context;

        public UserController(MemoMateContext context)
        {
            _context = context;
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

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        private async Task<UserProfileViewModel> GetProfileAsync(string username)
        {
			var loggedUser = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId")));

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
                        UserPhoto = u.Photo
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            return profile;
        }


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
