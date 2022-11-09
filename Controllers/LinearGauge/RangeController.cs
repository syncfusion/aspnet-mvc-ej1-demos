#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models.LinearGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
        List<GaugeRange> GaugeRange = new List<GaugeRange>();
        public ActionResult Range()
        {
            placement.Add(new PoniterPlacement { Placement = "far" });
            placement.Add(new PoniterPlacement { Placement = "near" });
            placement.Add(new PoniterPlacement { Placement = "center" });
            ViewBag.datasource = placement;
            GaugeRange.Add(new MVCSampleBrowser.Models.LinearGauge.GaugeRange { RangesValue = "Range1" });
            GaugeRange.Add(new MVCSampleBrowser.Models.LinearGauge.GaugeRange { RangesValue = "Range2" });
            ViewBag.datasource3 = GaugeRange;
            return View();
        }

    }
}
