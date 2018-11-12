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
        // GET: /RotatorLocalData/
        List<localdata> LocalValues = new List<localdata>();
        public ActionResult LocalData()
        {    
           LocalValues.Add(new localdata{ text= "Beautiful Bird", url= "../Images/rotator/bird.jpg" });
           LocalValues.Add(new localdata { text = "Colorful Night", url = "../Images/rotator/night.jpg" });
           LocalValues.Add(new localdata { text = "Technology", url = "../Images/rotator/tablet.jpg" });
           LocalValues.Add(new localdata { text = "Nature", url = "../Images/rotator/nature.jpg" });
           LocalValues.Add(new localdata { text = "Snow Fall", url = "../Images/rotator/snowfall.jpg" });
           LocalValues.Add(new localdata { text = "Credit Card", url = "../Images/rotator/card.jpg" });
           LocalValues.Add(new localdata { text = "Amazing Sculptures", url = "../Images/rotator/sculpture.jpg" });
            ViewBag.datasource=LocalValues;
            return View();
        }

    }
}
