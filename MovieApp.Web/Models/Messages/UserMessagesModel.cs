using System.Collections.Generic;
namespace MemoMate.Web.Models.Messages
{
    public class UserMessagesModel
    {
        public User LoggedUserEntity { get; set; }
        public Dictionary<User, List<Message>> Messages { get; set; }
    }
}
