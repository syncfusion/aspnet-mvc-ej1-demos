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

namespace MVCSampleBrowser.Models
{
    public class WeatherData
    {
        public class WeatherDetails
        {
            
            public DateTime Date { get; set; }
            public string SkyCondition { get; set; }
            public double Humidity { get; set; }
            public double Wind { get; set; }
            public double Pressure { get; set; }
            public double Temperature { get; set; }
            public double FeelsLike { get; set; }
            public string Average { get; set; }
            public double Jan { get; set; }
            public double Feb { get; set; }
            public double Mar { get; set; }
            public double Apl { get; set; }
            public double May { get; set; }
            public double Jun { get; set; }
            public double Jul { get; set; }
            public double Aug { get; set; }
            public double Sep { get; set; }
            public double Oct { get; set; }
            public double Nov { get; set; }
            public double Dec { get; set; }
        }
        public List<WeatherDetails> GetWeatherData
        {
             
            get
            {
                string[] skyCondition = {"Snow", "Rain Storm", "Thunder", "Rainy", "Cloudy", "Partly Cloudy", "Sunny", "Partly Sunny"};
               
                List<WeatherDetails> details = new List<WeatherDetails>();
                Random rand = new Random();
                 for (var i = 0; i < 7; i++) {
                     
                     double val1 = rand.Next(0,30);
                     var val = rand.Next(0, 8);
                     details.Add(new WeatherDetails()
                         {
                             Date = DateTime.Now.AddHours(DateTime.Now.Hour + i),
                             SkyCondition = skyCondition[val],
                             Humidity = Math.Floor(val1 + 40),
                             Wind = Math.Floor(val1*10 + 1),
                             Pressure = Math.Floor(val1 + 70),
                             Temperature = Math.Floor(val1 + 5),
                             FeelsLike = val*5
                         });

                 }
                return details;
            }
        }

        public double calculateRandom(string average)
        {
            double value =0;
             Random rand = new Random();
                double random =  rand.Next(0,1);
            if (average =="Precipitation")
                value= Math.Floor(random*100 + 20);
            else if(average == "Sunlight")
                value= Math.Floor(random*12 + 2);
            else if(average == "Minimum Temperature" )
                value= Math.Floor(random*20 + 25);
            else if (average == "Maximum Temperature")
                value = Math.Floor(random * 30 + 25);
            else if(average =="Wind")
                 value= Math.Floor(random*15 +5);

            return value;
        }

        public List<WeatherDetails> AverageWeatherData
        {

            get
            {
               string[] Average = {"Precipitation", "Sunlight", "Minimum Temperature", "Maximum Temperature", "Wind"};
               List<WeatherDetails> details1 = new List<WeatherDetails>();
                WeatherDetails[] data = new WeatherDetails[6];
                
                
                
            for (var i = 0; i < 5; i++)
            {
                var monthValue = DateTime.Now.Month + i;
                string average = Average[i];
                data[i] = (new WeatherDetails() {Average = average, Jan = calculateRandom(average), Feb = calculateRandom(average)+2
                , Mar = calculateRandom(average)+5, Apl = calculateRandom(average)-1, May = calculateRandom(average)+1, Jun = calculateRandom(average)-3
                , Jul = calculateRandom(average)-5, Aug = calculateRandom(average)+4, Sep = calculateRandom(average)+2, Oct = calculateRandom(average)+5
                , Nov = calculateRandom(average)-3, Dec = calculateRandom(average)+6});
                details1.Add(data[i]);
            }
            return details1;
          }
    }
    }
}