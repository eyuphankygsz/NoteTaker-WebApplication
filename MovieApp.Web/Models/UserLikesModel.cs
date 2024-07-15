using System.Collections.Generic;
using System;

namespace MemoMate.Web.Models
{
    public class UserLikesModel
    {
        public User LoggedUserEntity { get; set; }
        public List<PostDetailModel> Posts { get; set; }
    }
}
