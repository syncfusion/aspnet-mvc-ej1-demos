#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript.Models;
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
        // GET: /CustomDates/

        public ActionResult CustomDates()
        {
            List<Object> renderDates = new List<Object>() {
                new ScheduleRenderDates { Start = "2/6/2015", End = "2/10/2015" },
                new ScheduleRenderDates { Start = "7/11/2016", End = "7/20/2016" },
                new ScheduleRenderDates { Start = "11/26/2017", End = "11/30/2017" }
            };
            List<AppointmentFields> appointments = new List<AppointmentFields>()
            {
                new AppointmentFields { Id = 1, Subject = "Ladies Mogals Qualification", StartTime = new DateTime(2015, 2, 6, 10, 0, 0), EndTime = new DateTime(2015, 2, 6, 12, 30, 0), Description = "", AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=5" },
                new AppointmentFields { Id = 2, Subject = "Men's Mogals Qualification", StartTime = new DateTime(2016, 7, 15, 14, 0, 0), EndTime = new DateTime(2016, 7, 15, 16, 0, 0), Description = "", AllDay = false, Recurrence = false },
                new AppointmentFields { Id = 3, Subject = "Men's 500m race", StartTime = new DateTime(2016, 7, 13, 17, 0, 0), EndTime = new DateTime(2016, 7, 13, 18, 0, 0), Description = "", AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5" },
                new AppointmentFields { Id = 4, Subject = "Opening ceremony", StartTime = new DateTime(2017, 11, 27, 09, 0, 0), EndTime = new DateTime(2017, 11, 27, 12, 0, 0), Description = "", AllDay = false, Recurrence = false },
                new AppointmentFields { Id = 5, Subject = "Finals", StartTime = new DateTime(2017, 11, 28, 10, 0, 0), EndTime = new DateTime(2017, 11, 29, 17, 30, 0), Description = "", AllDay = false, Recurrence = false }
            };

            ViewBag.customDates = renderDates;
            ViewBag.dataSource = appointments;
            return View();
        }
    }

    public class AppointmentFields
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public bool AllDay { get; set; }
        public bool Recurrence { get; set; }
        public string RecurrenceRule { get; set; }
    }
}
