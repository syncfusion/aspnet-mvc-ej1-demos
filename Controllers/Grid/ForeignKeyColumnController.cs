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
        // GET: /ForeignKeyColumn/

        public ActionResult ForeignKeyColumn()
        {
            var DataSource1 = new NorthwindDataContext().OrdersViews.ToList();
            ViewBag.dataSource1 = DataSource1;
            var DataSource2 = new NorthwindDataContext().EmployeeViews.ToList();
            ViewBag.dataSource2 = DataSource2;
            return View();
        }

    }
}
