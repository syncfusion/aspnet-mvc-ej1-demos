#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
        // GET: /Resize/
        List<FontFamily> fontFamily6 = new List<FontFamily>();
        List<FontPoint> fontPoint6 = new List<FontPoint>();
        public ActionResult Resize()
        {
              fontFamily6.Add(new FontFamily { text = "Segoe UI" });
              fontFamily6.Add(new FontFamily { text = "Arial" });
              fontFamily6.Add(new FontFamily { text = "Times New Roman" });
              fontFamily6.Add(new FontFamily { text = "Tahoma" });
              fontFamily6.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource =   fontFamily6;
           fontPoint6.Add(new FontPoint { text = "1pt" });
           fontPoint6.Add(new FontPoint { text = "2pt" });
           fontPoint6.Add(new FontPoint { text = "3pt" });
           fontPoint6.Add(new FontPoint { text = "4pt" });
           fontPoint6.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 =fontPoint6;
            return View();
        }

    }
}
