using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat.ChatHub
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
        }
    }
}