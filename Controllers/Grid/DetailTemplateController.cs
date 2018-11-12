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
        // GET: /DetailTemplate/

        public ActionResult DetailTemplate()
        {
            var DataSource = new NorthwindDataContext().EmployeeViews.Take(9).ToList();
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
