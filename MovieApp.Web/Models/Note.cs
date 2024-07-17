using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Note
	{

		[Column("note_id")]
		public int Id { get; private set; }
		
		[Column("note_title")]
		public string Title { get; set; }
		
		[Column("note_content")]
		public string Content { get; set; }
	}
}
