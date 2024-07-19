using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
    public class Like
	{
		[Column("like_id")]
		public int ID { get; set; }
		[Column("user_id")]
		public int UserID { get; set; }


		[Column("post_id")]
		public int PostID{ get; set; }
		
		public UserEntity UserEntity { get; set; }
		public Post PostEntiy { get; set; }
	}
}
