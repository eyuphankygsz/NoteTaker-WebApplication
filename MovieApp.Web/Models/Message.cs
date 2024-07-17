using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
	public class Message
	{
		[Column("message_id")]
		public int ID { get; set; }
		[Column("user_from_id")]
		public int UserFromID { get; set; }
		[Column("user_target_id")]
		public int UserTargetID { get; set; }
		[Column("message_content")]
		public string Content { get; set; }
		[Column("sent_date")]
		public DateTime SentDate { get; set; }
	}
}
