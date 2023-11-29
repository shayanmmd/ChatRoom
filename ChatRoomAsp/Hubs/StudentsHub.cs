using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatRoomAsp.Hubs
{

    public class StudentsHub : Hub
    {

        public async Task SendMessageAsync(string textMessage)
        {            
            await Clients.Others.SendAsync("RecieveMessage", textMessage);
        }
    }
}
