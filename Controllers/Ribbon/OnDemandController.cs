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
        //
        // GET: /OnDemand/
        List<FontFamily> fontFamilyOnDemand = new List<FontFamily>();
        List<FontPoint> fontOnDemand = new List<FontPoint>();
        public ActionResult OnDemand()
        {
            fontFamilyOnDemand.Add(new FontFamily { text = "Segoe UI" });
            fontFamilyOnDemand.Add(new FontFamily { text = "Arial" });
            fontFamilyOnDemand.Add(new FontFamily { text = "Times New Roman" });
            fontFamilyOnDemand.Add(new FontFamily { text = "Tahoma" });
            fontFamilyOnDemand.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource = fontFamilyOnDemand;
            fontOnDemand.Add(new FontPoint { text = "1pt" });
            fontOnDemand.Add(new FontPoint { text = "2pt" });
            fontOnDemand.Add(new FontPoint { text = "3pt" });
            fontOnDemand.Add(new FontPoint { text = "4pt" });
            fontOnDemand.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontOnDemand;
            return View();
        }

    }
}
