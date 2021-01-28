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
    public class ListData
    {
        public string texts { get; set; }
    }
    public static class ListDataModal {
        public static List<ListData> listTempSource = new List<ListData>();
        public static List<ListData> setListDataSource()
        {
            listTempSource.Add(new ListData { texts = "Discover Music" });
            listTempSource.Add(new ListData { texts = "Sales and Events" });
            listTempSource.Add(new ListData { texts = "Categories" });
            listTempSource.Add(new ListData { texts = "MP3 Albums" });
            listTempSource.Add(new ListData { texts = "More in Music" });
            return listTempSource;
        }
        public static void clearSource()
        {
            listTempSource.Clear();
        }
    }
}