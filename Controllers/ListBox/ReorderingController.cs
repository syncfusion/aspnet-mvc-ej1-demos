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
    public partial class ListBoxController : Controller
    {
        //
        // GET: /Reordering/
        List<Languages> rlang = new List<Languages>();
        public ActionResult Reordering()
        {
            rlang.Add(new Languages { text = "ActionScript" });
            rlang.Add(new Languages { text = "AppleScript" });
            rlang.Add(new Languages { text = "Asp" });
            rlang.Add(new Languages { text = "BASIC" });
            rlang.Add(new Languages { text = "C" });
            rlang.Add(new Languages { text = "C++" });
            rlang.Add(new Languages { text = "Clojure" });
            rlang.Add(new Languages { text = "COBOL" });
            rlang.Add(new Languages { text = "ColdFusion" });
            rlang.Add(new Languages { text = "Erlang" });
            rlang.Add(new Languages { text = "Fortran" });
            rlang.Add(new Languages { text = "Groovy" });
            rlang.Add(new Languages { text = "Haskell" });
            rlang.Add(new Languages { text = "Java" });
            rlang.Add(new Languages { text = "JavaScript" });
            rlang.Add(new Languages { text = "Lisp" });
            rlang.Add(new Languages { text = "Perl" });
            rlang.Add(new Languages { text = "PHP" });
            rlang.Add(new Languages { text = "Python" });
            rlang.Add(new Languages { text = "Ruby" });
            rlang.Add(new Languages { text = "Scala" });
            rlang.Add(new Languages { text = "Scheme" });
            ViewBag.datasource = rlang;
            return View();
        }

    }
}
