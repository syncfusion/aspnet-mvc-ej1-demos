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

namespace MVCSampleBrowser.Areas.SpreadsheetTemplate.Models
{
    public class ItemDetail
    {
        public string DATE { get; set; }
        public string ITEM { get; set; }
        public int AMOUNT { get; set; }
        public int CHECK { get; set; }
        public string REMARKS { get; set; }
    }

    public class paymentDetail
    {
        public string DATE { get; set; }
        public string ITEM { get; set; }
        public int COST { get; set; }
        public int ODOM { get; set; }
        public string REMARKS { get; set; }
    }
}