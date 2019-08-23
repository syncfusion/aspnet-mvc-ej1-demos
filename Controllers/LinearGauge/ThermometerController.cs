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
        List<TempType> temp = new List<TempType>();
        public ActionResult Thermometer()
        {
            temp.Add(new TempType { Temp = "Boiling Point" });
            temp.Add(new TempType { Temp = "Hot Bath" });
            temp.Add(new TempType { Temp = "Body Temp" });
            temp.Add(new TempType { Temp = "Beach Weather" });
            temp.Add(new TempType { Temp = "Cool Day" });
            temp.Add(new TempType { Temp = "Freezing Point" });
            temp.Add(new TempType { Temp = "Extreme Cold" });
            ViewBag.datasource4 = temp;
            return View();
        }

    }
}
