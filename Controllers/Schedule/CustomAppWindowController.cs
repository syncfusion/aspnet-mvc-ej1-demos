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
        // GET: /CustomAppWindow/

        public ActionResult CustomAppWindow()
        {
            var DataSource = new ScheduleDataDataContext().StartEndHours.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
