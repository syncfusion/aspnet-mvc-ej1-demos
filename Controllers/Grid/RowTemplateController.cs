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
        // GET: /RowTemplate/

        public ActionResult RowTemplate()
        {
            var DataSource = new NorthwindDataContext().EmployeeViews.ToList();
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
