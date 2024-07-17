using MemoMate.Data;
using MemoMate.Web.Models;
using MemoMate.Web.Models.Posts;
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

			var posts =  await query
					.Select(p => new PostDetailModel
					{
						PostID = p.ID,
						UserID = p.UserID,
						PostDate = p.Date,
						PostRate = p.RateUps * 5f / (p.RateCount == 0 ? 1 : p.RateCount),
						NoteContent = p.NoteEntity.Content,
						NoteTitle = p.NoteEntity.Title,
						Username = p.UserEntity.Username,
						UserPhoto = p.UserEntity.Photo,
						ThemeName = p.ThemeEntity.Name,
						Liked = _context.Likes.Any(l => l.UserID == user.ID && l.PostID == p.ID) ? "liked" : "unliked",
						IsOwned = p.UserID == user.ID,
						CanInteract = true
					})
				 .ToListAsync();

			foreach (var item in posts)
				item.FriendStatus = await GetFriendStatus(user.ID, item.UserID);

			return posts;
		}
		public async Task<string> GetFriendStatus(int userID, int targetID)
		{
			var friendship = await _context.Friends.Where(f => (f.UserFromID == userID && f.UserTargetID == targetID)
												   || (f.UserFromID == targetID && f.UserTargetID == userID)).FirstOrDefaultAsync();

			if (friendship == null) return "fa-plus";
			else if (friendship.IsAccepted) return "fa-check";
			else return "fa-envelope";
		} 
		public string ReplaceTheme(string theme)
		{
			string newTheme = theme.Replace('-', ' ');
			return newTheme.Replace("%20", " ");
		}
	}
}
