using MemoMate.Data;
using MemoMate.Web.GeneralHelpers;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MemoMate.Web.Controllers
{
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
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
                return RedirectToAction("Index", "Posts");
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
                var existingUserByUsername = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username);
                if (existingUserByUsername != null)
                {
                    ModelState.AddModelError("Username", "This username is already taken.");
                }

                Debug.WriteLine("--COMPLETE");
				var existingUserByMail = await _context.Users.FirstOrDefaultAsync(u => u.Mail == model.Mail);
				if (existingUserByMail != null)
				{
					ModelState.AddModelError("Username", "This username is already taken.");
				}
				Debug.WriteLine("Mail Control");

                // Mail Control
                var existingUserByEmail = await _context.Users.FirstOrDefaultAsync(u => u.Mail == model.Mail);
                if (existingUserByEmail != null)
                {
                    ModelState.AddModelError("Mail", "This email is already registered.");
                }
                if (existingUserByUsername == null && existingUserByEmail == null)
                {
                    // New User
                    var user = new User
                    {
                        Username = model.Username,
                        Mail = model.Mail,
                        Password = model.Password,
                        Permissions = "g",
                        Photo = "def.jpg",
                        CreateDate = TimeHelpers.GetCurrentDate(),
                    };
                    Debug.WriteLine("----COMPLETE");

                    Debug.WriteLine("Add to database");

                    // Kullanıcıyı veritabanına ekle
                    _context.Users.Add(user);
                    Debug.WriteLine("----COMPLETE");

                    Debug.WriteLine("Save database");

                    await _context.SaveChangesAsync();
                    Debug.WriteLine("----COMPLETE");

                    // Oturum bilgilerini ayarla
                    HttpContext.Session.SetString("UserId", user.ID.ToString());
                    HttpContext.Session.SetString("Username", user.Username);
                    Debug.WriteLine("--COMPLETE");

                    return RedirectToAction("Index", "Posts"); // Başarılı kayıt durumunda yönlendirme
                }
            }

            foreach (var modelState in ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    Console.WriteLine(error.ErrorMessage); // Hata mesajlarını konsola yazdır
                }
            }

            return View("Index", model);
        }
    }
}
