﻿using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(SignalR.Chat.DotNetFrameWork.Startup))]
namespace SignalR.Chat.DotNetFrameWork
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
