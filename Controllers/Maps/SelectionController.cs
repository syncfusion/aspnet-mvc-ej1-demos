#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        // GET: /Selection/

        public ActionResult Selection()
        {
            ViewData["datasource"] = Election_Result.GetElectionResults();
            ViewData["mapdata"] = this.GetUSA();

            return View();
        }

        public object GetUSA()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

    }
}
