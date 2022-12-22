#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MVCSampleBrowser.Areas.OutlookAnalysis.Models;

namespace MVCSampleBrowser.Areas.OutlookAnalysis.Controllers
{
    public class OutlookController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.dataSource = OutlookData.GetContactList();
            return View();
        }      
    }
}