using Microsoft.AspNetCore.Mvc;

namespace MemoMate.Web.Controllers
{
	public class RegisterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
