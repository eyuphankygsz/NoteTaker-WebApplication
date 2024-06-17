using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class User
	{
		[Column("user_id")]
		public int ID { get; private set; }


		[Column("user_name")]
		public string Username { get; private set; }


		[Column("user_pass")]
		public string Password { get; private set; }


		[Column("user_mail")]
		public string Mail { get; private set; }


		[Column("user_photo")]
		public string Photo { get; private set; }


		[Column("user_permissions")]
		public string Permissions { get; private set; }


		[Column("user_create_date")]
		public DateTime CreateDate { get; private set; }

		public List<Post> Posts { get; private set; }
	}
}
