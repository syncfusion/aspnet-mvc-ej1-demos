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
        // GET: /Resonsive/

        public ActionResult Responsive()
        {
            return View();
        }

        public ActionResult ResponsiveGrid()
        {
            var DataSource = new NorthwindDataContext().OrdersViews.Take(200).ToList();
            ViewBag.datasource = DataSource;
            return PartialView();
        }

    }
}
