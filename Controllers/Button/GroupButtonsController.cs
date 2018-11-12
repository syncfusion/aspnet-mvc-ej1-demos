using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ButtonController : Controller
    {
        //
        // GET: /ButtonGroupButtons/
        List<GroupJson> grpbtn = new List<GroupJson>();
        public ActionResult GroupButtons()
        {
            grpbtn.Add(new GroupJson { text = "Day", contentType = "textonly" });
            grpbtn.Add(new GroupJson { text = "Week", contentType = "textonly" });
            grpbtn.Add(new GroupJson { text = "Work Week", contentType = "textonly" });
            grpbtn.Add(new GroupJson { text = "Month", contentType = "textonly", selected = "selected" });
            grpbtn.Add(new GroupJson { text = "Agenda", contentType = "textonly" });
            ViewBag.datasource = grpbtn;
            return View();
        }

    }
}
