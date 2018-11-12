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
        // GET: /RTL/

        public ActionResult RTL()
        {
            var DataSource = new ScheduleDataDataContext().RTLs.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
