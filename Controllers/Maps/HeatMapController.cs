#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript.DataVisualization.Maps;
using Syncfusion.JavaScript.DataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class MapsController : Controller
    {
        //
        // GET: /GradientColors/

        public ActionResult HeatMap()
        {
            ViewData["datasource"] = Election_Result.GetUSPopulationData();
            ViewData["mapdata"] = this.GetUSA();
            return View();
        }
        

    }
}
