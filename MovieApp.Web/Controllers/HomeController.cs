using Microsoft.AspNetCore.Mvc;
using MemoMate.Data;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Diagnostics;

namespace MemoMate.Web.Controllers
{
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
			if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
				return RedirectToAction("Index","Posts");
			return View(new UserLoginViewModel());
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

				if (user != null)
				{
					// Oturum bilgilerini ayarlayın
					HttpContext.Session.SetString("UserId", user.ID.ToString());
					HttpContext.Session.SetString("Username", user.Username);

					Debug.WriteLine(user.Username);
					return RedirectToAction("Index", "Posts"); // Başarılı giriş durumunda yönlendirme
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt."); // Geçersiz giriş denemesi hatası ekle
				}
			}

			// Eğer buraya geldiyse, model geçersizdir veya giriş bilgileri hatalıdır
			// Hata mesajlarını kontrol edin
			foreach (var modelState in ModelState.Values)
			{
				foreach (var error in modelState.Errors)
				{
					Console.WriteLine(error.ErrorMessage); // Hata mesajlarını konsola yazdır
				}
			}

			return View(model);
		}



		public IActionResult About()
		{
			return View();
		}
	}
}
