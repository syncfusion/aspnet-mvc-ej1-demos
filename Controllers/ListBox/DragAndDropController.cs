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
        // GET: /DragAndDrop/
        List<Languages> lang = new List<Languages>();
        public ActionResult DragAndDrop()
        {
            lang.Add(new Languages { text = "ActionScript" });
            lang.Add(new Languages { text = "AppleScript" });
            lang.Add(new Languages { text = "Asp" });
            lang.Add(new Languages { text = "BASIC" });
            lang.Add(new Languages { text = "C" });
            lang.Add(new Languages { text = "C++" });
            lang.Add(new Languages { text = "Clojure" });
            lang.Add(new Languages { text = "COBOL" });
            lang.Add(new Languages { text = "ColdFusion" });
            lang.Add(new Languages { text = "Erlang" });
            lang.Add(new Languages { text = "Fortran" });
            lang.Add(new Languages { text = "Groovy" });
            lang.Add(new Languages { text = "Haskell" });
            lang.Add(new Languages { text = "Java" });
            lang.Add(new Languages { text = "JavaScript" });
            lang.Add(new Languages { text = "Lisp" });
            lang.Add(new Languages { text = "Perl" });
            lang.Add(new Languages { text = "PHP" });
            lang.Add(new Languages { text = "Python" });
            lang.Add(new Languages { text = "Ruby" });
            lang.Add(new Languages { text = "Scala" });
            lang.Add(new Languages { text = "Scheme" });
            ViewBag.datasourcelang = lang;
            return View();
        }

    }
}
