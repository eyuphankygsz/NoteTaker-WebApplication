using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.CustomMiddlewares
{
	public class IndexRedirectMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly string[] protectedPaths = new string[]
		{
			"/",
			"/home",
			"/home/index",
			"/home/about",
			"/register",
			"/register/index",
			"/user/usermailvalidation",
			"/user/usernamevalidation",
		};

		public IndexRedirectMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			string requestPath = context.Request.Path.Value.ToLower();

			if (context.User.Identity.IsAuthenticated && IsProtectedPath(requestPath))
			{
				Debug.WriteLine($"Redirecting unauthorized access to {requestPath}");
				context.Response.Redirect("/Posts");
				return;
			}

			await _next(context);
		}

		private bool IsProtectedPath(string path)
		{
			return protectedPaths.Contains(path);
		}
	}
}
