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
