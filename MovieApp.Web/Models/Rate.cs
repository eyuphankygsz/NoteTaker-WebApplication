using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
    public class Rate
    {
        [Column("rate_id")]
        public int ID { get; set; }


        [Column("post_id")]
        public int PostID { get; set; }


        [Column("user_id")]
        public int UserID { get; set; }

        public Post PostEntity { get; private set; }
        public UserEntity UserEntity { get; private set; }
    }
}
