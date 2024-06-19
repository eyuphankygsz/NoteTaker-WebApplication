﻿using System;
using System.Collections.Generic;

namespace MemoMate.Web.Models
{
	public class PostsViewModel
	{
		public User LoggedUserEntity { get; set; }
		public List<PostDetailModel> PostsToday { get; set; }
		public List<PostDetailModel> PostsYesterday { get; set; }
	}
}
