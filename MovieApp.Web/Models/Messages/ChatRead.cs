using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models.Messages
{
    public class ChatRead
    {
        [Column("chat_read_id")]
        public int ID { get; set; }
        [Column("user_from_id")]
        public int FromID { get; set; }
        [Column("user_target_id")]
        public int TargetID { get; set; 
        }
        [Column("is_read")]
        public bool IsRead { get; set; }
    }
}
