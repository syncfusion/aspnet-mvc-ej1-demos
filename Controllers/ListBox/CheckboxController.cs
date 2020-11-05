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
    public partial class ListBoxController : Controller
    {
        //
        // GET: /Checkbox/
        List<Languages> language = new List<Languages>();
        public ActionResult Checkbox()
        {
            language.Add(new Languages { text = "ActionScript" });
            language.Add(new Languages { text = "AppleScript" });
            language.Add(new Languages { text = "Asp" });
            language.Add(new Languages { text = "BASIC" });
            language.Add(new Languages { text = "C" });
            language.Add(new Languages { text = "C++" });
            language.Add(new Languages { text = "Clojure" });
            language.Add(new Languages { text = "COBOL" });
            language.Add(new Languages { text = "ColdFusion" });
            language.Add(new Languages { text = "Erlang" });
            language.Add(new Languages { text = "Fortran" });
            language.Add(new Languages { text = "Groovy" });
            language.Add(new Languages { text = "Haskell" });
            language.Add(new Languages { text = "Java" });
            language.Add(new Languages { text = "JavaScript" });
            language.Add(new Languages { text = "Lisp" });
            language.Add(new Languages { text = "Perl" });
            language.Add(new Languages { text = "PHP" });
            language.Add(new Languages { text = "Python" });
            language.Add(new Languages { text = "Ruby" });
            language.Add(new Languages { text = "Scala" });
            language.Add(new Languages { text = "Scheme" });
            ViewBag.datasource = language;
            return View();
        }

    }
}
