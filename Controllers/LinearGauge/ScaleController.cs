#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        List<ScaleOrientation> OrientationType = new List<ScaleOrientation>();
        public ActionResult Scale()
        {
            OrientationType.Add(new ScaleOrientation { OrientationType = "clockwise" });
            OrientationType.Add(new ScaleOrientation { OrientationType = "counterclockwise" });
            ViewBag.datasource = OrientationType;
            return View();
        }

    }
}
