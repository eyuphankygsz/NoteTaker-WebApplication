using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using MemoMate.Data;
using MemoMate.Web.CustomMiddlewares;
using Microsoft.Extensions.Options;
using MemoMate.Web.Interfaces;
using MemoMate.Web.Services;

namespace MovieApp.Web
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSession();

			services.AddDbContext<MemoMateContext>(options =>
		options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
		sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));


			services.AddScoped<ISidebarService, SidebarServices>();

			services.AddControllersWithViews();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();
			app.UseSession();
			app.UseRouting();

			app.UseMiddleware<IndexRedirectMiddleware>();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action}/{id?}",
					defaults: new { controller = "Home", action = "Index" }
					);
			});
		}
	}
}
