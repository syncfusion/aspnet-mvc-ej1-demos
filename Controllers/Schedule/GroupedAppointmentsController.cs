#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        //
        // GET: /MultipleResource/
        List<Rooms> groupOwners = new List<Rooms>();
        List<ScheduleAppointmentsData> appoint = new List<ScheduleAppointmentsData>();
        public ActionResult GroupedAppointments()
        {
            //var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            //ViewBag.datasource = DataSource;
            appoint.Add(new ScheduleAppointmentsData
            {
                Id = 100,
                Subject = "Bering Sea Gold",
                StartTime = new DateTime(2017, 05, 02, 09, 00, 00),
                EndTime = new DateTime(2017, 05, 02, 10, 30, 00),
                Description = "",
                AllDay = false,
                Recurrence = true,
                RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10",
                OwnerId = "3,1,5"
            });
            appoint.Add(new ScheduleAppointmentsData
            {
                Id = 101,
                Subject = "Hello Sea Gold",
                StartTime = new DateTime(2017, 5, 2, 4, 00, 00),
                EndTime = new DateTime(2017, 5, 2, 5, 00, 00),
                Description = "",
                AllDay = false,
                Recurrence = false,
                OwnerId = "3,5"
            });
            ViewBag.datasource = appoint;

            groupOwners.Add(new Rooms { text = "Nancy", id = "1", color = "#f8a398" });
            groupOwners.Add(new Rooms { text = "Steven", id = "3", color = "#56ca85" });
            groupOwners.Add(new Rooms { text = "Michael", id = "5", color = "#51a0ed" });
            ViewBag.Owners = groupOwners;

            List<String> resources = new List<String>();
            resources.Add("Owners");
            ViewBag.Resources = resources;

            return View();
        }

    }
}
