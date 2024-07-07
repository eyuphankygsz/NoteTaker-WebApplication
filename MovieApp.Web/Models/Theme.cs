using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Theme
	{
		[Column("theme_id")]
		public int Id { get; set; }
		[Column("theme_name")]
		public string Name { get; set; }
		[Column("theme_photo")]
		public string PhotoURL { get; set; }
	}
}
