using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
namespace MVCSampleBrowser.Controllers
{
    public partial class ChartController : Controller
    {
        //
        // GET: /LocalData/

        public ActionResult LocalData()
        {
            ViewBag.Series1 = ChartLocalData.GetSeries1Data();
            ViewBag.Series2 = ChartLocalData.GetSeries2Data();
            return View();
        }

    }
}
