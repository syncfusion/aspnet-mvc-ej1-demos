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

namespace MVCSampleBrowser.Areas.AirlineReservation.Models
{
    public class AirLineDetails
    {
        public string Airline { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Depart { get; set; }
        public double Arrive { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
    }

    public class AirLineData
    {   
        public List<AirLineDetails> GetAirLineDetails
        {
            get
            {
                List<AirLineDetails> dataArray = new List<AirLineDetails>();

                List<String> airwaysProvidersList = GetAirwaysProviders();
                List<String> citiesList = GetCities();
                Random rand = new Random();

                for (int cnt = 0; cnt < airwaysProvidersList.Count; cnt++)
                {
                    int fromIndex = rand.Next(citiesList.Count - 1);
                    int toIndex = rand.Next(citiesList.Count - 1);
                    if (fromIndex == toIndex)
                        toIndex = (toIndex + 1) > citiesList.Count - 1 ? 0 : toIndex + 1;

                    String airline = airwaysProvidersList[cnt];
                    String from = citiesList[fromIndex];
                    String to = citiesList[toIndex];
                    Double depart = GetTime(rand);
                    Double arrive = GetTime(rand);
                    int price = rand.Next(5000 - 400 + 1) + 400;
                    int rating = rand.Next(1,5);
                    dataArray.Add(new AirLineDetails()
                    {
                        Airline = airline,
                        From = from,
                        To = to,
                        Depart = depart,
                        Arrive = arrive,
                        Price = price,
                        Rating = rating
                    });
                }
                return dataArray;
            }
        }

        public List<String> GetAirwaysProviders()
        {
            return new List<string>()
            {
                "Aero Flot", "Aero Mexico", "Air NewZealand", "AirBerlin", "AirCanada", "AirFrance", "AirIndia", "AirMadagascar",
                "AirPhilipines", "AirTran", "AlaskaAirlines", "Alitalia", "Austrian", "Avianca", "British Airways", "Brussels Airlines",
                "CathayPacific", "China Airlines", "Continental Airlines", "Croatia Airlines", "Dragonair", "Delta", "Elal", "Emirates",
                "Ethiopian", "Garuda Indonesia", "Hawaiian", "Iberia", "IceLandAir", "Jal", "KLM", "KoreanAir", "Lan", "Lot", "Lufthansa",
                "Malaysia", "MidWest Airlines", "NWA", "Oceanic Airlines", "Qantas", "Sabena", "Singapore Airlines", "SouthAfrican Airways",
                "Spirit Airlines", "SriLankan Airlines", "SwissAir", "Tap", "Thai", "Turkish AirLines", "United Airlines", "Varig",
                "Vietnam Airlines", "Wideroe"
            };
        }

        public List<String> GetCities()
        {
            return new List<string>()
            {
                "Atlanta", "London", "Los Angeles", "Dallas", "Alexandria", "Paris", "Amsterdam", "Danver", "Madrid", "Houston", "HongKong", 
                "Minneapolis", "Detroit", "Bangkok", "SanFransisco", "Bandon", "Miami", "New york", "Singapore", "Tokyo", "Beijing", "Seattle",
                "Belize City", "Orlando", "Berlin", "Bishop", "Toronto", "Brownwood", "Saint Louis", "Chicago", "FrankFurt", "Madrid", "Las Vegas",
                "Phoenix", "Delhi", "Dubai", "Newark", "ROME", "Charlotte", "Munich", "Guangzhou", "Eureka", "Sydney", "Jakarta", "Philadelphia",
                "Barcelona", "Incheon", "Istanbul", "Shangai", "Kuala Lumpur", "Mexico", "Boston", "Melbourne", "Mumbai", "Dublin", "Palma De Mallorca",
                "Fort Lauderdale", "Zurich", "Manaila", "Taipei", "Copenhagen", "Manchester", "Shenzhen", "Sao paulo", "Baltimore MD", "Salt Lake City",
                "Moscow", "Vienna", "Oslo", "Millan", "Brisbane", "Antalya", "Honolulu", "Johannesburg", "Brussels", "Tampa FL", "Stockholm",
                "Dusseldorf","San Diego CA", "Vancouver", "Sapporo", "Washington", "Fukuoka", "Chengdu", "Athens", "Osaka", "Jeddah", "Naha",
                "St Louis MO", "Cairo", "Portland", "Seoul", "CinCinnati OH", "Lisbon", "Bogota", "Helsinki", "Hall Beach", "Eagle", "Easton", "Elkedra",
                "Finke", "Florenceh", "Franklin", "Fuyang", "Gangaw", "Gangneung", "Goa", "Greenville", "Indiana", "Inverway", "Itumbiara",
                "Kalgoorlieh", "Kambuaya", "Kasba Lake", "Kenora", "Kingston", "Queretaro", "Qiemo", "Quillayute", "Queenstown", "Quanduc", "Rafha",
                "Rajshahi", "Ramadan", "Ranong", "Redencao", "Richmond", "Ube", "Udine", "Union City", "Ulusaba", "Upland", "Valentine", "Vaasa",
                "Vadodara", "Varanasi", "Vejle", "Xiangfan", "Xingcheng", "Xining", "Xinguara", "Xayabury", "Yaroslavl", "Yeovilton", "Yonago",
                "Yorketown", "Zambezi", "Zahedan", "Zacatecas", "Zephyrhills", "Chennai"
            };
        }


        private double GetTime(Random rand)
        {
            double time = rand.Next(23) + 1;
            double minutes = rand.Next(59) + 1;
            return time + (minutes / 100);
        }
    }
}