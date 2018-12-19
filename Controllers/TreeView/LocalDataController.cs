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
        //
        // GET: /TreeViewLocalData/
        List<loadondemand> localData = new List<loadondemand>();
        public ActionResult Localdata()
        {

            localData.Add(new loadondemand { id = 1, name = "Discover Music", hasChild = true, expanded = true });
            localData.Add(new loadondemand { id = 2, pid = 1, name = "Hot Singles" });
            localData.Add(new loadondemand { id = 3, pid = 1, name = "Rising Artists" });
            localData.Add(new loadondemand { id = 4, pid = 1, name = "Live Music" });
            localData.Add(new loadondemand { id = 6, pid = 1, name = "Best of 2013 So Far" });
            localData.Add(new loadondemand { id = 7, name = "Sales and Events", hasChild = true, expanded = true });
            localData.Add(new loadondemand { id = 8, pid = 7, name = "100 Albums - $5 Each" });
            localData.Add(new loadondemand { id = 9, pid = 7, name = "Hip-Hop and R&B Sale" });
            localData.Add(new loadondemand { id = 10, pid = 7, name = "CD Deals" });
            localData.Add(new loadondemand { id = 11, name = "Categories", hasChild = true });
            localData.Add(new loadondemand { id = 12, pid = 11, name = "Songs" });
            localData.Add(new loadondemand { id = 13, pid = 11, name = "Bestselling Albums" });
            localData.Add(new loadondemand { id = 14, pid = 11, name = "New Releases" });
            localData.Add(new loadondemand { id = 15, pid = 11, name = "Bestselling Songs" });
            localData.Add(new loadondemand { id = 16, name = "MP3 Albums", hasChild = true });
            localData.Add(new loadondemand { id = 17, pid = 16, name = "Rock" });
            localData.Add(new loadondemand { id = 18, pid = 16, name = "Gospel" });
            localData.Add(new loadondemand { id = 19, pid = 16, name = "Latin Music" });
            localData.Add(new loadondemand { id = 20, pid = 16, name = "Jazz" });
            localData.Add(new loadondemand { id = 21, name = "More in Music", hasChild = true });
            localData.Add(new loadondemand { id = 22, pid = 21, name = "Music Trade-In" });
            localData.Add(new loadondemand { id = 23, pid = 21, name = "Redeem a Gift Card" });
            localData.Add(new loadondemand { id = 24, pid = 21, name = "Band T-Shirts" });
            localData.Add(new loadondemand { id = 25, pid = 21, name = "Mobile MVC" });

            ViewBag.datasource = localData;
            return View();
        }
       

    }
}
