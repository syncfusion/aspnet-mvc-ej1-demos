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
using System.IO;

namespace MVCSampleBrowser.Models
{
    public class loadondemand
    {
        public int id { get; set; }
        public int? pid { get; set; }
        public string name { get; set; }
        public bool? hasChild { get; set; }
        public bool? expanded { get; set; }
        public bool? ischecked { get; set; }
        public bool? selected { get; set; }
        public string spriteCss { get; set; }
    }

    }