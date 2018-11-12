using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /Adaptive/

        public ActionResult Adaptive()
        {
            return View();
        }

        public ActionResult AdaptiveGrid()
        {
            var DataSource = new NorthwindDataContext().OrdersViews.Take(200).ToList();
            ViewBag.datasource = DataSource;
            return PartialView();
        }

    }
}
