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
        // GET: /BackStage/
        List<FontFamily> fontFamilyBack = new List<FontFamily>();
        List<FontPoint> fontPointBack = new List<FontPoint>();
        public ActionResult BackStage()
        {
            fontFamilyBack.Add(new FontFamily { text = "Segoe UI" });
            fontFamilyBack.Add(new FontFamily { text = "Arial" });
            fontFamilyBack.Add(new FontFamily { text = "Times New Roman" });
            fontFamilyBack.Add(new FontFamily { text = "Tahoma" });
            fontFamilyBack.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource = fontFamilyBack;
            fontPointBack.Add(new FontPoint { text = "1pt" });
            fontPointBack.Add(new FontPoint { text = "2pt" });
            fontPointBack.Add(new FontPoint { text = "3pt" });
            fontPointBack.Add(new FontPoint { text = "4pt" });
            fontPointBack.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontPointBack;
            return View();
        }

    }
}
