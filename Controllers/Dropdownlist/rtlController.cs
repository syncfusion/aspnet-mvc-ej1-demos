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
        // GET: /Dropdownrtl/
        List<Languages> lg = new List<Languages>();
        public ActionResult rtl()
        {
            lg.Add(new Languages { skill = "ActionScript" });
            lg.Add(new Languages { skill = "AppleScript" });
            lg.Add(new Languages { skill = "Asp" });
            lg.Add(new Languages { skill = "BASIC" });
            lg.Add(new Languages { skill = "C" });
            lg.Add(new Languages { skill = "C++" });
            lg.Add(new Languages { skill = "Clojure" });
            lg.Add(new Languages { skill = "COBOL" });
            lg.Add(new Languages { skill = "ColdFusion" });
            lg.Add(new Languages { skill = "Erlang" });
            lg.Add(new Languages { skill = "Fortran" });
            lg.Add(new Languages { skill = "Groovy" });
            lg.Add(new Languages { skill = "Haskell" });
            lg.Add(new Languages { skill = "Java" });
            lg.Add(new Languages { skill = "JavaScript" });
            lg.Add(new Languages { skill = "Lisp" });
            lg.Add(new Languages { skill = "Perl" });
            lg.Add(new Languages { skill = "PHP" });
            lg.Add(new Languages { skill = "Python" });
            lg.Add(new Languages { skill = "Ruby" });
            lg.Add(new Languages { skill = "Scala" });
            lg.Add(new Languages { skill = "Scheme" });
            ViewBag.datasource = lg;
            return View();
        }

    }
}
