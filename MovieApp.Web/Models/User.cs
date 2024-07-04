using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class User
	{
		[Column("user_id")]
		public int ID { get; set; }


		[Column("user_name")]
		public string Username { get; set; }


		[Column("user_pass")]
		public string Password { get; set; }


		[Column("user_mail")]
		public string Mail { get; set; }


		[Column("user_photo")]
		public string Photo { get; set; }


		[Column("user_role")]
		public string Role { get; set; }


		[Column("user_create_date")]
		public DateTime CreateDate { get; set; }

		public List<Post> Posts { get; private set; }
	}
}
