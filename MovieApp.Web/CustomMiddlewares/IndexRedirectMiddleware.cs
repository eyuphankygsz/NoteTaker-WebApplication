using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MemoMate.Web.CustomMiddlewares
{
	public class IndexRedirectMiddleware
	{
		private readonly RequestDelegate _next;
		
		public IndexRedirectMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			if (context.Request.Path.HasValue && context.Request.Path.Value.ToLower().EndsWith("/index"))
			{
				var newPath = context.Request.Path.Value.Substring(0, context.Request.Path.Value.Length - 6);
				if(string.IsNullOrEmpty(newPath)) 
					newPath = "/";
				context.Response.Redirect(newPath);
				return;
			}

			await _next(context);
		}



	}
}
