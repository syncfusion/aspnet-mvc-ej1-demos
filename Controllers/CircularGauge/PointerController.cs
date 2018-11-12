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
        // GET: /Pointer/
        List<NeedleStyle> needleStyle = new List<NeedleStyle>();
        public ActionResult Pointer()
        {
            needleStyle.Add(new NeedleStyle { Style = "triangle" });
            needleStyle.Add(new NeedleStyle { Style = "trapezoid" });
            needleStyle.Add(new NeedleStyle { Style = "arrow" });
            needleStyle.Add(new NeedleStyle { Style = "rectangle" });
            ViewBag.datasource = needleStyle;
            return View();
        }

    }
}
