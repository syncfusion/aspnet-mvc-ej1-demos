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
using Syncfusion.JavaScript.Models;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /Default/
        
        public ActionResult CategorizeOption()
        {
            List<Appointment> appointment = new List<Appointment>();
            appointment.Add(new Appointment() { Id = "open", Text = "Open Appointment" });
            appointment.Add(new Appointment() { Id = "delete", Text = "Delete Appointment" });
            appointment.Add(new Appointment() { Id = "custommenu3", Text = "Custom Menu3" });
            appointment.Add(new Appointment() { Id = "custommenu4", Text = "Custom Menu4" });
            appointment.Add(new Appointment() { Id = "categorize", Text = "Categorize" });
            List<Cells> cells = new List<Cells>();
            cells.Add(new Cells() { Id = "new", Text = "New Appointment" });
            cells.Add(new Cells() { Id = "recurrence", Text = "New Recurring Appointment" });
            cells.Add(new Cells() { Id = "today", Text = "Today" });
            cells.Add(new Cells() { Id = "gotodate", Text = "Go to date" });
            cells.Add(new Cells() { Id = "settings", Text = "Settings" });
            cells.Add(new Cells() { Id = "view", Text = "View", ParentId = "settings" });
            cells.Add(new Cells() { Id = "timemode", Text = "TimeMode", ParentId = "settings" });
            cells.Add(new Cells() { Id = "view_Day", Text = "Day", ParentId = "view" });
            cells.Add(new Cells() { Id = "view_Week", Text = "Week", ParentId = "view" });
            cells.Add(new Cells() { Id = "view_Workweek", Text = "Workweek", ParentId = "view" });
            cells.Add(new Cells() { Id = "view_Month", Text = "Month", ParentId = "view" });
            cells.Add(new Cells() { Id = "timemode_Hour12", Text = "12 Hours", ParentId = "timemode" });
            cells.Add(new Cells() { Id = "timemode_Hour24", Text = "24 Hours", ParentId = "timemode" });
            cells.Add(new Cells() { Id = "workhours", Text = "Work Hours", ParentId = "settings" });
            cells.Add(new Cells() { Id = "custommenu1", Text = "Custom Menu1" });
            cells.Add(new Cells() { Id = "custommenu2", Text = "Custom Menu2" });
            List<Categorize> CategorizeValue = new List<Categorize>();
            CategorizeValue.Add(new Categorize { text = "Blue Category", id = 1, color = "#43b496", fontColor = "#ffffff" });
            CategorizeValue.Add(new Categorize { text = "Green Category", id = 2,  color ="#7f993e", fontColor= "#ffffff"});
            CategorizeValue.Add(new Categorize { text = "Orange Category", id = 3, color ="#cc8638", fontColor= "#ffffff"});
            CategorizeValue.Add(new Categorize { text = "Purple Category", id = 4, color ="#ab54a0", fontColor= "#ffffff"});
            CategorizeValue.Add(new Categorize { text = "Red Category", id = 5,    color ="#dd654e", fontColor= "#ffffff"});
            CategorizeValue.Add(new Categorize { text = "Yellow Category", id = 6, color ="#d0af2b", fontColor= "#ffffff"});
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.dataSource = DataSource;
            ViewBag.app = appointment;
            ViewBag.cell = cells;
            ViewBag.categorize = CategorizeValue;
            return View();
        }
        public class Categorize
        {
            public string text { set; get; }
            public int id { set; get; }
            public string fontColor { set; get; }
            public string color { set; get; }
        }
    }
}
