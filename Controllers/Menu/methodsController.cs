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
    public partial class MenuController : Controller
    {
        //
        // GET: /Menumethods/
        List<Menumethods> m = new List<Menumethods>();
        public ActionResult methods()
        {
            m.Add(new Menumethods { text = "Home" });
            m.Add(new Menumethods { text = "Search Jobs" });
            m.Add(new Menumethods { text = "Post Resume" });
            m.Add(new Menumethods { text = "JobSeeker Login" });
            m.Add(new Menumethods { text = "Fast Forward" });
            m.Add(new Menumethods { text = "More" });
            ViewBag.datasource = m;
            return View();
        }

    }
}
