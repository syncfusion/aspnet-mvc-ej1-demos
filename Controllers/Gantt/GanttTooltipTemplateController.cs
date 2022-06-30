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
using MVCSampleBrowser.Models;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttTooltipTemplate/

        public ActionResult GanttTooltipTemplate()
        {
            var DataSource = GetTaskData();
            ViewBag.datasource = DataSource;
            var DataSource1 = ResourceDataContext.GetResourceData();
            ViewBag.datasource1 = DataSource1;
            return View();
        }
    }
}
