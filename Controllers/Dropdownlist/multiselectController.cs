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
    public partial class DropdownlistController : Controller
    {
        //
        // GET: /Dropdwnlistmultiselect/
        List<Languages> lang = new List<Languages>();
        public ActionResult multiselect()
        {
            lang.Add(new Languages { skill = "ActionScript" });
            lang.Add(new Languages { skill = "AppleScript" });
            lang.Add(new Languages { skill = "Asp" });
            lang.Add(new Languages { skill = "BASIC" });
            lang.Add(new Languages { skill = "C" });
            lang.Add(new Languages { skill = "C++" });
            lang.Add(new Languages { skill = "Clojure" });
            lang.Add(new Languages { skill = "COBOL" });
            lang.Add(new Languages { skill = "ColdFusion" });
            lang.Add(new Languages { skill = "Erlang" });
            lang.Add(new Languages { skill = "Fortran" });
            lang.Add(new Languages { skill = "Groovy" });
            lang.Add(new Languages { skill = "Haskell" });
            lang.Add(new Languages { skill = "Java" });
            lang.Add(new Languages { skill = "JavaScript" });
            lang.Add(new Languages { skill = "Lisp" });
            lang.Add(new Languages { skill = "Perl" });
            lang.Add(new Languages { skill = "PHP" });
            lang.Add(new Languages { skill = "Python" });
            lang.Add(new Languages { skill = "Ruby" });
            lang.Add(new Languages { skill = "Scala" });
            lang.Add(new Languages { skill = "Scheme" });
            ViewBag.datasource = lang;
            return View();
        }

    }
}
