using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.CustomMiddlewares
{
	public class IndexRedirectMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly string[] paths = new string[]
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
			Debug.WriteLine(context.Request.Path.Value.ToLower());
            if (string.IsNullOrEmpty(context.Session.GetString("UserId")) && !paths.Contains(context.Request.Path.Value.ToLower()))
			{
				Debug.WriteLine("ROUTING TO...");
				context.Response.Redirect("/");
				return;
			}

			await _next(context);
		}



	}
}
