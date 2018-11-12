using MVCSampleBrowser.Models.DigitalGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.DigitalGauge
{
    public partial class DigitalGaugeController : Controller
    {
        //
        // GET: /Default/
        List<Types> charactertype = new List<Types>();
        public ActionResult Default()
        {
            charactertype.Add(new Types { Type = "7 segment" });
            charactertype.Add(new Types { Type = "14 segment" });
            charactertype.Add(new Types { Type = "16 segment" });
            charactertype.Add(new Types { Type = "8x8 dotmatrix" });
            charactertype.Add(new Types { Type = "8x8 squarematrix" });
            ViewBag.datasource = charactertype;
            return View();
        }

    }
}
