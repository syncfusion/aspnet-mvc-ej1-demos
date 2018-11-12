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
        // GET: /Range/
        List<Ranges> range = new List<Ranges>();
        public ActionResult Range()
        {
            range.Add(new Ranges { Range = "Range1" });
            range.Add(new Ranges { Range = "Range2" });
            range.Add(new Ranges { Range = "Range3" });
            ViewBag.datasource = range;
            return View();
        }

    }
}
