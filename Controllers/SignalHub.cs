using Microsoft.AspNet.SignalR;
using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Controllers
{
    public class SignalHub:Hub
    {
        public void Modify(string name, string action, EditableOrder data)
        {
            Clients.Others.modify(name, action, data);
        }
    }
}