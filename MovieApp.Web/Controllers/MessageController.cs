using Microsoft.AspNetCore.Mvc;

namespace MemoMate.Web.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
