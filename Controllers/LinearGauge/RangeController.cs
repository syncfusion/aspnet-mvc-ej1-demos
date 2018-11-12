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
        List<GaugeRange> GaugeRange = new List<GaugeRange>();
        public ActionResult Range()
        {
            placement.Add(new PoniterPlacement { Placement = "far" });
            placement.Add(new PoniterPlacement { Placement = "near" });
            placement.Add(new PoniterPlacement { Placement = "center" });
            ViewBag.datasource = placement;
            GaugeRange.Add(new MVCSampleBrowser.Models.LinearGauge.GaugeRange { RangesValue = "Range1" });
            GaugeRange.Add(new MVCSampleBrowser.Models.LinearGauge.GaugeRange { RangesValue = "Range2" });
            ViewBag.datasource3 = GaugeRange;
            return View();
        }

    }
}
