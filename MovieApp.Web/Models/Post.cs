using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Post
	{

		[Column("post_id")]
		public int ID { get; private set; }


		[Column("note_id")]
		public int NoteID{ get; set; }


		[Column("user_id")]
		public int UserID { get; set; }


		[Column("post_date")]
		public DateTime Date { get; set; }

		[Column("rate_ups")]
		public int RateUps { get; set; }

		[Column("rate_count")]
		public int RateCount { get; set; }


		public Note NoteEntity { get; private set; }
		public User UserEntity { get; private set; }
	}
}
