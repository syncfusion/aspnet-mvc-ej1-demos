using MVCSampleBrowser.Models;
using Newtonsoft.Json;
using Syncfusion.EJ.Export;
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
        // GET: /Default/

        public ActionResult XLSExport()
        {
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

        public ActionResult ExportAsExcel()
        {
            List<AppointmentData> scheduleAppointments = (List<AppointmentData>)JsonConvert.DeserializeObject(Request.Form["ScheduleAppointment"], typeof(List<AppointmentData>));
            for (int a = 0, len = scheduleAppointments.Count; a < len; a++)
            {
                scheduleAppointments[a].StartTime = Convert.ToDateTime(scheduleAppointments[a].StartTime).ToString();
                scheduleAppointments[a].EndTime = Convert.ToDateTime(scheduleAppointments[a].EndTime).ToString();
            }
            ExcelExport xlExport = new ExcelExport();
            xlExport.Export(scheduleAppointments);
            return RedirectToAction("XLSExportController");
        }
    }

    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool? AllDay { get; set; }
        public bool? Recurrence { get; set; }
        public string RecurrenceRule { get; set; }
    }
}
