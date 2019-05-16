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
        // GET: /Methods/
        List<Languages> skill = new List<Languages>();
        public ActionResult Methods()
        {
            skill.Add(new Languages { text = "ActionScript" });
            skill.Add(new Languages { text = "AppleScript" });
            skill.Add(new Languages { text = "Asp" });
            skill.Add(new Languages { text = "BASIC" });
            skill.Add(new Languages { text = "C" });
            skill.Add(new Languages { text = "C++" });
            skill.Add(new Languages { text = "Clojure" });
            skill.Add(new Languages { text = "COBOL" });
            skill.Add(new Languages { text = "ColdFusion" });
            skill.Add(new Languages { text = "Erlang" });
            skill.Add(new Languages { text = "Fortran" });
            skill.Add(new Languages { text = "Groovy" });
            skill.Add(new Languages { text = "Haskell" });
            skill.Add(new Languages { text = "Java" });
            skill.Add(new Languages { text = "JavaScript" });
            skill.Add(new Languages { text = "Lisp" });
            skill.Add(new Languages { text = "Perl" });
            skill.Add(new Languages { text = "PHP" });
            skill.Add(new Languages { text = "Python" });
            skill.Add(new Languages { text = "Ruby" });
            skill.Add(new Languages { text = "Scala" });
            skill.Add(new Languages { text = "Scheme" });
            ViewBag.datasource = skill;
            return View();
        }

    }
}
