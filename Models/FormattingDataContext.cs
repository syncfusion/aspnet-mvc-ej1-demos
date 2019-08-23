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

namespace MVCSampleBrowser.Models
{
    public class FormattingDataContext
    {
        public class ColumnFormattingData
        {
            public double Number { get; set; }
            public double Currency { get; set; }
            public DateTime Date { get; set; }
        }
        public List<ColumnFormattingData> GetData
        {
            get
            {
                List<ColumnFormattingData> data = new List<ColumnFormattingData>();
                for (long i = 1; i < 10; i++)
                {
                    ColumnFormattingData[] c = new ColumnFormattingData[10];
                    c[i] = new ColumnFormattingData() { Number = 3233333.233876 / i, Currency = 3500044 / i, Date = new DateTime(2015, 3, 20).AddDays(i) };
                    data.Add(c[i]);
                }
                return data;
            }
        }
    }
}