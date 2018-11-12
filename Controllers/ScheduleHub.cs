using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public class ScheduleHub : Hub
    {
        public void Modify(string action, Object data)
        {
            Clients.Others.modify(action, data);
        }
    }
}