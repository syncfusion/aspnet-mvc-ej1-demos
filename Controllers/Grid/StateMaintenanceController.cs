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
        // GET: /StateMaintenance/

        public ActionResult StateMaintenance()
        {
            var DataSource = new NorthwindDataContext().OrdersViews.ToList();
            ViewBag.dataSource1 = DataSource;
            return View();
        }

    }
}
