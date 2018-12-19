#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript.DataVisualization.Maps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class MapsController : Controller
    {
        //
        // GET: /FlightRoutes/

        public ActionResult FlightRoutes()
        {
            ViewData["mapdata"] = this.GetWorldMap();
            ViewData["flightRoutes"]= GetFlightRoute();
            ViewData["airports"] = GetAirports();
            ViewData["intermediatestops1"] = GetAirportStops1();
            ViewData["intermediatestops2"] = GetAirportStops2();
            ViewData["flightRoutes_data"] = World_FlightData.GetFlightRoutes_Data();
            ViewData["airports_data"] = World_FlightData.GetAirportData();
            ViewData["intermediatestops1_data"] = World_FlightData.GetIntermediateStops1_Data();
            ViewData["intermediatestops2_data"] = World_FlightData.GetIntermediateStops2_Data();
            return View();
        }

        public object GetAirports()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/airports.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

        public object GetAirportStops1()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/airportstops1.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

        public object GetAirportStops2()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/airportstops2.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

         public object GetFlightRoute()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/flightRoutes.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

          
    }
   
}
