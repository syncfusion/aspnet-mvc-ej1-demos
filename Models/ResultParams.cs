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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCSampleBrowser.Models
{
    public class ResultParams
    {
        public string key { get; set; }
        public string action { get; set; }
        public List<DefaultSchedule> added { get; set; }

        public List<DefaultSchedule> changed { get; set; }
        public List<DefaultSchedule> deleted { get; set; }
        public DefaultSchedule value { get; set; }
    }
}