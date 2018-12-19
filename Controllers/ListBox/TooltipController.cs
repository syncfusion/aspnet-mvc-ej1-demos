#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
    public partial class ListBoxController : Controller
    {
        //
        // GET: /Tooltip/

        List<EmployeeSpecialists> tooltipsrc = new List<EmployeeSpecialists>();
        public ActionResult Tooltip()
        {
            tooltipsrc.Add(new EmployeeSpecialists { text = "Erik Linden", desig="Representative"});
            tooltipsrc.Add(new EmployeeSpecialists { text = "John Linden", desig = "Manager" });
            tooltipsrc.Add(new EmployeeSpecialists { text = "Louis", desig="CEO"});
            tooltipsrc.Add(new EmployeeSpecialists { text = "Lawrence", desig="President" });
            tooltipsrc.Add(new EmployeeSpecialists { text = "Abraham", desig = "Vice-President" });
            tooltipsrc.Add(new EmployeeSpecialists { text = "Philip", desig = "Director" });
            tooltipsrc.Add(new EmployeeSpecialists { text = "James", desig = "Founder" });
            tooltipsrc.Add(new EmployeeSpecialists { text = "Kennedy", desig = "Co-Founder" });
            ViewBag.datasource = tooltipsrc;
            return View();
        }
    }
}
