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

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /QueryCell/
        List<Rooms> Rooms = new List<Rooms>();
        List<Rooms> Owner = new List<Rooms>();
        public ActionResult QueryCell()
        {
            ScheduleQueryCellInfo dbobj = new ScheduleQueryCellInfo();
            var DataSource = dbobj.GetRecords();
            ViewBag.datasource = DataSource;

            Rooms.Add(new Rooms { text = "Floor 1", id = "1", color = "#cb6bb2" });
            Rooms.Add(new Rooms { text = "Floor 2", id = "2", color = "#56ca85" });
            ViewBag.Rooms = Rooms;

            Owner.Add(new Rooms { text = "101 Hall", id = "1", groupId = "1", color = "#ffaa00" });
            Owner.Add(new Rooms { text = "103 Hall", id = "3", groupId = "2", color = "#f8a398" });
            Owner.Add(new Rooms { text = "102 Hall", id = "2", groupId = "1", color = "#7499e1" });
            ViewBag.Owners = Owner;

            List<String> resources = new List<String>();
            resources.Add("Rooms"); 
            resources.Add("Owners");
            ViewBag.Resources = resources;

            return View();
        }

    }
}
