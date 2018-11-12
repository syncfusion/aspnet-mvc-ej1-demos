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
        // GET: /MasterDetails/

        public ActionResult MasterDetails()
        {
            var MasterData = new NorthwindDataContext().EmployeeViews.Take(5).ToList();
            ViewBag.dataSource1 = MasterData;

            var DetailData = new NorthwindDataContext().OrdersViews.Where(ord => ord.EmployeeID == 1).Take(5).ToList();
            ViewBag.dataSource2 = DetailData;
            return View();
        }

    }
}
