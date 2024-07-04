using System;
using System.Collections.Generic;

namespace MemoMate.Web.Models
{
	public class PostsViewModel
	{
		public User LoggedUserEntity { get; set; }
		public string TodayThemeName { get; set; }
		public string YesterdayThemeName { get; set; }
		public List<PostDetailModel> PostsYesterday { get; set; }
		public List<PostDetailModel> PostsCheckOut { get; set; }
	}
}
