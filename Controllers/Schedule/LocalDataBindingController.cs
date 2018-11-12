using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /LocalDataBinding/

        public ActionResult LocalDataBinding()
        {
            var DataSource = new ScheduleDataDataContext().TimeModes.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
