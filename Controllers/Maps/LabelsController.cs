using Syncfusion.JavaScript.DataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class MapsController : Controller
    {
        //
        // GET: /Labels/

        public ActionResult Labels()
        {
            ViewData["datasource"] = Election_Result.GetUSPopulationData();
            ViewData["mapdata"] = this.GetUSA();

            return View();
        }

    }
}
