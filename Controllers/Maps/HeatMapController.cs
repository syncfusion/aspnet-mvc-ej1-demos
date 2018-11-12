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
