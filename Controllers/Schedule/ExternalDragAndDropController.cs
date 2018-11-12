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
        // GET: /ExternalDragAndDrop/
        List<Rooms> Externalowners = new List<Rooms>();

        public ActionResult ExternalDragAndDrop()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.datasource = DataSource;

            Externalowners.Add(new Rooms { text = "Nancy", id = "1", color = "#f8a398" });
            Externalowners.Add(new Rooms { text = "Steven", id = "3", color = "#56ca85" });
            Externalowners.Add(new Rooms { text = "Michael", id = "5", color = "#51a0ed" });
            ViewBag.Owners = Externalowners;

            List<String> resources = new List<String>();
            resources.Add("Owners");
            ViewBag.Resources = resources;
            return View();
        }

    }
}
