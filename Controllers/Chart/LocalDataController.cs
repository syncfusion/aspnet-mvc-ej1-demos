#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
namespace MVCSampleBrowser.Controllers
{
    public partial class ChartController : Controller
    {
        //
        // GET: /LocalData/

        public ActionResult LocalData()
        {
            ViewBag.Series1 = ChartLocalData.GetSeries1Data();
            ViewBag.Series2 = ChartLocalData.GetSeries2Data();
            return View();
        }

    }
}
