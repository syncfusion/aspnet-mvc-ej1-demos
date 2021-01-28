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
using Syncfusion.EJ.Export;
using Syncfusion.Pdf;
using System.Collections;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /PDFExport/

        public ActionResult PDFExport()
        {
            ViewBag.datasource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.blockDataSource = new ScheduleBlockTime().GetBlockData();

            rooms.Add(new Rooms { text = "ROOM1", id = "1", color = "#cb6bb2" });
            rooms.Add(new Rooms { text = "ROOM2", id = "2", color = "#56ca85" });
            ViewBag.Rooms = rooms;

            owner.Add(new Rooms { text = "Nancy", id = "1", groupId = "1", color = "#ffaa00" });
            owner.Add(new Rooms { text = "Steven", id = "3", groupId = "2", color = "#f8a398" });
            owner.Add(new Rooms { text = "Michael", id = "5", groupId = "1", color = "#7499e1" });
            ViewBag.Owners = owner;

            List<String> resources = new List<String>();
            resources.Add("Rooms"); 
            resources.Add("Owners");
            ViewBag.Resources = resources;

            return View();
        }
        public ActionResult ExportAsPDF(string scheduleModel)
        {
            ScheduleProperties scheduleObject = new SchedulePDFExport().ScheduleSerializeModel(Request.Form["ScheduleModel"]);
			scheduleObject.BlockoutSettings.DataSource = (IEnumerable)new JavaScriptSerializer().Deserialize(Request.Form["ScheduleProcesedIntervalsApps"], typeof(IEnumerable));
            IEnumerable scheduleAppointments = (IEnumerable)new JavaScriptSerializer().Deserialize(Request.Form["ScheduleProcesedApps"], typeof(IEnumerable));
			PdfPageSettings pageSettings = new PdfPageSettings(50f) { Orientation = PdfPageOrientation.Landscape };
            PdfDocument document = new PdfExport().Export(scheduleObject, scheduleAppointments, ExportTheme.FlatSaffron, Request.Form["locale"], pageSettings);
            document.Save("Schedule.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            return RedirectToAction("PDFExportController");
        }
    }
}
