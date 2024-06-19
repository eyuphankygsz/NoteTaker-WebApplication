using MemoMate.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : Controller
	{
		private readonly MemoMateContext _context;

		public UserController(MemoMateContext context)
		{
			_context = context;
		}
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Index","");
		}


		[HttpGet("validate-username")]
		public async Task<IActionResult> ValidateUsername(string username)
		{
			var user = await _context.Users
							 .Where(u => u.Username == username)
							 .AnyAsync();


			return Ok(new { isValid = user });
		}

		[HttpGet("validate-mail")]
		public async Task<IActionResult> ValidateMail(string mail)
		{
			var user = await _context.Users
							 .Where(u => u.Mail == mail)
							 .AnyAsync();


			return Ok(new { isValid = user });
		}
	}
}
