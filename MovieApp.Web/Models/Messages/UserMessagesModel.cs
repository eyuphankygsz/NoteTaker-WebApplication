using System.Collections.Generic;
namespace MemoMate.Web.Models.Messages
{
	public class UserMessagesModel
	{
		public UserEntity LoggedUserEntity { get; set; }
		public Dictionary<UserEntity, Message> Messages { get; set; }
	}

	public class SelectedUserMessages
	{
		public UserEntity LoggedUser { get; set; }
		public UserEntity User { get; set; }
		public List<Message> Messages { get; set; }
	}
}
