using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Friend
	{
		[Column("friendship_id")]
		public int ID { get; set; }
		[Column("user_from_id")]
		public int UserFromID { get; set; }
		[Column("user_target_id")]
		public int UserTargetID { get; set; }
		[Column("is_accepted")]
		public bool IsAccepted { get; set; }
	}
}
