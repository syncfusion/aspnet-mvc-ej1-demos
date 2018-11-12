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
        // GET: /BlockTime/

        public ActionResult BlockTime()
        {
            ScheduleBlockTime dbobj = new ScheduleBlockTime();
            ViewBag.blockDataSource = dbobj.GetBlockData();
            ViewBag.datasource = dbobj.GetAppointmentData();

            List<Rooms> owners = new List<Rooms>();
            owners.Add(new Rooms { text = "Airline 1", id = "1", color = "#f8a398" });
            owners.Add(new Rooms { text = "Airline 2", id = "3", color = "#56ca85" });
            owners.Add(new Rooms { text = "Airline 3", id = "5", color = "#51a0ed" });
            ViewBag.Owners = owners;

            List<String> resources = new List<String>();
            resources.Add("Owners");
            ViewBag.Resources = resources;
            return View();
        }

    }
}
