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
    #region LocalData
    public class ChartLocalData
    {  
            public DateTime XValue
            {
                get;
                set;
            }
            public double YValue 
            { 
                get; 
                set; 
            }
            public static List<ChartLocalData> GetSeries1Data()
            {
                DateTime date1 = new DateTime(1930, 1, 1);
                Random r1 = new Random();
                List<ChartLocalData> localData1 = new List<ChartLocalData>();
                double value1 = 100;
                for (int i = 1; i < 1000; i++)
                {
                    double randomValue = r1.NextDouble();
                    if (randomValue > 0.5)
                        value1 = value1 + r1.NextDouble();
                    else
                        value1 = value1 - r1.NextDouble();
                    value1 = Math.Round(value1, 2);
                    localData1.Add(new ChartLocalData { XValue = date1.AddMonths(i + 2).AddDays(i), YValue = value1 });
                }    
                return localData1;
            }
         public static List<ChartLocalData> GetSeries2Data()
            {
                DateTime date2 = new DateTime(1930, 1, 1);
                Random r2 = new Random();
                List<ChartLocalData> localData2 = new List<ChartLocalData>();
                double value2 = 120;
                for (int i = 1; i < 1000; i++)
                {
                    double randomValue = r2.NextDouble();
                    if(randomValue > 0.5)
                        value2 = value2 + r2.NextDouble();
                    else
                        value2 = value2 - r2.NextDouble();
                    value2 = Math.Round(value2, 2);
                    localData2.Add(new ChartLocalData { XValue = date2.AddMonths(i + 2).AddDays(i), YValue = value2 });
                } 
                return localData2;           
        }
       
    }
    #endregion
}