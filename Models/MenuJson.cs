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

namespace MVCSampleBrowser.Models
{
    public class MenuJson
    {
        public string mtext { get; set; }
        public string sprite { get; set; }
        public int pid { get; set; }
        public string parent { get; set; }
    }

    public class GroupJson
    {
        public string text { get; set; }
        public string contentType { get; set; }
        public string selected { get; set; }
    }
}