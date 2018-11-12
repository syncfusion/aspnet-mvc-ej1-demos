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
        // GET: /Default/

        public ActionResult HorizontalDefault()
        {
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.datasource = DataSource;
            return View();
        }
    }
}
