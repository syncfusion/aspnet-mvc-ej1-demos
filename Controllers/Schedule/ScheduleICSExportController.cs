#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
using Newtonsoft.Json;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /ScheduleICSExport/
        ScheduleDataDataContext db = new ScheduleDataDataContext();
        public ActionResult ScheduleICSExport()
        {
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.dataSource = DataSource;

            //
            List<Appointment> appointment = new List<Appointment>();
            appointment.Add(new Appointment() { Id = "open", Text = "Open Appointment" });
            appointment.Add(new Appointment() { Id = "delete", Text = "Delete Appointment" });
            appointment.Add(new Appointment() { Id = "exportApp", Text = "Export Appointment" });

            List<Cells> cells = new List<Cells>();
            cells.Add(new Cells() { Id = "new", Text = "New Appointment" });
            cells.Add(new Cells() { Id = "recurrence", Text = "New Recurring Appointment" });
            cells.Add(new Cells() { Id = "settings", Text = "Settings" });
            cells.Add(new Cells() { Id = "view", Text = "View", ParentId = "settings" });
            cells.Add(new Cells() { Id = "timemode", Text = "TimeMode", ParentId = "settings" });
            cells.Add(new Cells() { Id = "view_Day", Text = "Day", ParentId = "view" });
            cells.Add(new Cells() { Id = "view_Week", Text = "Week", ParentId = "view" });
            cells.Add(new Cells() { Id = "view_Workweek", Text = "Workweek", ParentId = "view" });
            cells.Add(new Cells() { Id = "view_Month", Text = "Month", ParentId = "view" });
            cells.Add(new Cells() { Id = "timemode_Hour12", Text = "12 Hours", ParentId = "timemode" });
            cells.Add(new Cells() { Id = "timemode_Hour24", Text = "24 Hours", ParentId = "timemode" });
            ViewBag.app = appointment;
            ViewBag.cell = cells;
            

            return View();
        }
        public JsonResult GetData()
        {
            IEnumerable data = db.DefaultSchedules.Take(5);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public void ExportToICS(FormCollection form)
        {
            IEnumerable data;
            string JSONModel = Request.Form["ScheduleApps"];
            var model = JsonConvert.DeserializeObject<Dictionary<string, object>>(JSONModel);
            var Id = Request.Form["AppointmentId"];
            if(Id != null)
                data = db.DefaultSchedules.Where(app => app.Id.ToString() == Id.ToString()).ToList();
            else
                data = db.DefaultSchedules.Take(5).ToList();
            ScheduleExport obj = new ScheduleExport(model, data);
        }
        public ActionResult ScheduleImportData()
        {
            IEnumerable DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            var data = DataSource;
            if (TempData["dataSource"] != null)
                data = (IEnumerable)TempData["dataSource"];
            else
                data = DataSource;
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SaveDefault(IEnumerable<HttpPostedFileBase> UploadDefault)
        {
            var destinationPath = "";
            foreach (var file in UploadDefault)
            {
                var fileName = Path.GetFileName(file.FileName);
                destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                file.SaveAs(destinationPath);

            }
            ScheduleImport importApps = new ScheduleImport();
            var app = importApps.renderingImportAppointments(destinationPath);
            var dataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            int intMax = dataSource.Max(a => a.Id);
            for (var i = 0; i < app.Count; i++)
            {
                app[i].Id = intMax + 1;
                DefaultSchedule row = new DefaultSchedule(app[i].Id, app[i].Subject, app[i].Location, app[i].StartTime, app[i].EndTime, app[i].Description, null, null, app[i].Recurrence, null, null, app[i].AppointmentCategorize, null, app[i].AllDay, null, null, app[i].RecurrenceRules);
                dataSource.Add(row);
                intMax = app[i].Id;
            }
            ViewBag.dataSource = dataSource;
            TempData["dataSource"] = dataSource;
            return RedirectToAction("ScheduleImport", "ScheduleImport");
        }

        public ActionResult RemoveDefault(string[] fileNames)
        {
            foreach (var fullName in fileNames)
            {
                var fileName = Path.GetFileName(fullName);
                var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                if (System.IO.File.Exists(physicalPath))
                {
                    System.IO.File.Delete(physicalPath);
                }
            }
            return Content("");
        }

    }
}
