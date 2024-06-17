using System;
using System.Collections.Generic;

namespace MemoMate.Web.Models
{
	public class PostsViewModel
	{
		public User LoggedUserEntity { get; set; }
		public List<PostDetailModel> PostsDetails { get; set; }
	}
}
