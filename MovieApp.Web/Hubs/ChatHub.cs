using MemoMate.Web.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MemoMate.Web.Hubs
{
	public class ChatHub : Hub
	{

		public async Task SendMessage(Message message)
		{
			await Clients.User(message.UserTargetID.ToString()).SendAsync("ReceiveMessage");
			return;
		}
	}
}
