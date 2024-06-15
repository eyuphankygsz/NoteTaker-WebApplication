using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Note
	{

		[Column("note_id")]
		public int Id { get; private set; }
		
		[Column("note_title")]
		public string Title { get; private set; }
		
		[Column("note_content")]
		public string Content { get; private set; }
		[Column("note_creator")]
		public int CreatorId { get; private set; }
		[Column("note_date")]
		public DateTime Date {  get; private set; }

		public User Creator { get; private set; }
	}
}
