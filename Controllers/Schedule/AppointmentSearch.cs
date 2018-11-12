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
        // GET: /API/

        public ActionResult AppointmentSearch()
        {
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            string[] startHour = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
            ViewBag.dataSource = DataSource;
            ViewBag.Hour = startHour;
            return View();
        }

    }
}
