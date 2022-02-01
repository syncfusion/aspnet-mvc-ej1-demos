#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
    public class ListLocalData
    {
        public string texts { get; set; }
        public string primaryKeys { get; set; }
        public string parentPrimaryKeyss { get; set; }
    }  
    public static class ListLocalDataModal
    {
        public static List<ListLocalData> listSource = new List<ListLocalData>();      
        public static List<ListLocalData> setListSource()
        {
            listSource.Add(new ListLocalData { texts = "Discover Music", primaryKeys = "1" });
            listSource.Add(new ListLocalData { texts = "Hot Singles", parentPrimaryKeyss = "1" });
            listSource.Add(new ListLocalData { texts = "Rising Artists", parentPrimaryKeyss = "1" });
            listSource.Add(new ListLocalData { texts = "Live Music", parentPrimaryKeyss = "1" });
            listSource.Add(new ListLocalData { texts = "Best of 2013 So Far", parentPrimaryKeyss = "1" });

            listSource.Add(new ListLocalData { texts = "Sales and Events", primaryKeys = "2" });
            listSource.Add(new ListLocalData { texts = "100 Albums - $5 Each", parentPrimaryKeyss = "2" });
            listSource.Add(new ListLocalData { texts = "Hip-Hop and R&B Sale", parentPrimaryKeyss = "2" });
            listSource.Add(new ListLocalData { texts = "CD Deals", parentPrimaryKeyss = "2" });

            listSource.Add(new ListLocalData { texts = "Categories", primaryKeys = "3" });
            listSource.Add(new ListLocalData { texts = "Songs", parentPrimaryKeyss = "3" });
            listSource.Add(new ListLocalData { texts = "Bestselling Albums", parentPrimaryKeyss = "3" });
            listSource.Add(new ListLocalData { texts = "New Releases", parentPrimaryKeyss = "3" });
            listSource.Add(new ListLocalData { texts = "Bestselling Songs", parentPrimaryKeyss = "3" });

            listSource.Add(new ListLocalData { texts = "MP3 Albums", primaryKeys = "4" });
            listSource.Add(new ListLocalData { texts = "Rock", parentPrimaryKeyss = "4" });
            listSource.Add(new ListLocalData { texts = "Gospel", parentPrimaryKeyss = "4" });
            listSource.Add(new ListLocalData { texts = "Latin Music", parentPrimaryKeyss = "4" });
            listSource.Add(new ListLocalData { texts = "Jazz", parentPrimaryKeyss = "4" });

            listSource.Add(new ListLocalData { texts = "More in Music", primaryKeys = "5" });
            listSource.Add(new ListLocalData { texts = "Music Trade-In", parentPrimaryKeyss = "5" });
            listSource.Add(new ListLocalData { texts = "Redeem a Gift Card", parentPrimaryKeyss = "5" });
            listSource.Add(new ListLocalData { texts = "Band T-Shirts", parentPrimaryKeyss = "5" });
            listSource.Add(new ListLocalData { texts = "Mobile MVC", parentPrimaryKeyss = "5" });

            return listSource;
        }
        public static void clearSource()
        {
            listSource.Clear();
        }       
    }
}