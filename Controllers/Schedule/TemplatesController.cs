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
        // GET: /Templates/

        public ActionResult Templates()
        {
            var DataSource = new ScheduleDataDataContext().Templates.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
