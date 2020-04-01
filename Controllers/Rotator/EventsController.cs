#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
