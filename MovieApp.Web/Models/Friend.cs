using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Friend
	{
		[Column("friendship_id")]
		public int ID { get; set; }
		[Column("first_user_id")]
		public int FirstUserID { get; set; }
		[Column("second_user_id")]
		public int SecondUserID { get; set; }
	}
}
