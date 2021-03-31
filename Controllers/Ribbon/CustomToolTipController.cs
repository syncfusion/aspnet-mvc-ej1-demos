#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
        // GET: /DefaultFunctionalities/
        List<FontFamily> fontFamily3 = new List<FontFamily>();
        List<FontPoint> fontPoint3 = new List<FontPoint>();
        public ActionResult CustomToolTip()
        {
           fontFamily3.Add(new FontFamily { text = "Segoe UI" });
           fontFamily3.Add(new FontFamily { text = "Arial" });
           fontFamily3.Add(new FontFamily { text = "Times New Roman" });
           fontFamily3.Add(new FontFamily { text = "Tahoma" });
           fontFamily3.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource =fontFamily3;
            fontPoint3.Add(new FontPoint { text = "1pt" });
            fontPoint3.Add(new FontPoint { text = "2pt" });
            fontPoint3.Add(new FontPoint { text = "3pt" });
            fontPoint3.Add(new FontPoint { text = "4pt" });
            fontPoint3.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontPoint3;
            return View();
        }

    }
}