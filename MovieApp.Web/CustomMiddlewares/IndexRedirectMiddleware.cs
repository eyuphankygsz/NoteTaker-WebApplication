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
			"/home/about"
		};
		public IndexRedirectMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
            if (string.IsNullOrEmpty(context.Session.GetString("UserId")) && !paths.Contains(context.Request.Path.Value.ToLower()))
			{
				context.Response.Redirect("/");
				return;
			}

			await _next(context);
		}



	}
}
