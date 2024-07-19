using System.Collections.Generic;

namespace MemoMate.Web.Models.Posts
{
    public class PostsViewModel
    {
        public UserEntity LoggedUserEntity { get; set; }
        public Theme TodayTheme { get; set; }
        public string YesterdayThemeName { get; set; }
        public List<PostDetailModel> PostsYesterday { get; set; }
        public List<PostDetailModel> PostsCheckOut { get; set; }
    }
}
