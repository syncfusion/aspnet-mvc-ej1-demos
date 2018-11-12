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
        // GET: /Localization/

        public ActionResult Localization()
        {
            var DataSource = new ScheduleDataDataContext().Localizations.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
