using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class DropdownlistController : Controller
    {
        //
        // GET: /DropdownlistDatabindingLocal/
        List<Bikes> bike = new List<Bikes>();
        public ActionResult DatabindingLocal()
        {
            bike.Add(new Bikes { empid = "bk1", text = "Apache RTR" });
            bike.Add(new Bikes { empid = "bk2", text = "CBR 150-R" });
            bike.Add(new Bikes { empid = "bk3", text = "CBZ Xtreme" });
            bike.Add(new Bikes { empid = "bk4", text = "Discover" });
            bike.Add(new Bikes { empid = "bk5", text = "Dazzler" });
            bike.Add(new Bikes { empid = "bk6", text = "Flame" });
            bike.Add(new Bikes { empid = "bk7", text = "Fazzer" });
            bike.Add(new Bikes { empid = "bk8", text = "FZ-S" });
            bike.Add(new Bikes { empid = "bk9", text = "Pulsar" });
            bike.Add(new Bikes { empid = "bk10", text = "Shine" });
            bike.Add(new Bikes { empid = "bk11", text = "R15" });
            bike.Add(new Bikes { empid = "bk12", text = "Unicorn" });
            ViewBag.datasource = bike;
            return View();
        }

    }
}
