﻿using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //全てのクライアントにメッセージを送信する。
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
