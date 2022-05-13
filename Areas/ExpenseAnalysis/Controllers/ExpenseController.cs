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
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Areas.ExpenseAnalysis.Controllers
{
    public class ExpenseController : Controller
    {

        public ActionResult Index()
        {
            List<string> ls = new List<string>();
            ls.Add("All");
            ls.Add("January");
            ls.Add("February");
            ls.Add("March");
            ls.Add("April");
            ls.Add("May");
            ls.Add("June");
            ls.Add("July");
            ls.Add("August");
            ls.Add("September");
            ls.Add("October");
            ls.Add("November");
            ls.Add("December");
            ViewBag.dropdown = ls;
            return View();
        }

       
       
    }
}