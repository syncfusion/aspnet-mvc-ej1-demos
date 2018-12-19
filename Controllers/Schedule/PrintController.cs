#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /Print/

        public ActionResult Print()
        {
            List<Appointment> appointment = new List<Appointment>();
            appointment.Add(new Appointment() { Id = "open", Text = "Open Appointment" });
            appointment.Add(new Appointment() { Id = "delete", Text = "Delete Appointment" });
            appointment.Add(new Appointment() { Id = "print", Text = "Print Appointment" });
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.dataSource = DataSource;
            ViewBag.app = appointment;
            return View();
        }

    }
}
