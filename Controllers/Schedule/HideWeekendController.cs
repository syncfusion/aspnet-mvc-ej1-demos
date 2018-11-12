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
        // GET: /HideWeekend/

        public ActionResult HideWeekend()
        {
            ViewBag.dataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            return View();
        }

    }
}
