#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
    public partial class ComboBoxController : Controller
    {
        //
        // GET: /Cascading/
        List<groups> group = new List<groups>();
        List<Countries> country = new List<Countries>();
        public ActionResult Cascading()
        {
            group.Add(new groups { parentId = "a", text = "Group A" });
            group.Add(new groups { parentId = "b", text = "Group B" });
            group.Add(new groups { parentId = "c", text = "Group C" });
            group.Add(new groups { parentId = "d", text = "Group D" });
            group.Add(new groups { parentId = "e", text = "Group E" });
            ViewBag.datasource = group;
            country.Add(new Countries { value = 11, parentId = "a", text = "Algeria", sprite = "flag-dz" });
            country.Add(new Countries { value = 12, parentId = "a", text = "Armenia", sprite = "flag-am" });
            country.Add(new Countries { value = 13, parentId = "a", text = "Bangladesh", sprite = "flag-bd" });
            country.Add(new Countries { value = 14, parentId = "a", text = "Cuba", sprite = "flag-cu" });
            country.Add(new Countries { value = 15, parentId = "b", text = "Denmark", sprite = "flag-dk" });
            country.Add(new Countries { value = 16, parentId = "b", text = "Egypt", sprite = "flag-eg" });
            country.Add(new Countries { value = 17, parentId = "c", text = "Finland", sprite = "flag-fi" });
            country.Add(new Countries { value = 18, parentId = "c", text = "India", sprite = "flag-in" });
            country.Add(new Countries { value = 19, parentId = "c", text = "Malaysia", sprite = "flag-my" });
            country.Add(new Countries { value = 20, parentId = "d", text = "New Zealand", sprite = "flag-nz" });
            country.Add(new Countries { value = 21, parentId = "d", text = "Norway", sprite = "flag-no" });
            country.Add(new Countries { value = 22, parentId = "d", text = "Romania", sprite = "flag-ro" });
            country.Add(new Countries { value = 23, parentId = "e", text = "Singapore", sprite = "flag-sg" });
            country.Add(new Countries { value = 24, parentId = "e", text = "Thailand", sprite = "flag-th" });
            country.Add(new Countries { value = 25, parentId = "e", text = "Ukraine", sprite = "flag-ua" });
            ViewBag.datasource1 = country;
            return View();
        }

    }
}
