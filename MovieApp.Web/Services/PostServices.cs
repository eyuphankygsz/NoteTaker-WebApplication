using MemoMate.Data;
using MemoMate.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MemoMate.Web.Services
{
	public class PostServices
	{
		private readonly MemoMateContext _context;
		private readonly IHttpContextAccessor _httpContextAccessor;


		public PostServices(MemoMateContext context, IHttpContextAccessor httpContextAccessor)
		{
			_context = context;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<List<PostDetailModel>> GetPostsDetails(Expression<Func<Post, bool>> whereCondition, int? take = null, int? skip = null, bool orderByRateDescending = true)
		{
			var query = _context.Posts
					.Include(p => p.UserEntity)
					.Include(p => p.NoteEntity)
					.Include(p => p.ThemeEntity)
					.Where(whereCondition);

			if (orderByRateDescending)
				query = query.OrderByDescending(p => p.RateUps / (p.RateCount == 0 ? 1 : p.RateCount));

			if (skip.HasValue)
				query = query.Skip(skip.Value);

			if (take.HasValue)
				query = query.Take(take.Value);

			var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == int.Parse(userId));

			return await query
					.Select(p => new PostDetailModel
					{
						PostID = p.ID,
						PostDate = p.Date,
						PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
						NoteContent = p.NoteEntity.Content,
						NoteTitle = p.NoteEntity.Title,
						Username = p.UserEntity.Username,
						UserPhoto = p.UserEntity.Photo,
						ThemeName = p.ThemeEntity.Name,
						Liked = _context.Likes.Any(l => l.UserID == user.ID && l.PostID == p.ID) ? "liked" : "unliked",
						IsFriend = _context.Friends.Any(f => (f.FirstUserID == user.ID && f.SecondUserID == p.UserID)
														 || (f.FirstUserID == p.UserID && f.SecondUserID == user.ID)) ? "fa-check" : "fa-plus",
						IsOwned = p.UserID == user.ID,
						CanInteract = true
					})
				 .ToListAsync();
		}
		public string ReplaceTheme(string theme)
		{
			string newTheme = theme.Replace('-', ' ');
			return newTheme.Replace("%20", " ");
		}
	}
}
