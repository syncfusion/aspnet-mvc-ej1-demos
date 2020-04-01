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
using System.Text;

namespace MVCSampleBrowser.Models
{
    public class StockDataContext
    {
        public class StockDetails
        {
            public string Symbol { get; set; }
            public string Open { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Close { get; set; }
            public string Change { get; set; }
            public string TradedVolume { get; set; }
            public string TradedValue { get; set; }
            public string WeekHigh { get; set; }
            public string WeekLow { get; set; }
            public string yearChange { get; set; }
            public string monthChange { get; set; }
        }
        public List<StockDetails> GetStockData
        {
            get
            {
                List<StockDetails> details = new List<StockDetails>();
                StockDetails[] sData = new StockDetails[21];
                sData[0] = new StockDetails() { Symbol = "DDNDKJ", Open = "6,088.20", High = "6,114.55", Low = "6,084.15", Close = "12.5", Change = "0.21", TradedVolume = "79.94", TradedValue = "355.7", WeekHigh = "6,114.55", WeekLow = "4,770.35", yearChange = "14.37", monthChange = "9.87" };
                sData[1] = new StockDetails() { Symbol = "FKLND", Open = "2,042.00", High = "2,108.40", Low = "2,042.00", Close = "77.8", Change = "3.85", TradedVolume = "0.94", TradedValue = "19.57", WeekHigh = "2,108.40", WeekLow = "1,526.40", yearChange = "23.7", monthChange = "10.55" };
                sData[2] = new StockDetails() { Symbol = "DSNNS", Open = "740", High = "772.3", Low = "740", Close = "26.6", Change = "3.58", TradedVolume = "3.82", TradedValue = "29.08", WeekHigh = "772.3", WeekLow = "496.4", yearChange = "47.28", monthChange = "23.20" };
                sData[3] = new StockDetails() { Symbol = "MLSSD", Open = "939.5", High = "958.2", Low = "939.5", Close = "22.1", Change = "2.36", TradedVolume = "1.18", TradedValue = "11.26", WeekHigh = "998.85", WeekLow = "553", yearChange = "47.28", monthChange = "9.87" };
                sData[4] = new StockDetails() { Symbol = "LKSNDL", Open = "4,641.10", High = "4,749.75", Low = "4,641.10", Close = "99.25", Change = "2.14", TradedVolume = "0.22", TradedValue = "10.47", WeekHigh = "5,050.00", WeekLow = "3,432.40", yearChange = "61.24", monthChange = "11.63" };
                sData[5] = new StockDetails() { Symbol = "NKJSN", Open = "445", High = "451.9", Low = "442", Close = "6.95", Change = "1.57", TradedVolume = "1.07", TradedValue = "4.78", WeekHigh = "578.4", WeekLow = "370.8", yearChange = "29.67", monthChange = "4.45" };
                sData[6] = new StockDetails() { Symbol = "LNKNDS", Open = "298.5", High = "303.95", Low = "298.5", Close = "4.25", Change = "1.42", TradedVolume = "2.12", TradedValue = "6.42", WeekHigh = "386.25", WeekLow = "289.4", yearChange = "-9.42", monthChange = "3.13" };
                sData[7] = new StockDetails() { Symbol = "NSDN", Open = "400", High = "403", Low = "397.95", Close = "4.6", Change = "1.16", TradedVolume = "1.7", TradedValue = "6.81", WeekHigh = "435", WeekLow = "300", yearChange = "-5.40", monthChange = "-1.52" };
                sData[8] = new StockDetails() { Symbol = "SDMSMD", Open = "162.75", High = "164.85", Low = "162.4", Close = "1.85", Change = "1.14", TradedVolume = "1.18", TradedValue = "1.94", WeekHigh = "207.95", WeekLow = "140.3", yearChange = "23.21", monthChange = "0.79" };
                sData[9] = new StockDetails() { Symbol = "SMMSDS", Open = "75.4", High = "76.45", Low = "75.2", Close = "0.75", Change = "0.99", TradedVolume = "14.44", TradedValue = "10.95", WeekHigh = "106.7", WeekLow = "58", yearChange = "-6", monthChange = "11.78" };
                sData[10] = new StockDetails() { Symbol = "MSMDM", Open = "2,291.00", High = "2,315.00", Low = "2,291.00", Close = "20.4", Change = "0.89", TradedVolume = "1.09", TradedValue = "25.1", WeekHigh = "2,551.70", WeekLow = "1,802.30", yearChange = "26.37", monthChange = "15.28" };
                sData[11] = new StockDetails() { Symbol = "MLKSDM", Open = "329.7", High = "329.7", Low = "327.2", Close = "2.65", Change = "0.81", TradedVolume = "1.88", TradedValue = "6.16", WeekHigh = "355", WeekLow = "227.4", yearChange = "25.55", monthChange = "14.38" };
                sData[12] = new StockDetails() { Symbol = "BDSBD", Open = "730.5", High = "736.75", Low = "727.15", Close = "5.55", Change = "0.76", TradedVolume = "0.33", TradedValue = "2.38", WeekHigh = "736.75", WeekLow = "524.1", yearChange = "26.87", monthChange = "8.65" };
                sData[13] = new StockDetails() { Symbol = "SKJDB", Open = "421.5", High = "424.9", Low = "416", Close = "2.95", Change = "0.71", TradedVolume = "2.51", TradedValue = "10.5", WeekHigh = "789.35", WeekLow = "315", yearChange = "35.88", monthChange = "15.32" };
                sData[14] = new StockDetails() { Symbol = "VDSVH", Open = "505", High = "509", Low = "503", Close = "3.35", Change = "0.66", TradedVolume = "1.01", TradedValue = "5.14", WeekHigh = "509.5", WeekLow = "279", yearChange = "-40.65", monthChange = "13.13" };
                sData[15] = new StockDetails() { Symbol = "DSJBD", Open = "1,730.00", High = "1,739.95", Low = "1,721.20", Close = "10.05", Change = "0.58", TradedVolume = "1.14", TradedValue = "19.74", WeekHigh = "1,739.95", WeekLow = "1,051.00", yearChange = "61.28", monthChange = "31.47" };
                sData[16] = new StockDetails() { Symbol = "BSBDBD", Open = "1,161.00", High = "1,172.00", Low = "1,161.00", Close = "6.25", Change = "0.54", TradedVolume = "0.81", TradedValue = "9.51", WeekHigh = "1,232.00", WeekLow = "767.4", yearChange = "37.73", monthChange = "23.04" };
                sData[17] = new StockDetails() { Symbol = "BDBSJ", Open = "770", High = "776", Low = "768.65", Close = "4.05", Change = "0.53", TradedVolume = "0.82", TradedValue = "6.31", WeekHigh = "920", WeekLow = "659.2", yearChange = "43.90", monthChange = "16.66" };
                sData[18] = new StockDetails() { Symbol = "NSDJN", Open = "106", High = "106.8", Low = "105.35", Close = "0.55", Change = "0.52", TradedVolume = "4.75", TradedValue = "5.04", WeekHigh = "137.1", WeekLow = "86.9", yearChange = "2.89", monthChange = "9.53" };
                sData[19] = new StockDetails() { Symbol = "NDSS", Open = "3,000.30", High = "3,040.00", Low = "3,000.30", Close = "14.9", Change = "0.49", TradedVolume = "0.03", TradedValue = "0.76", WeekHigh = "3,510.00", WeekLow = "2,210.00", yearChange = "-9.36", monthChange = "17.10" };
                sData[20] = new StockDetails() { Symbol = "NKDN", Open = "126", High = "128", Low = "126", Close = "0.6", Change = "0.47", TradedVolume = "1.61", TradedValue = "2.05", WeekHigh = "202.8", WeekLow = "121.85", yearChange = "22.41", monthChange = "10.60" };
                for (int i = 0; i < 21; i++)
                {
                    details.Add(sData[i]);
                }
                return details;
            }
        }
    }
}
