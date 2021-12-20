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
        // GET: /CustomResourceDays/

        List<ResRoom> Rooms1 = new List<ResRoom>();
        List<ResOwner> Owners1 = new List<ResOwner>();

        public ActionResult CustomResourceDays()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.datasource = DataSource;

            Rooms1.Add(new ResRoom { text = "ROOM 1", id = "1", color = "#cb6bb2", groupId = "1" });
            Rooms1.Add(new ResRoom { text = "ROOM 2", id = "2", color = "#56ca85", groupId = "1" });
            ViewBag.Rooms = Rooms1;

            Owners1.Add(new ResOwner { text = "Nancy", id = "1", groupId = "1", color = "#ffaa00", on = "10", off = "18", customDays = new List<string> { "monday", "wednesday", "friday" } });
            Owners1.Add(new ResOwner { text = "Steven", id = "3", groupId = "2", color = "#f8a398", on = "6", off = "10", customDays = new List<string> { "tuesday", "thursday" } });
            Owners1.Add(new ResOwner { text = "Michael", id = "5", groupId = "1", color = "#7499e1", on = "11", off = "15", customDays = new List<string> { "sunday", "tuesday", "thursday", "saturday" } });
            ViewBag.Owners = Owners1;

            List<String> Resources1 = new List<String>();
            Resources1.Add("Rooms");
            Resources1.Add("Owners");
            ViewBag.Resources = Resources1;

            return View();
        }

        public class ResRoom
        {
            public string text { set; get; }
            public string id { set; get; }
            public string groupId { set; get; }
            public string color { set; get; }
        }

        public class ResOwner
        {
            public string text { set; get; }
            public string id { set; get; }
            public string groupId { set; get; }
            public string color { set; get; }
            public string on { set; get; }
            public string off { set; get; }
            public List<String> customDays { set; get; }
        }
    }
}