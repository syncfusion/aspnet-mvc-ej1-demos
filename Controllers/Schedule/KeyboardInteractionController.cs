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
        // GET: /KeyboardInteraction/

        public ActionResult KeyboardInteraction()
        {
            var DataSource = new ScheduleDataDataContext().KeyboardInteractions.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
