using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Post
	{

		[Column("post_id")]
		public int ID { get; private set; }


		[Column("note_id")]
		public int NoteID{ get; private set; }


		[Column("user_id")]
		public int UserID { get; private set; }


		[Column("post_date")]
		public DateTime Date { get; private set; }


		public Note NoteEntity { get; private set; }
		public User UserEntity { get; private set; }
	}
}
