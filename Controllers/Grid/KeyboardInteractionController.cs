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
        // GET: /KeyboardInteraction/

        public ActionResult KeyboardInteraction()
        {
            var DataSource = new NorthwindDataContext().OrdersViews.Take(300).ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
