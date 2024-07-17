using System.Collections.Generic;
using MemoMate.Web.Models;
using MemoMate.Web.Models.Posts;

namespace MemoMate.Web.Models.Users
{
    public class UserLikesModel
    {
        public User LoggedUserEntity { get; set; }
        public List<PostDetailModel> Posts { get; set; }
    }
}
