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

namespace MVCSampleBrowser.Models
{
    public class Languages
    {
        public string text { get; set; }
        public string skill { get; set; }
        public static List<Languages> GetLanguages()
        {
            List<Languages> language = new List<Languages>();
            language.Add(new Languages { text = "ActionScript" });
            language.Add(new Languages { text = "AppleScript" });
            language.Add(new Languages { text = "Asp" });
            language.Add(new Languages { text = "BASIC" });
            language.Add(new Languages { text = "BeanShell" });
            language.Add(new Languages { text = "C" });
            language.Add(new Languages { text = "C++" });
            language.Add(new Languages { text = "C#" });
            language.Add(new Languages { text = "Clojure" });
            language.Add(new Languages { text = "COBOL" });
            language.Add(new Languages { text = "ColdFusion" });
            language.Add(new Languages { text = "DataFlex" });
            language.Add(new Languages { text = "DCL" });
            language.Add(new Languages { text = "Erlang" });
            language.Add(new Languages { text = "E#" });
            language.Add(new Languages { text = "Fortran" });
            language.Add(new Languages { text = "F#" });
            language.Add(new Languages { text = "Flex" });
            language.Add(new Languages { text = "Google Apps Script" });
            language.Add(new Languages { text = "Groovy" });
            language.Add(new Languages { text = "Haskell" });
            language.Add(new Languages { text = "Hope" });
            language.Add(new Languages { text = "IBM HAScript" });
            language.Add(new Languages { text = "Java" });
            language.Add(new Languages { text = "JavaScript" });
            language.Add(new Languages { text = "J#" });
            language.Add(new Languages { text = "Lisp" });
            language.Add(new Languages { text = "MATLAB" });
            language.Add(new Languages { text = "Oak" });
            language.Add(new Languages { text = "Perl" });
            language.Add(new Languages { text = "PHP" });
            language.Add(new Languages { text = "Python" });
            language.Add(new Languages { text = "Ruby" });
            language.Add(new Languages { text = "Scala" });
            language.Add(new Languages { text = "Scheme" });
            language.Add(new Languages { text = "T-SQL" });
            language.Add(new Languages { text = "WebQL" });
            language.Add(new Languages { text = "ZOPL" });
            return language;
        }
    }
}