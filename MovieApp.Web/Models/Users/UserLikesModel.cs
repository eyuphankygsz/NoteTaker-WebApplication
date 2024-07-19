using System.Collections.Generic;
using MemoMate.Web.Models;
using MemoMate.Web.Models.Posts;

namespace MemoMate.Web.Models.Users
{
    public class UserLikesModel
    {
        public UserEntity LoggedUserEntity { get; set; }
        public List<PostDetailModel> Posts { get; set; }
    }
}
