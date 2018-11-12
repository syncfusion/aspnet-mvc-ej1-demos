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
        // GET: Celltemplate
        public ActionResult Celltemplate()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.Take(10);
            ViewBag.datasource = DataSource;
            return View();
        }
    }
}