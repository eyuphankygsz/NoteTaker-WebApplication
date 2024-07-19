using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMate.Web.Models
{
    public class Post
    {

        [Column("post_id")]
        public int ID { get; set; }


        [Column("note_id")]
        public int NoteID { get; set; }


        [Column("user_id")]
        public int UserID { get; set; }


        [Column("post_date")]
        public DateTime Date { get; set; }

        [Column("rate_ups")]
        public int RateUps { get; set; }

        [Column("rate_count")]
        public int RateCount { get; set; }

        [Column("check_out")]
        public bool CheckOut { get; set; }

        [Column("theme_id")]
        public int ThemeID { get; set; }

        public Note NoteEntity { get; set; }
        public UserEntity UserEntity { get; set; }
        public Theme ThemeEntity { get; set; }
    }
}
