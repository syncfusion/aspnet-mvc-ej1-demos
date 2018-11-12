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
        // GET: /CustomViews/

        public ActionResult CustomViews()
        {
            var DataSource = new ScheduleDataDataContext().Viewcustomizations.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
