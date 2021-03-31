#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
    public partial class ToolbarController : Controller
    {
        //
        // GET: /ToolbarLocalDataBinding/
        List<ToolbarLocalBinding> t = new List<ToolbarLocalBinding>();
        public ActionResult LocalDataBinding()
        {
            t.Add(new ToolbarLocalBinding { empid = "1", spriteCss = "ieb", group="g1" });
            t.Add(new ToolbarLocalBinding { empid = "2", spriteCss = "chromeb", group = "g2" });
            t.Add(new ToolbarLocalBinding { empid = "3", spriteCss = "firefoxb", group = "g2" });
            t.Add(new ToolbarLocalBinding { empid = "4", spriteCss = "bittyb", group = "g2" });
            t.Add(new ToolbarLocalBinding { empid = "5", spriteCss = "operab", group = "g1" });
            ViewBag.datasource = t;
            return View();
        }

    }
}
