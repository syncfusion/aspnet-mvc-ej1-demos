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
