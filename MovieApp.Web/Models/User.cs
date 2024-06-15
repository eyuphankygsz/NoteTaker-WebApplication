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


		[Column("user_photo")]
		public string Photo { get; private set; }


		[Column("user_pass")]
		public string Password { get; private set; }


		[Column("user_mail")]
		public string Mail { get; private set; }


		public List<Note> Notes { get; private set; }
	}
}
