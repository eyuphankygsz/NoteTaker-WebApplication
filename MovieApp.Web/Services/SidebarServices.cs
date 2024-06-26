using MemoMate.Data;
using MemoMate.Web.GeneralHelpers;
using MemoMate.Web.Interfaces;
using MemoMate.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.Services
{
	public class SidebarServices : ISidebarService
	{
		private readonly MemoMateContext _context;

		public SidebarServices(MemoMateContext context)
		{
			_context = context;
		}

		public async Task<SidebarModel> GetSidebarModelAsync(User user)
		{
			DateTime now = TimeHelpers.GetLocalDate();
			var sidebarModel = new SidebarModel
			{
				LoggedUserEntity = user,
				NewPostCount = await _context.Posts
					.Include(p => p.UserEntity)
					.Include(p => p.NoteEntity)
					.Where(p => p.UserID != user.ID && p.Date >= new DateTime(now.Year,now.Month,now.Day, 0, 0, 0) &&
								!_context.Rates.Any(r => r.PostID == p.ID && r.UserID == user.ID))
					.CountAsync()
			};

			return sidebarModel;
		}
	}
}
