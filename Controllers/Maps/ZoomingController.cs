using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class MapsController : Controller
    {
        public ActionResult Zooming()
        {
            ViewData["mapdata"] = this.GetWroldMap();
            ViewData["latLongPoints"] = Country_LatLongPoints.GetCountryLatLongPoints();
            return View();
        }
    }
}
