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
    public partial class AutocompleteController : Controller
    {
        public ActionResult AutocompleteFor()
        {
            AutocompleteProperties auto = new AutocompleteProperties();
            auto.DataSource = CarsList.GetCarList();
            auto.FilterType = FilterOperatorType.Contains;
            ViewData["auto"] = auto;
            return View(new Autocmplete());
        }
        [HttpPost]
        public ActionResult AutocompleteFor(Autocmplete model)
        {
            AutocompleteProperties auto = new AutocompleteProperties();
            auto.DataSource = CarsList.GetCarList();
            auto.FilterType = FilterOperatorType.Contains;
            ViewData["auto"] = auto;
            return View(model);
        }
    }
}
