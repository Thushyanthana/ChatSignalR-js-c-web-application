using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        //ReceiveMessage is a method  same in Angular Application
        //Define Method
        public async Task SendMessage (string userName,string Message)
            {
            await Clients.All.SendAsync("ReceiveMessage", userName, Message);
            }
        
    }
}
