#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
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
    public partial class MenuController : Controller
    {
        //
        // GET: /Menudatabindingjson/
        List<MenuJson> menu = new List<MenuJson>();

        public ActionResult DataBindingJson()
        {
            menu.Add(new MenuJson { pid = 1, mtext = "Group A", parent = null });
            menu.Add(new MenuJson { pid = 2, mtext = "Group B", parent = null });
            menu.Add(new MenuJson { pid = 3, mtext = "Group C", parent = null });
            menu.Add(new MenuJson { pid = 4, mtext = "Group D", parent = null });
            menu.Add(new MenuJson { pid = 5, mtext = "Group E", parent = null });
            menu.Add(new MenuJson { pid = 11, parent = "1", mtext = "Algeria", sprite = "flag-dz" });
            menu.Add(new MenuJson { pid = 12, parent = "1", mtext = "Armenia", sprite = "flag-am" });
            menu.Add(new MenuJson { pid = 13, parent = "1", mtext = "Bangladesh", sprite = "flag-bd" });
            menu.Add(new MenuJson { pid = 14, parent = "1", mtext = "Cuba", sprite = "flag-cu" });
            menu.Add(new MenuJson { pid = 15, parent = "2", mtext = "Denmark", sprite = "flag-dk" });
            menu.Add(new MenuJson { pid = 16, parent = "2", mtext = "Egypt", sprite = "flag-eg" });
            menu.Add(new MenuJson { pid = 17, parent = "3", mtext = "Finland", sprite = "flag-fi" });
            menu.Add(new MenuJson { pid = 18, parent = "3", mtext = "India", sprite = "flag-in" });
            menu.Add(new MenuJson { pid = 19, parent = "3", mtext = "Malaysia", sprite = "flag-my" });
            menu.Add(new MenuJson { pid = 20, parent = "4", mtext = "New Zealand", sprite = "flag-nz" });
            menu.Add(new MenuJson { pid = 21, parent = "4", mtext = "Norway", sprite = "flag-no" });
            menu.Add(new MenuJson { pid = 22, parent = "4", mtext = "Romania", sprite = "flag-ro" });
            menu.Add(new MenuJson { pid = 23, parent = "5", mtext = "Singapore", sprite = "flag-sg" });
            menu.Add(new MenuJson { pid = 24, parent = "5", mtext = "Thailand", sprite = "flag-th" });
            menu.Add(new MenuJson { pid = 25, parent = "5", mtext = "Ukraine", sprite = "flag-ua" });
            menu.Add(new MenuJson { pid = 26, parent = "11", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 27, parent = "12", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 28, parent = "13", mtext = "Third place" });
            menu.Add(new MenuJson { pid = 29, parent = "14", mtext = "Fourth Place" });
            menu.Add(new MenuJson { pid = 30, parent = "15", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 31, parent = "16", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 32, parent = "17", mtext = "Third Place" });
            menu.Add(new MenuJson { pid = 33, parent = "18", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 34, parent = "19", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 35, parent = "20", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 36, parent = "21", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 37, parent = "22", mtext = "Third place" });
            menu.Add(new MenuJson { pid = 38, parent = "23", mtext = "Third Place" });
            menu.Add(new MenuJson { pid = 39, parent = "24", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 40, parent = "25", mtext = "Second Place" });
            ViewBag.datasource = menu;
            return View();
        }

    }
}
