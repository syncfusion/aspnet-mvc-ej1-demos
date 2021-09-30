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
    public partial class DropdownlistController : Controller
    {
        //
        // GET: /DropdownlistKeyboard/
        List<Fonts> f = new List<Fonts>();
        public ActionResult Keyboard()
        {
            f.Add(new Fonts { font = "Algerian" });
            f.Add(new Fonts { font = "ARIAL" });
            f.Add(new Fonts { font = "Bimini" });
            f.Add(new Fonts { font = "Courier" });
            f.Add(new Fonts { font = "Cursive" });
            f.Add(new Fonts { font = "Fantasy" });
            f.Add(new Fonts { font = "Georgia" });
            f.Add(new Fonts { font = "Impact" });
            f.Add(new Fonts { font = "New york" });
            f.Add(new Fonts { font = "Sans-Serif" });
            f.Add(new Fonts { font = "Scripts" });
            f.Add(new Fonts { font = "Times" });
            f.Add(new Fonts { font = "Times New Roman" });
            f.Add(new Fonts { font = "Verdana" });
            f.Add(new Fonts { font = "Zapfellipt bt" });
            ViewBag.datasource = f;
            return View();
        }

    }
}
