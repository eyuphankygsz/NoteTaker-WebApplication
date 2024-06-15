using Microsoft.AspNetCore.Mvc;

namespace MemoMate.Web.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
