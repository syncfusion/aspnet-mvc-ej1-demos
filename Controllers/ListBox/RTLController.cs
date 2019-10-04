#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        // GET: /RTL/

        List<Countries> countryList = new List<Countries>();
        public ActionResult rtl()
        {
            countryList.Add(new Countries { country = "الجیریا" });
            countryList.Add(new Countries { country = "ارمینیا" });
            countryList.Add(new Countries { country = "بنگلا دیش" });
            countryList.Add(new Countries { country = "کیوبا" });
            countryList.Add(new Countries { country = "ڈنمارک" });
            countryList.Add(new Countries { country = "مصر" });
            countryList.Add(new Countries { country = "فن لینڈ" });
            countryList.Add(new Countries { country = "بھارت" });
            countryList.Add(new Countries { country = "ملائیشیا" });
            countryList.Add(new Countries { country = "نیوزی لینڈ" });
            countryList.Add(new Countries { country = "ناروے" });
            ViewBag.datasource = countryList;
            return View();
        }

    }
}
