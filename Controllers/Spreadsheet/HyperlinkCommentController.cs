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
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /HyperlinkComment/

        public ActionResult HyperlinkComment()
        {
            var dataSource = HyperlinkData.GetHyperlinkDetails.ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
