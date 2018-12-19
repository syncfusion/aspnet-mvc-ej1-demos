#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        //
        // GET: /Pointer/
        List<NeedleStyle> needleStyle = new List<NeedleStyle>();
        public ActionResult Pointer()
        {
            needleStyle.Add(new NeedleStyle { Style = "triangle" });
            needleStyle.Add(new NeedleStyle { Style = "trapezoid" });
            needleStyle.Add(new NeedleStyle { Style = "arrow" });
            needleStyle.Add(new NeedleStyle { Style = "rectangle" });
            ViewBag.datasource = needleStyle;
            return View();
        }

    }
}
