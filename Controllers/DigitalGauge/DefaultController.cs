#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models.DigitalGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.DigitalGauge
{
    public partial class DigitalGaugeController : Controller
    {
        //
        // GET: /Default/
        List<Types> charactertype = new List<Types>();
        public ActionResult Default()
        {
            charactertype.Add(new Types { Type = "7 segment" });
            charactertype.Add(new Types { Type = "14 segment" });
            charactertype.Add(new Types { Type = "16 segment" });
            charactertype.Add(new Types { Type = "8x8 dotmatrix" });
            charactertype.Add(new Types { Type = "8x8 squarematrix" });
            ViewBag.datasource = charactertype;
            return View();
        }

    }
}
