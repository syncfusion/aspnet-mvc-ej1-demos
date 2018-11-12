using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /Events/

        public ActionResult Events()
        {
            var DataSource = new NorthwindDataContext().OrdersViews.Take(30).ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
