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
        // GET: /Tooltip/
        List<Resource> resource = new List<Resource>();

        public ActionResult Tooltip()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.datasource = DataSource;

            resource.Add(new Resource { text = "Nancy", id = "1", color = "#f8a398" });
            resource.Add(new Resource { text = "Steven", id = "3", color = "#56ca85" });
            resource.Add(new Resource { text = "Michael", id = "5", color = "#51a0ed" });
            ViewBag.Owners = resource;

            List<String> resources = new List<String>();
            resources.Add("Owners");
            ViewBag.Resources = resources;

            return View();

        }

    }
    public class Resource
    {
        public string text { set; get; }
        public string id { set; get; }
        public string groupId { set; get; }
        public string color { set; get; }
    }
   
}
