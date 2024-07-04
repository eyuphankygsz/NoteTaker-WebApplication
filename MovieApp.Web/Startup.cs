using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using MemoMate.Data;
using MemoMate.Web.Interfaces;
using MemoMate.Web.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using MemoMate.Web.Security;
using Microsoft.AspNetCore.Authorization;
using MemoMate.Web.CustomMiddlewares;

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

			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				 .AddCookie(options =>
				 {
					 options.LoginPath = "/Home/Index";
					 options.LogoutPath = "/User/Logout";
					 options.AccessDeniedPath = "/Home/AccessDenied";
				 });

			services.AddAuthorization(options =>
			{
				options.AddPolicy("General", policy =>
					policy.Requirements.Add(new RolesRequirement(new[] { "User", "Admin", "Moderator" })));

				options.AddPolicy("Authorized", policy =>
					policy.Requirements.Add(new RolesRequirement(new[] { "Admin", "Moderator" })));
			});
			services.AddSingleton<IAuthorizationHandler, RolesAuthorizationHandler>();

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

			app.UseAuthentication();
			app.UseAuthorization();

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
