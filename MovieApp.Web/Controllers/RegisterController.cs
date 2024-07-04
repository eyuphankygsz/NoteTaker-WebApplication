using MemoMate.Data;
using MemoMate.Web.GeneralHelpers;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MemoMate.Web.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		private readonly MemoMateContext _context;

		public RegisterController(MemoMateContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			//if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
			//   	return RedirectToAction("Index", "Posts");
			return View(new UserRegisterModel());
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserRegisterModel model)
		{
			Debug.WriteLine("Take Action");
			if (ModelState.IsValid)
			{
				Debug.WriteLine("Username Control");
				// Username control

				if (!await IsUsernameValid(model.Username) || !await IsMailValid(model.Mail) || !IsPasswordValid(model.Password))
					return View("Index");


				// New User
				var user = new User
				{
					Username = model.Username,
					Mail = model.Mail,
					Password = model.Password,
					Role = "g",
					Photo = "def.jpg",
					CreateDate = TimeHelpers.GetLocalDate(),
				};


				_context.Users.Add(user);
				await _context.SaveChangesAsync();

				var claims = new List<Claim>
					{
						new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
						new Claim(ClaimTypes.Name, user.Username),
						new Claim(ClaimTypes.Role, user.Role)
					};
				var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

				var authProperties = new AuthenticationProperties
				{
					// İsteğe bağlı özellikler
				};
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
				return RedirectToAction("Index", "Posts");
			}
			MessageHelpers.SetError("You have to fill everything correctly!");
			return View();
		}
		private async Task<bool> IsUsernameValid(string username)
		{
			if (username.Length > 20)
				MessageHelpers.SetWarning("Username cannot be more than 20 characters.");

			if (username.Length < 5)
				MessageHelpers.SetWarning("Username must be at least 5 characters long.");

			if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
				MessageHelpers.SetWarning("Username can only contain alphanumeric characters.");

			if (await _context.Users.AnyAsync(u => u.Username == username))
				MessageHelpers.SetWarning("This username is already taken.");

			if (MessageHelpers.PostBack) return false;

			return true;
		}
		private async Task<bool> IsMailValid(string mail)
		{
			if (mail.Length > 50)
				MessageHelpers.SetWarning("Mail cannot be more than 50 characters.");

			if (mail.Length < 5)
				MessageHelpers.SetWarning("Mail must be at least 5 characters long.");

			if (!Regex.IsMatch(mail, @"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$"))
				MessageHelpers.SetWarning("Mail is not valid.");

			if (await _context.Users.AnyAsync(u => u.Mail == mail))
				MessageHelpers.SetWarning("This username is already taken.");

			if (MessageHelpers.PostBack) return false;

			return true;
		}
		private bool IsPasswordValid(string password)
		{
			if (password.Length > 50)
				MessageHelpers.SetWarning("Mail cannot be more than 50 characters.");

			if (password.Length < 8)
				MessageHelpers.SetWarning("Mail must be at least 8 characters long.");

			if (MessageHelpers.PostBack) return false;

			return true;
		}
	}




}



