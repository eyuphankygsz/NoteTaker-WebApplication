using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MemoMate.Web.Models;
using MemoMate.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace MemoMate.Web.Controllers
{

	public class PostsController : Controller
	{
		private readonly MemoMateContext _context;

		public PostsController(MemoMateContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var notes = await _context.Notes.Include(u => u.Creator).OrderByDescending(n => n.Date).Take(10).ToListAsync();
			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(HttpContext.Session.GetString("UserId")));

			PostsViewModel model = new PostsViewModel(){ User = user, Notes = notes };

			return View(model); // Pass List<Note> to the view
		}

	}

}
