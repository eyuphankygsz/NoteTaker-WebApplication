using Microsoft.AspNetCore.Mvc;
using MemoMate.Data;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace MemoMate.Web.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		private readonly MemoMateContext _context;

		public HomeController(MemoMateContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View(new UserLoginModel());
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserLoginModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

				if (user != null)
				{
					var claims = new List<Claim>
					{
						new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
						new Claim(ClaimTypes.Name, user.Username),
						new Claim(ClaimTypes.Role, user.Role) //TODO: Düzenle
					};
					var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

					var authProperties = new AuthenticationProperties
					{
						// İsteğe bağlı özellikler
					};
					await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
					return RedirectToAction("Index", "Posts");
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
				}
			}

			foreach (var modelState in ModelState.Values)
			{
				foreach (var error in modelState.Errors)
				{
					Console.WriteLine(error.ErrorMessage);
				}
			}

			return View();
		}



		public IActionResult About()
		{
			return View();
		}
		public IActionResult AccessDenied() => View();
	}
}
