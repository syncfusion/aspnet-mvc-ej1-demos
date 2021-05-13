#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
    public partial class TreeViewController : Controller
    {
        //
        // GET: /TreeViewLoadonDemand/
        List<loadondemand> load = new List<loadondemand>();

        public ActionResult LoadonDemand()
        {

            load.Add(new loadondemand { id = 1, name = "Local Disk(C:)", hasChild = true });
            load.Add(new loadondemand { id = 2, pid = 1, name = "Folder 1" });
            load.Add(new loadondemand { id = 3, pid = 1, name = "Folder 2" });
            load.Add(new loadondemand { id = 4, pid = 1, name = "Folder 3", hasChild = true });
            load.Add(new loadondemand { id = 10, pid = 4, name = "File 1" });
            load.Add(new loadondemand { id = 11, pid = 4, name = "File 2", hasChild = true });
            load.Add(new loadondemand { id = 12, pid = 11, name = "File 3" });
            load.Add(new loadondemand { id = 5, name = "Local Disk(D:)", hasChild = true });
            load.Add(new loadondemand { id = 6, pid = 5, name = "Folder 4", hasChild = true });
            load.Add(new loadondemand { id = 7, pid = 6, name = "File 4" });
            load.Add(new loadondemand { id = 8, pid = 6, name = "File 5" });
            load.Add(new loadondemand { id = 9, pid = 6, name = "File 6" });
            load.Add(new loadondemand { id = 10, pid = 5, name = "Folder 5" });
            load.Add(new loadondemand { id = 11, pid = 5, name = "Folder 6" });
            load.Add(new loadondemand { id = 12, name = "Local Disk(E:)", hasChild = true });
            load.Add(new loadondemand { id = 13, pid = 12, name = "Folder 7", hasChild = true });
            load.Add(new loadondemand { id = 14, pid = 13, name = "File 7" });
            load.Add(new loadondemand { id = 15, pid = 13, name = "File 8" });
            load.Add(new loadondemand { id = 16, pid = 13, name = "File 9" });
            load.Add(new loadondemand { id = 17, pid = 12, name = "Folder 8" });
            load.Add(new loadondemand { id = 18, pid = 12, name = "Folder 9" });
            ViewBag.datasource = load;
            return View();
        }

    }
}
