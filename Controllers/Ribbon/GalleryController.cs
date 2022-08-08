#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
       
        List<FontFamily> fontFamily4 = new List<FontFamily>();
        List<FontPoint> fontPoint4 = new List<FontPoint>();
        public ActionResult Gallery()
        {
           fontFamily4.Add(new FontFamily { text = "Segoe UI" });
           fontFamily4.Add(new FontFamily { text = "Arial" });
           fontFamily4.Add(new FontFamily { text = "Times New Roman" });
           fontFamily4.Add(new FontFamily { text = "Tahoma" });
           fontFamily4.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource =fontFamily4;
          fontPoint4.Add(new FontPoint { text = "1pt" });
          fontPoint4.Add(new FontPoint { text = "2pt" });
          fontPoint4.Add(new FontPoint { text = "3pt" });
          fontPoint4.Add(new FontPoint { text = "4pt" });
          fontPoint4.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontPoint4;
           
            return View();
        }

    }
}
