#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class RibbonController : Controller
    {
        //
        // GET: /Events/
        List<FontFamily> fontFamily = new List<FontFamily>();
        List<FontPoint> fontPoint = new List<FontPoint>();
        public ActionResult Events()
        {
            fontFamily.Add(new FontFamily { text = "Segoe UI" });
            fontFamily.Add(new FontFamily { text = "Arial" });
            fontFamily.Add(new FontFamily { text = "Times New Roman" });
            fontFamily.Add(new FontFamily { text = "Tahoma" });
            fontFamily.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource = fontFamily;
            fontPoint.Add(new FontPoint { text = "1pt" });
            fontPoint.Add(new FontPoint { text = "2pt" });
            fontPoint.Add(new FontPoint { text = "3pt" });
            fontPoint.Add(new FontPoint { text = "4pt" });
            fontPoint.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontPoint;
            return View();
        }

    }
}
