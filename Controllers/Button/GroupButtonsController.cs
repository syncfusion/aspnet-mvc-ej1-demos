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
    public partial class ButtonController : Controller
    {
        //
        // GET: /ButtonGroupButtons/
        List<GroupJson> grpbtn = new List<GroupJson>();
        public ActionResult GroupButtons()
        {
            grpbtn.Add(new GroupJson { text = "Day", contentType = "textonly" });
            grpbtn.Add(new GroupJson { text = "Week", contentType = "textonly" });
            grpbtn.Add(new GroupJson { text = "Work Week", contentType = "textonly" });
            grpbtn.Add(new GroupJson { text = "Month", contentType = "textonly", selected = "selected" });
            grpbtn.Add(new GroupJson { text = "Agenda", contentType = "textonly" });
            ViewBag.datasource = grpbtn;
            return View();
        }

    }
}
