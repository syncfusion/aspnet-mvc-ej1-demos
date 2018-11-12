using MVCSampleBrowser.Models.LinearGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
        List<ScaleOrientation> OrientationType = new List<ScaleOrientation>();
        public ActionResult Scale()
        {
            OrientationType.Add(new ScaleOrientation { OrientationType = "clockwise" });
            OrientationType.Add(new ScaleOrientation { OrientationType = "counterclockwise" });
            ViewBag.datasource = OrientationType;
            return View();
        }

    }
}
