using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace ChatRoom.Hubs
{
    public class MainHub : Hub
    {
        public async Task SendMessageAsync()
        {
            try
            {
                await Clients.All.SendAsync("RecieveMessage");
            }
            catch (Exception ex) { Log.Error(ex, ""); }
        }
    }
}
