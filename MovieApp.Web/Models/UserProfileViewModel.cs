using System;
using System.Collections.Generic;

namespace MemoMate.Web.Models
{
	public class UserProfileViewModel
	{
		public User LoggedUserEntity { get; set; }
		public string Username { get; set; }
		public string Mail { get; set; }
		public string Photo { get; set; }
		public DateTime CreationDate { get; set; }
		public List<PostDetailModel> Posts { get; set; }
	}
}
