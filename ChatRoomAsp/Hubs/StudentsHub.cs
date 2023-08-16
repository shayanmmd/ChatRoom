using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatRoomAsp.Hubs
{
    
    public class StudentsHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public async Task SendMessageAsync(string name,string textMessage)
        {
            await Clients.All.SendAsync("RecieveMessage", name, textMessage);
        }
    }
}
