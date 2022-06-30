#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        // GET: /ResourceGrouping/
        List<Rooms> rooms = new List<Rooms>();
        List<Rooms> owner = new List<Rooms>();

        public ActionResult ResourceGrouping()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.datasource = DataSource;

            rooms.Add(new Rooms { text = "ROOM 1", id = "1", color = "#cb6bb2" });
            rooms.Add(new Rooms { text = "ROOM 2", id = "2", color = "#56ca85" });
            ViewBag.Rooms = rooms;

            owner.Add(new Rooms { text = "Nancy", id = "1", groupId = "1", color = "#ffaa00" });
            owner.Add(new Rooms { text = "Steven", id = "3", groupId = "2", color = "#f8a398" });
            owner.Add(new Rooms { text = "Michael", id = "5", groupId = "1", color = "#7499e1" });
            ViewBag.Owners = owner;

            List<String> resources = new List<String>();
            resources.Add("Rooms"); resources.Add("Owners");
            ViewBag.Resources = resources;

            return View();
        }

    }

}

