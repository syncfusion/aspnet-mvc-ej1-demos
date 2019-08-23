#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
    public partial class DropdownlistController : Controller
    {
        public ActionResult DropdownlistFor()
        {
            DropDownListProperties ddl = new DropDownListProperties();
            ddl.DataSource = GetDataSource();
            DropDownListFields ddf = new DropDownListFields();
            ddf.Text = "text";
            ddf.Id = "uniqueKey";
            ddl.DropDownListFields = ddf;

            ViewData["ddl"] = ddl;

            return View();
        }

        [HttpPost]
        public ActionResult DropdownlistFor(DDL model)
        {
            DropDownListProperties ddl = new DropDownListProperties();
            ddl.DataSource = GetDataSource();
            DropDownListFields ddf = new DropDownListFields();
            ddf.Text = "text";
            ddf.Id = "uniqueKey";
            ddl.DropDownListFields = ddf;

            ViewData["ddl"] = ddl;

            return View(model);
        }
        public List<CarsList> GetDataSource()
        {
            List<CarsList> cars = new List<CarsList>();
            cars.Add(new CarsList { uniqueKey = 1, text = "Audi S6", company = "Audi" });
            cars.Add(new CarsList { uniqueKey = 2, text = "Austin-žHealey", company = "Austin" });
            cars.Add(new CarsList { uniqueKey = 3, text = "BMW š7", company = "BMW" });
            cars.Add(new CarsList { uniqueKey = 4, text = "Chevrolet Camarož", company = "Chevrolet" });
            cars.Add(new CarsList { uniqueKey = 6, text = "Ferrari š360", company = "Ferrari" });
            cars.Add(new CarsList { uniqueKey = 7, text = "Honda S2000", company = "Honda" });
            cars.Add(new CarsList { uniqueKey = 8, text = "Hyundai Santroš", company = "Hyundai" });
            cars.Add(new CarsList { uniqueKey = 9, text = "Isuzu Swift", company = "Isuzu" });
            cars.Add(new CarsList { uniqueKey = 10, text = "Jaguar XJS", company = "Jaguar" });
            cars.Add(new CarsList { uniqueKey = 11, text = "iLotus Esprit", company = "Lotus" });
            cars.Add(new CarsList { uniqueKey = 12, text = "Mercedes-Benz", company = "Mercedes" });
            cars.Add(new CarsList { uniqueKey = 13, text = "Toyota ž2000GT", company = "Toyota" });
            cars.Add(new CarsList { uniqueKey = 14, text = "Volvo P1800", company = "Volvo" });
            return cars;
        }

    }
}
