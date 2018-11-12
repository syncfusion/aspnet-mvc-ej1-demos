using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.BulletGraph
{
    public partial class BulletGraphController : Controller
    {
        //
        // GET: /API/
        List<BulletGraphProperties> bulletGraphPropertiesOrientation = new List<BulletGraphProperties>();
        List<BulletGraphProperties> bulletGraphPropertiesDirection = new List<BulletGraphProperties>();
        List<BulletGraphProperties> bulletGraphPropertiesStroke = new List<BulletGraphProperties>();
        public ActionResult API()
        {
            bulletGraphPropertiesOrientation.Add(new BulletGraphProperties { Orientation = "--Select--" });
            bulletGraphPropertiesOrientation.Add(new BulletGraphProperties { Orientation = "horizontal" });
            bulletGraphPropertiesOrientation.Add(new BulletGraphProperties { Orientation = "vertical" });
            bulletGraphPropertiesDirection.Add(new BulletGraphProperties { Direction = "--Select--" });
            bulletGraphPropertiesDirection.Add(new BulletGraphProperties { Direction = "backward" });
            bulletGraphPropertiesDirection.Add(new BulletGraphProperties { Direction = "forward" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "--Select--" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "red" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "yellow" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "green" });

            ViewBag.datasourceOrientation = bulletGraphPropertiesOrientation;
            ViewBag.datasourceDirection = bulletGraphPropertiesDirection;
            ViewBag.datasourceStroke = bulletGraphPropertiesStroke;
            return View();
        }

    }
}
