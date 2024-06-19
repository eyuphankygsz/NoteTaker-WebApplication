using System;

namespace MemoMate.Web.Models
{
	public class PostDetailModel
	{
		public int PostID { get; set; }
		public DateTime PostDate { get; set; }
		public string NoteTitle { get; set; }
		public string NoteContent { get; set; }
		public float PostRate { get; set; }
		public string Username { get; set; }
		public string UserPhoto { get; set; }
	}
}
