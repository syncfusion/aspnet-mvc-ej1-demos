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

namespace MVCSampleBrowser.Areas.WeatherAnalysis.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /WeatherAnalysis/Home/

        public ActionResult Index()
        {
            var DataSource = new WeatherData().GetWeatherData;
            ViewBag.datasource = DataSource;

            var AverageWeatherData = new WeatherData().AverageWeatherData;
            ViewBag.datasource1 = AverageWeatherData;

            return View();
        }

    }
}
