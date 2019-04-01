#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using Syncfusion.JavaScript.Models;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.ReportViewerEnums;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportViewerController : Controller
    {
        //
        // GET: /ProductList/

        public ActionResult SalesPerYear()
        {

            var datasources = new List<Syncfusion.JavaScript.Models.ReportViewer.ReportDataSource>();
            datasources.Add(new Syncfusion.JavaScript.Models.ReportViewer.ReportDataSource("Sales", new CompanySales().GetData()));
            ViewData["viewer"] = datasources;
            return View();
        }

    }
}
