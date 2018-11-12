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
        // GET: /MultipleResource/
        List<Rooms> Horizontalowners = new List<Rooms>();

        public ActionResult HorizontalMultipleResource()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.datasource = DataSource;

            Horizontalowners.Add(new Rooms { text = "Nancy", id = "1", color = "#f8a398" });
            Horizontalowners.Add(new Rooms { text = "Steven", id = "3", color = "#56ca85" });
            Horizontalowners.Add(new Rooms { text = "Michael", id = "5", color = "#51a0ed" });
            ViewBag.Owners = Horizontalowners;

            List<String> resources = new List<String>();
            resources.Add("Owners");
            ViewBag.Resources = resources;
            return View();
        }

    }
}
