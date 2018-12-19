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
    public partial class TreeViewController : Controller
    {
        // GET: MultiSelection
        List<loadondemand> fullRowData = new List<loadondemand>();
        public ActionResult FullRowSelection()
        {
            fullRowData.Add(new loadondemand { id = 1, name = "Discover Music", hasChild = true, expanded = true });
            fullRowData.Add(new loadondemand { id = 2, pid = 1, name = "Hot Singles", selected = true });
            fullRowData.Add(new loadondemand { id = 3, pid = 1, name = "Rising Artists" });
            fullRowData.Add(new loadondemand { id = 4, pid = 1, name = "Live Music" });
            fullRowData.Add(new loadondemand { id = 6, pid = 1, name = "Best of 2013 So Far" });
            fullRowData.Add(new loadondemand { id = 7, name = "Sales and Events", hasChild = true, expanded = true });
            fullRowData.Add(new loadondemand { id = 8, pid = 7, name = "100 Albums - $5 Each" });
            fullRowData.Add(new loadondemand { id = 9, pid = 7, name = "Hip-Hop and R&B Sale" });
            fullRowData.Add(new loadondemand { id = 10, pid = 7, name = "CD Deals" });
            fullRowData.Add(new loadondemand { id = 11, name = "Categories", hasChild = true });
            fullRowData.Add(new loadondemand { id = 12, pid = 11, name = "Songs" });
            fullRowData.Add(new loadondemand { id = 13, pid = 11, name = "Bestselling Albums" });
            fullRowData.Add(new loadondemand { id = 14, pid = 11, name = "New Releases" });
            fullRowData.Add(new loadondemand { id = 15, pid = 11, name = "Bestselling Songs" });
            fullRowData.Add(new loadondemand { id = 16, name = "MP3 Albums", hasChild = true });
            fullRowData.Add(new loadondemand { id = 17, pid = 16, name = "Rock" });
            fullRowData.Add(new loadondemand { id = 18, pid = 16, name = "Gospel" });
            fullRowData.Add(new loadondemand { id = 19, pid = 16, name = "Latin Music" });
            fullRowData.Add(new loadondemand { id = 20, pid = 16, name = "Jazz" });
            fullRowData.Add(new loadondemand { id = 21, name = "More in Music", hasChild = true });
            fullRowData.Add(new loadondemand { id = 22, pid = 21, name = "Music Trade-In" });
            fullRowData.Add(new loadondemand { id = 23, pid = 21, name = "Redeem a Gift Card" });
            fullRowData.Add(new loadondemand { id = 24, pid = 21, name = "Band T-Shirts" });
            fullRowData.Add(new loadondemand { id = 25, pid = 21, name = "Mobile MVC" });

            ViewBag.datasource = fullRowData;
            return View();
        }
    }
}