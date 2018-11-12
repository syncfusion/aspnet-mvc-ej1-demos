using MVCSampleBrowser.Models.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        //
        // GET: /Scale/
        List<Directions> scaleDirection = new List<Directions>();
        public ActionResult Scale()
        {
            scaleDirection.Add(new Directions { Direction = "clockwise" });
            scaleDirection.Add(new Directions { Direction = "counterclockwise" });
            ViewBag.datasource = scaleDirection;
            return View();
        }

    }
}
