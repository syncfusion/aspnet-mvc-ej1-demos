using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class RotatorController : Controller
    {
        //
        // GET: /RotatorEvents/
        List<localdata> LocalElements = new List<localdata>();
        public ActionResult Events()
        {
            LocalElements.Add(new localdata { text = "tablet", url = "../Images/rotator/tablet.jpg" });
            LocalElements.Add(new localdata { text = "nature", url = "../Images/rotator/nature.jpg" });
            LocalElements.Add(new localdata { text = "snowfall", url = "../Images/rotator/snowfall.jpg" });
            LocalElements.Add(new localdata { text = "card", url = "../Images/rotator/card.jpg" });
            LocalElements.Add(new localdata { text = "sculpture", url = "../Images/rotator/sculpture.jpg" });
            LocalElements.Add(new localdata { text = "night", url = "../Images/rotator/night.jpg" });            
            ViewBag.datasource = LocalElements;
            return View();
        }

    }
}
