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

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttWorkWeek/

        public ActionResult GanttWorkWeek()
        {
            var DataSource = GanttDefaultData.GetData();
            ViewBag.datasource = DataSource;
            //ViewBag.dropDownData = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return View();
        }

    }
}
