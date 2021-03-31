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
    public partial class ListBoxController : Controller
    {
        //
        // GET: /VirtualScrolling/
        List<Languages> loadlang= new List<Languages>();
        public ActionResult VirtualScrolling()
        {
            loadlang.Add(new Languages { text = "Bahrain" });
            loadlang.Add(new Languages { text = "Brazil" });
            loadlang.Add(new Languages { text = "Argentina" });
            loadlang.Add(new Languages { text = "Bangladesh" });
            loadlang.Add(new Languages { text = "Burma" });
            loadlang.Add(new Languages { text = "Afghanistan" });
            loadlang.Add(new Languages { text = "Antigua and Barbuda" });
            loadlang.Add(new Languages { text = "Barbados" });
            loadlang.Add(new Languages { text = "Botswana" });
            loadlang.Add(new Languages { text = "Albania" });
            loadlang.Add(new Languages { text = "Andorra" });
            loadlang.Add(new Languages { text = "Belarus" });
            loadlang.Add(new Languages { text = "Bolivia" });
            loadlang.Add(new Languages { text = "Algeria" });
            loadlang.Add(new Languages { text = "Angola" });
            loadlang.Add(new Languages { text = "Cambodia" });
            loadlang.Add(new Languages { text = "Cameroon" });
            loadlang.Add(new Languages { text = "Canada" });
            loadlang.Add(new Languages { text = "Cape Verde" });
            loadlang.Add(new Languages { text = "China" });
            loadlang.Add(new Languages { text = "Colombia" });
            loadlang.Add(new Languages { text = "Congo" });
            loadlang.Add(new Languages { text = "Costa Rica" });
            loadlang.Add(new Languages { text = "Cuba" });
            loadlang.Add(new Languages { text = "Denmark" });
            loadlang.Add(new Languages { text = "Djibouti" });
            loadlang.Add(new Languages { text = "Dominica" });
            loadlang.Add(new Languages { text = "East Timor" });
            loadlang.Add(new Languages { text = "Ecuador" });
            loadlang.Add(new Languages { text = "Egypt" });
            loadlang.Add(new Languages { text = "England" });
            loadlang.Add(new Languages { text = "Eritrea" });
            loadlang.Add(new Languages { text = "Estonia" });
            loadlang.Add(new Languages { text = "Ethiopia" });
            loadlang.Add(new Languages { text = "Fiji" });
            loadlang.Add(new Languages { text = "Finland" });
            loadlang.Add(new Languages { text = "France" });
            loadlang.Add(new Languages { text = "Gabon" });
            loadlang.Add(new Languages { text = "Georgia" });
            loadlang.Add(new Languages { text = "Germany" });
            loadlang.Add(new Languages { text = "Ghana" });
            loadlang.Add(new Languages { text = "Gibraltar" });
            loadlang.Add(new Languages { text = "Greece" });
            loadlang.Add(new Languages { text = "Greenland" });
            loadlang.Add(new Languages { text = "Grenada" });
            loadlang.Add(new Languages { text = "Guadeloupe" });
            loadlang.Add(new Languages { text = "Guam" });
            loadlang.Add(new Languages { text = "Guatemala" });
            loadlang.Add(new Languages { text = "Guinea" });
            loadlang.Add(new Languages { text = "Guyana" });
            loadlang.Add(new Languages { text = "Haiti" });
            loadlang.Add(new Languages { text = "Holland" });
            loadlang.Add(new Languages { text = "Holy See" });
            loadlang.Add(new Languages { text = "Honduras" });
            loadlang.Add(new Languages { text = "Hong Kong" });
            loadlang.Add(new Languages { text = "Hungary" });
            loadlang.Add(new Languages { text = "Iceland" });
            loadlang.Add(new Languages { text = "India" });
            loadlang.Add(new Languages { text = "Indonesia" });
            loadlang.Add(new Languages { text = "Iran" });
            loadlang.Add(new Languages { text = "Iraq" });
            loadlang.Add(new Languages { text = "Ireland" });
            loadlang.Add(new Languages { text = "Israel" });
            loadlang.Add(new Languages { text = "Italy" });
            loadlang.Add(new Languages { text = "Jamaica" });
            loadlang.Add(new Languages { text = "Japan" });
            loadlang.Add(new Languages { text = "Jordan" });
            loadlang.Add(new Languages { text = "Kenya" });
            loadlang.Add(new Languages { text = "Kiribati" });
            loadlang.Add(new Languages { text = "Korea" });
            loadlang.Add(new Languages { text = "Kuwait" });
            loadlang.Add(new Languages { text = "Lebanon" });
            loadlang.Add(new Languages { text = "Liberia" });
            loadlang.Add(new Languages { text = "Madagascar" });
            loadlang.Add(new Languages { text = "Malaysia" });
            ViewBag.datasourceload = loadlang;
            return View();
        }

    }
}
