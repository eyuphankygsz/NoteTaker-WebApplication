using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MemoMate.Web.Models
{
	public class Rate
	{
		[Column("rate_id")]
		public int ID { get; set; }
		

		[Column("post_id")]
		public int PostID { get;set; }


		[Column("user_id")]
		public int UserID { get; set; }

		public Note NoteEntity { get; private set; }
		public User UserEntity { get; private set; }
	}
}
