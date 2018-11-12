using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /Adaptive/

        public ActionResult Adaptive()
        {
            return View();
        }

        public ActionResult AdaptiveSchedule()
        {
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.datasource = DataSource;
            return PartialView();
        }

    }
}
