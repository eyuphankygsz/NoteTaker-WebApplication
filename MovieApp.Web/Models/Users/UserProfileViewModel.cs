using System;
using System.Collections.Generic;
using MemoMate.Web.Models;
using MemoMate.Web.Models.Posts;

namespace MemoMate.Web.Models.Users
{
    public class UserProfileViewModel
    {
        public UserEntity LoggedUserEntity { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Photo { get; set; }
        public DateTime CreationDate { get; set; }
        public List<PostDetailModel> Posts { get; set; }
        public string FriendStatus { get; set; }
        public bool IsOwn { get; set; }
    }
}
