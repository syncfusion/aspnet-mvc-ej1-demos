#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Models;
using System.Globalization;
using Syncfusion.JavaScript;
using MVCSampleBrowser.Models;


namespace MVCSampleBrowser.Controllers
{

    public partial class DateRangePickerController : Controller
    {

        public ActionResult DateRangePickerfor()
        {
            DateRangePickerProperties datemodel = new DateRangePickerProperties();

            datemodel.DateFormat = "MM/dd/yyyy";
            ViewData["date"] = datemodel;
            return View(new daterangepicker());

        }
        [HttpPost]
        public ActionResult DateRangePickerFor(daterangepicker model)
        {
            DateRangePickerProperties datemodel = new DateRangePickerProperties();
            datemodel.DateFormat = "MM/dd/yyyy";
            ViewData["date"] = datemodel;
            return View(model);
        }

    }

}
