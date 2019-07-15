#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript.DataVisualization.Maps;
using Syncfusion.JavaScript.DataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class MapsController : Controller
    {
        //
        // GET: /DaraMarker/

        public ActionResult Default()
        {
            ViewData["datasource"] = Syncfusion_LocationData.GetSyncfusionLocationData();
            ViewData["mapdata"] = this.GetWroldMap();

            return View();
        }
        public object GetWroldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }

    }

    public class Continent_SalesData
    {
        public static List<ContinentData> GetContinentSalesData()
        {
            List<ContinentData> contentSalesData = new List<ContinentData>
            {
                new ContinentData {Name = "Africa", Sales = 225100},
                new ContinentData {Name = "Antarctica", Sales = 104050},
                new ContinentData {Name = "Asia", Sales = 735900},
                new ContinentData {Name = "Europe", Sales = 630500},
                new ContinentData {Name = "North America", Sales = 562000},
                new ContinentData {Name = "Oceania", Sales = 206000},
                new ContinentData {Name = "South America", Sales = 473000},
            };
            return contentSalesData;
        }
    }

    public class ContinentData
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double sales;

        public double Sales
        {
            get { return sales; }
            set { sales = value; }
        }
    }

    public class World_PopulationData
    {
        public static List<PopulationData> GetWorldPopulationData()
        {
            List<PopulationData> worldPopulationData = new List<PopulationData>
            {
                new PopulationData {Name = "China", Population= 38556653 },
                new PopulationData {Name = "Japan", Population= 2714357 },
                new PopulationData {Name = "Papua New Guinea", Population= 32126 },
                new PopulationData {Name = "Jordan", Population= 27379 },
                new PopulationData {Name = "Bulgaria", Population= 22294 },
                new PopulationData {Name = "Togo", Population= 81698 },
                new PopulationData {Name = "Paraguay", Population= 80229 },
                new PopulationData {Name = "Laos", Population= 76972 },
                new PopulationData {Name = "El Salvador", Population= 34045 },
                new PopulationData {Name = "Eritrea", Population= 33313 },
                new PopulationData {Name = "Libya", Population= 20152 },
                new PopulationData {Name = "Sierra Leone", Population= 09207 },
                new PopulationData {Name = "Mexico", Population= 2233239 },
                new PopulationData {Name = "Nicaragua", Population= 08047 },
                new PopulationData {Name = "Denmark", Population= 61909 },
                new PopulationData {Name = "Kyrgyzstan", Population= 54754 },
                new PopulationData {Name = "Slovakia", Population= 45022 },
                new PopulationData {Name = "Finland", Population= 42632 },
                new PopulationData {Name = "Singapore", Population= 41173 },
                new PopulationData {Name = "Turkmenistan", Population= 24007 },
                new PopulationData {Name = "Norway", Population= 04267 },
                new PopulationData {Name = "Costa Rica", Population= 87216 },
                new PopulationData {Name = "Lebanon", Population= 82197 },
                new PopulationData {Name = "Philippines", Population= 839357 },
                new PopulationData {Name = "Ireland", Population= 62717 },
                new PopulationData {Name = "Central African Republic", Population= 61641 },
                new PopulationData {Name = "New Zealand", Population= 50576 },
                new PopulationData {Name = "Republic of Congo", Population= 44763 },
                new PopulationData {Name = "Georgia[6]", Population= 34089 },
                new PopulationData {Name = "Palestine[7]", Population= 32629 },
                new PopulationData {Name = "Liberia", Population= 29407 },
                new PopulationData {Name = "Croatia", Population= 28971 },
                new PopulationData {Name = "Mauritania", Population= 88988 },
                new PopulationData {Name = "Panama", Population= 86417 },
                new PopulationData {Name = "Ethiopia", Population= 410075 },
                new PopulationData {Name = "Bosnia and Herzegovina", Population= 82930 },
                new PopulationData {Name = "Oman", Population= 63244 },
                new PopulationData {Name = "Moldova[8]", Population= 48720 },
                new PopulationData {Name = "Uruguay", Population= 40706 },
                new PopulationData {Name = "Kuwait", Population= 36857 },
                new PopulationData {Name = "Albania", Population= 17327 },
                new PopulationData {Name = "Lithuania", Population= 01693 },
                new PopulationData {Name = "Armenia", Population= 97656 },
                new PopulationData {Name = "Mongolia", Population= 83907 },
                new PopulationData {Name = "Jamaica", Population= 78388 },
                new PopulationData {Name = "Vietnam", Population= 167973 },
                new PopulationData {Name = "Namibia", Population= 30331 },
                new PopulationData {Name = "Qatar", Population= 16867 },
                new PopulationData {Name = "Macedonia", Population= 10715 },
                new PopulationData {Name = "Lesotho", Population= 07446 },
                new PopulationData {Name = "Slovenia", Population= 07199 },
                new PopulationData {Name = "Latvia", Population= 05031 },
                new PopulationData {Name = "Botswana", Population= 02114 },
                new PopulationData {Name = "Gambia", Population= 84928 },
                new PopulationData {Name = "Guinea-Bissau", Population= 70425 },
                new PopulationData {Name = "Gabon", Population= 67171 },
                new PopulationData {Name = "Germany", Population= 272662 },
                new PopulationData {Name = "Trinidad and Tobago", Population= 34115 },
                new PopulationData {Name = "Bahrain", Population= 33217 },
                new PopulationData {Name = "Estonia", Population= 28725 },
                new PopulationData {Name = "Swaziland", Population= 24951 },
                new PopulationData {Name = "Mauritius", Population= 24440 },
                new PopulationData {Name = "Cyprus[9]", Population= 14116 },
                new PopulationData {Name = "Timor-Leste", Population= 13287 },
                new PopulationData {Name = "Fiji", Population= 8106 },
                new PopulationData {Name = "Djibouti", Population= 7293 },
                new PopulationData {Name = "Guyana", Population= 9961 },
                new PopulationData {Name = "Egypt", Population= 205637 },
                new PopulationData {Name = "Equatorial Guinea", Population= 5701 },
                new PopulationData {Name = "Bhutan", Population= 5394 },
                new PopulationData {Name = "Comoros", Population= 3491 },
                new PopulationData {Name = "Montenegro", Population= 2138 },
                new PopulationData {Name = "Solomon Islands", Population= 6123 },
                new PopulationData {Name = "Suriname", Population= 3927 },
                new PopulationData {Name = "Luxembourg", Population= 3038 },
                new PopulationData {Name = "Cape Verde", Population= 9889 },
                new PopulationData {Name = "Malta", Population= 2900 },
                new PopulationData {Name = "Brunei", Population= 1778 },
                new PopulationData {Name = "Iran", Population= 744716 },
                new PopulationData {Name = "Bahamas", Population= 7737 },
                new PopulationData {Name = "Maldives", Population= 4502 },
                new PopulationData {Name = "Belize", Population= 3190 },
                new PopulationData {Name = "Iceland", Population= 2953 },
                new PopulationData {Name = "Barbados", Population= 8464 },
                new PopulationData {Name = "Vanuatu", Population= 5276 },
                new PopulationData {Name = "São Tomé and Príncipe", Population= 9299 },
                new PopulationData {Name = "Samoa", Population= 9037 },
                new PopulationData {Name = "Saint Lucia", Population= 8227 },
                new PopulationData {Name = "Saint Vincent and the Grenadines", Population= 0937 },
                new PopulationData {Name = "Turkey", Population= 493264 },
                new PopulationData {Name = "Grenada", Population= 0589 },
                new PopulationData {Name = "Tonga", Population= 0532 },
                new PopulationData {Name = "Micronesia Federated States of", Population= 0354 },
                new PopulationData {Name = "Kiribati", Population= 0235 },
                new PopulationData {Name = "Seychelles", Population= 283 },
                new PopulationData {Name = "Antigua and Barbuda", Population= 998 },
                new PopulationData {Name = "Andorra", Population= 921 },
                new PopulationData {Name = "Dominica", Population= 200 },
                new PopulationData {Name = "Saint Kitts and Nevis", Population= 419 },
                new PopulationData {Name = "Marshall Islands", Population= 263 },
                new PopulationData {Name = "The Democratic Republic of the Congo", Population= 751367 },
                new PopulationData {Name = "Monaco", Population= 783 },
                new PopulationData {Name = "Liechtenstein", Population= 692 },
                new PopulationData {Name = "San Marino", Population= 144 },
                new PopulationData {Name = "Palau", Population= 091 },
                new PopulationData {Name = "Nauru", Population= 005 },
                new PopulationData {Name = "Tuvalu", Population= 87 },
                new PopulationData {Name = " Vatican City[12]", Population= 9 },
                new PopulationData {Name = "India", Population= 25213959 },
                new PopulationData {Name = "Thailand", Population= 701050 },
                new PopulationData {Name = "France", Population= 429128 },
                new PopulationData {Name = "United Kingdom", Population= 313626 },
                new PopulationData {Name = "Italy", Population= 099027 },
                new PopulationData {Name = "Myanmar", Population= 325901 },
                new PopulationData {Name = "South Africa", Population= 277613 },
                new PopulationData {Name = "Korea South", Population= 926269 },
                new PopulationData {Name = "Tanzania", Population= 925312 },
                new PopulationData {Name = "Colombia", Population= 832140 },
                new PopulationData {Name = "Spain", Population= 692696 },
                new PopulationData {Name = "United States", Population= 2005071 },
                new PopulationData {Name = "Ukraine", Population= 523880 },
                new PopulationData {Name = "Kenya", Population= 435369 },
                new PopulationData {Name = "Argentina", Population= 144624 },
                new PopulationData {Name = "Algeria", Population= 920819 },
                new PopulationData {Name = "Poland", Population= 821663 },
                new PopulationData {Name = "Sudan", Population= 796430 },
                new PopulationData {Name = "Uganda", Population= 757887 },
                new PopulationData {Name = "Canada", Population= 518170 },
                new PopulationData {Name = "Iraq", Population= 376523 },
                new PopulationData {Name = "Morocco", Population= 300815 },
                new PopulationData {Name = "Indonesia", Population= 4986563 },
                new PopulationData {Name = "Afghanistan", Population= 055167 },
                new PopulationData {Name = "Venezuela", Population= 040520 },
                new PopulationData {Name = "Peru", Population= 037560 },
                new PopulationData {Name = "Malaysia", Population= 971696 },
                new PopulationData {Name = "Uzbekistan", Population= 893410 },
                new PopulationData {Name = "Saudi Arabia", Population= 882887 },
                new PopulationData {Name = "Nepal", Population= 779745 },
                new PopulationData {Name = "Ghana", Population= 590459 },
                new PopulationData {Name = "Mozambique", Population= 583375 },
                new PopulationData {Name = "Korea North", Population= 489548 },
                new PopulationData {Name = "Brazil", Population= 0036192 },
                new PopulationData {Name = "Yemen", Population= 440738 },
                new PopulationData {Name = "Australia", Population= 334255 },
                new PopulationData {Name = "Taiwan", Population= 332977 },
                new PopulationData {Name = "Madagascar", Population= 292485 },
                new PopulationData {Name = "Cameroon", Population= 225395 },
                new PopulationData {Name = "Syria", Population= 189806 },
                new PopulationData {Name = "Romania", Population= 169858 },
                new PopulationData {Name = "Angola", Population= 147161 },
                new PopulationData {Name = "Sri Lanka", Population= 127322 },
                new PopulationData {Name = "Côte d'Ivoire", Population= 031608 },
                new PopulationData {Name = "Pakistan", Population= 8214259 },
                new PopulationData {Name = "Niger", Population= 783127 },
                new PopulationData {Name = "Chile", Population= 761970 },
                new PopulationData {Name = "Burkina Faso", Population= 693483 },
                new PopulationData {Name = "Netherlands", Population= 675922 },
                new PopulationData {Name = "Kazakhstan", Population= 644058 },
                new PopulationData {Name = "Malawi", Population= 636256 },
                new PopulationData {Name = "Ecuador", Population= 573787 },
                new PopulationData {Name = "Guatemala", Population= 546820 },
                new PopulationData {Name = "Mali", Population= 530165 },
                new PopulationData {Name = "Cambodia", Population= 513516 },
                new PopulationData {Name = "Nigeria", Population= 7361534 },
                new PopulationData {Name = "Zambia", Population= 453864 },
                new PopulationData {Name = "Zimbabwe", Population= 414964 },
                new PopulationData {Name = "Senegal", Population= 413328 },
                new PopulationData {Name = "Chad", Population= 282531 },
                new PopulationData {Name = "Rwanda", Population= 177652 },
                new PopulationData {Name = "Guinea", Population= 174518 },
                new PopulationData {Name = "South Sudan", Population= 129617 },
                new PopulationData {Name = "Cuba", Population= 126562 },
                new PopulationData {Name = "Greece", Population= 112799 },
                new PopulationData {Name = "Belgium", Population= 110447 },
                new PopulationData {Name = "Bangladesh", Population= 5659496 },
                new PopulationData {Name = "Tunisia", Population= 099651 },
                new PopulationData {Name = "Czech Republic", Population= 070219 },
                new PopulationData {Name = "Bolivia", Population= 067120 },
                new PopulationData {Name = "Portugal", Population= 060815 },
                new PopulationData {Name = "Somalia", Population= 049558 },
                new PopulationData {Name = "Dominican Republic", Population= 040376 },
                new PopulationData {Name = "Benin", Population= 032347 },
                new PopulationData {Name = "Haiti", Population= 031746 },
                new PopulationData {Name = "Burundi", Population= 016253 },
                new PopulationData {Name = "Hungary", Population= 95494 },
                new PopulationData {Name = "Russia", Population= 4283368 },
                new PopulationData {Name = "Sweden", Population= 57110 },
                new PopulationData {Name = "Serbia &  Kosovo", Population= 51050 },
                new PopulationData {Name = "Azerbaijan", Population= 41342 },
                new PopulationData {Name = "Belarus", Population= 35667 },
                new PopulationData {Name = "United Arab Emirates", Population= 34612 },
                new PopulationData {Name = "Austria", Population= 49514 },
                new PopulationData {Name = "Tajikistan", Population= 20783 },
                new PopulationData {Name = "Honduras", Population= 09768 },
                new PopulationData {Name = "Switzerland", Population= 07783 },
                new PopulationData {Name = "Israel", Population= 73314 },
                new PopulationData {Name = "Greenland", Population= 684 },
                new PopulationData {Name = "Svalbard and Jan Mayen", Population= 64 }


            };
            return worldPopulationData;
        }
    }

    public class PopulationData
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double population;

        public double Population
        {
            get { return population; }
            set { population = value; }
        }
    }

    public class Election_Result
    {
        public static List<CountyPopulationData> GetUSPopulationData()
        {
            List<CountyPopulationData> populationData = new List<CountyPopulationData>
            {
                new CountyPopulationData(){ Name= "California", Population=38332521},
new CountyPopulationData(){ Name= "Texas", Population=26448193},
new CountyPopulationData(){ Name= "New York", Population=19651127},
new CountyPopulationData(){ Name= "Florida", Population=19552860},
new CountyPopulationData(){ Name= "Illinois", Population=12882135},
new CountyPopulationData(){ Name= "Pennsylvania", Population=12773801},
new CountyPopulationData(){ Name= "Ohio", Population=11570808},
new CountyPopulationData(){ Name= "Georgia", Population=9992167},
new CountyPopulationData(){ Name= "Michigan", Population=9895622},
new CountyPopulationData(){ Name= "North Carolina", Population=9848060},
new CountyPopulationData(){ Name= "New Jersey", Population=8899339},
new CountyPopulationData(){ Name= "Virginia", Population=8260405},
new CountyPopulationData(){ Name= "Washington", Population=6971406},
new CountyPopulationData(){ Name= "Massachusetts", Population=6692824},
new CountyPopulationData(){ Name= "Arizona", Population=6626624},
new CountyPopulationData(){ Name= "Indiana", Population=6570902},
new CountyPopulationData(){ Name= "Tennessee", Population=6495978},
new CountyPopulationData(){ Name= "Missouri", Population=6044171},
new CountyPopulationData(){ Name= "Maryland", Population=5928814},
new CountyPopulationData(){ Name= "Wisconsin", Population=5742713},
new CountyPopulationData(){ Name= "Minnesota", Population=5420380},
new CountyPopulationData(){ Name= "Colorado", Population=5268367},
new CountyPopulationData(){ Name= "Alabama", Population=4833722},
new CountyPopulationData(){ Name= "South Carolina", Population=4774839},
new CountyPopulationData(){ Name= "Louisiana", Population=4625470},
new CountyPopulationData(){ Name= "Kentucky", Population=4395295},
new CountyPopulationData(){ Name= "Oregon", Population=3930065},
new CountyPopulationData(){ Name= "Oklahoma", Population=3850568},
new CountyPopulationData(){ Name= "Puerto Rico", Population=3615086},
new CountyPopulationData(){ Name= "Connecticut", Population=3596080},
new CountyPopulationData(){ Name= "Iowa", Population=3090416},
new CountyPopulationData(){ Name= "Mississippi", Population=2991207},
new CountyPopulationData(){ Name= "Arkansas", Population=2959373},
new CountyPopulationData(){ Name= "Utah", Population=2900872},
new CountyPopulationData(){ Name= "Kansas", Population=2893957},
new CountyPopulationData(){ Name= "Nevada", Population=2790136},
new CountyPopulationData(){ Name= "New Mexico", Population=2085287},
new CountyPopulationData(){ Name= "Nebraska", Population=1868516},
new CountyPopulationData(){ Name= "West Virginia", Population=1854304},
new CountyPopulationData(){ Name= "Idaho", Population=1612136},
new CountyPopulationData(){ Name= "Hawaii", Population=1404054},
new CountyPopulationData(){ Name= "Maine", Population=1328302},
new CountyPopulationData(){ Name= "New Hampshire", Population=1323459},
new CountyPopulationData(){ Name= "Rhode Island", Population=1051511},
new CountyPopulationData(){ Name= "Montana", Population=1015165},
new CountyPopulationData(){ Name= "Delaware", Population=925749},
new CountyPopulationData(){ Name= "South Dakota", Population=844877},
new CountyPopulationData(){ Name= "Alaska", Population=735132},
new CountyPopulationData(){ Name= "North Dakota", Population=723393},
new CountyPopulationData(){ Name= "District of Columbia", Population=646449},
new CountyPopulationData(){ Name= "Vermont", Population=626630},
new CountyPopulationData(){ Name= "Wyoming", Population=582658}
            };



            return populationData;
        }
              
        
        public static List<ElectionData> GetElectionResults()
        {
            List<ElectionData> electionResults = new List<ElectionData>
            {
                  
                new ElectionData {State = "Alabama", Candidate = "Romney", Electors = 9 },
                new ElectionData { State = "Alaska", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Arizona", Candidate = "Romney", Electors = 11 },
                new ElectionData { State = "Arkansas", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "California", Candidate = "Obama", Electors = 55 },
                new ElectionData { State = "Colorado", Candidate = "Obama", Electors = 9 },
                new ElectionData { State = "Connecticut", Candidate = "Obama", Electors = 7 },
                new ElectionData { State = "Delaware", Candidate = "Obama", Electors = 3 },
                new ElectionData { State = "District of Columbia", Candidate = "Obama", Electors = 3 },
                new ElectionData { State = "Florida", Candidate = "Obama", Electors = 29 },
                new ElectionData { State = "Georgia", Candidate = "Romney", Electors = 16 },
                new ElectionData { State = "Hawaii", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "Idaho", Candidate = "Romney", Electors = 4 },
                new ElectionData { State = "Illinois", Candidate = "Obama", Electors = 20 },
                new ElectionData { State = "Indiana", Candidate = "Romney", Electors = 11 },
                new ElectionData { State = "Iowa", Candidate = "Obama", Electors = 6 },
                new ElectionData { State = "Kansas", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "Kentucky", Candidate = "Romney", Electors = 8 },
                new ElectionData { State = "Louisiana", Candidate = "Romney", Electors = 8 },
                new ElectionData { State = "Maine", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "Maryland", Candidate = "Obama", Electors = 10 },
                new ElectionData { State = "Massachusetts", Candidate = "Obama", Electors = 11 },
                new ElectionData { State = "Michigan", Candidate = "Obama", Electors = 16 },
                new ElectionData { State = "Minnesota", Candidate = "Obama", Electors = 10 },
                new ElectionData { State = "Mississippi", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "Missouri", Candidate = "Romney", Electors = 10 },
                new ElectionData { State = "Montana", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Nebraska", Candidate = "Romney", Electors = 5 },
                new ElectionData { State = "Nevada", Candidate = "Obama", Electors = 6 },
                new ElectionData { State = "New Hampshire", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "New Jersey", Candidate = "Obama", Electors = 14 },
                new ElectionData { State = "New Mexico", Candidate = "Obama", Electors = 5 },
                new ElectionData { State = "New York", Candidate = "Obama", Electors = 29 },
                new ElectionData { State = "North Carolina", Candidate = "Romney", Electors = 15 },
                new ElectionData { State = "North Dakota", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Ohio", Candidate = "Obama", Electors = 18 },
                new ElectionData { State = "Oklahoma", Candidate = "Romney", Electors = 7 },
                new ElectionData { State = "Oregon", Candidate = "Obama", Electors = 7 },
                new ElectionData { State = "Pennsylvania", Candidate = "Obama", Electors = 20 },
                new ElectionData { State = "Rhode Island", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "South Carolina", Candidate = "Romney", Electors = 9 },
                new ElectionData { State = "South Dakota", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Tennessee", Candidate = "Romney", Electors = 11 },
                new ElectionData { State = "Texas", Candidate = "Romney", Electors = 38 },
                new ElectionData { State = "Utah", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "Vermont", Candidate = "Obama", Electors = 3 },
                new ElectionData { State = "Virginia", Candidate = "Obama", Electors = 13 },
                new ElectionData { State = "Washington", Candidate = "Obama", Electors = 12 },
                new ElectionData { State = "West Virginia", Candidate = "Romney", Electors = 5 },
                new ElectionData { State = "Wisconsin", Candidate = "Obama", Electors = 10 },
                new ElectionData { State = "Wyoming", Candidate = "Romney", Electors = 3 }
            };
            return electionResults;
        }
    }

    public class ElectionData
    {
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string candidate;
        public string Candidate
        {
            get { return candidate; }
            set { candidate = value; }
        }

        private double electors;
        public double Electors
        {
            get { return electors; }
            set { electors = value; }
        }
    }

    public class CountyPopulationData
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double population;

        public double Population
        {
            get { return population; }
            set { population = value; }
        }
    }

    public class Syncfusion_LocationData
    {
        public static List<MapMarker> GetSyncfusionLocationData()
        {
            List<MapMarker> syncfusionLocationData = new List<MapMarker>
            {
                new LocationData {Name = "USA", Latitude =38.8833 , Longitude = -77.0167 },
                new LocationData {Name = "Brazil", Latitude =-15.7833 , Longitude = -47.8667 },
				new LocationData {Name = "India", Latitude =21.0000 , Longitude = 78.0000 },
				new LocationData {Name = "China", Latitude =35.0000 , Longitude = 103.0000 },
				new LocationData {Name = "Indonesia", Latitude =-6.1750 , Longitude = 106.8283 },										
            };
            return syncfusionLocationData;
        }
    }

    public class LocationData : MapMarker
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

       
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }

    public class World_FlightData
    {
        public static List<FlightData> GetAirportData()
        {
            List<FlightData> airportData = new List<FlightData>
            {
                new FlightData { Name = "Durham Int'l Airport", From = "Raleigh", To = "Chennai", Abbrev = "RDU", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "IAD", Route1_Stop2 = "FRA", Route2_Stop1 = "JFK", Route2_Stop2 = "DXB", Route3_Stop1 = "ATL", Route3_Stop2 = "DXB"},
                new FlightData { Name = "Chennai Int' Airport", From = "Chennai", To = "Raleigh", Abbrev = "MAA", Departure = "MAA", Arrival = "RDU", Route1_Stop1 = "FRA", Route1_Stop2 = "IAD", Route2_Stop1 = "DXB", Route2_Stop2 = "JFK", Route3_Stop1 = "DXB", Route3_Stop2 = "ATL"}
            };
            return airportData;
        }

        public static List<FlightData> GetIntermediateStops1_Data()
        {
            List<FlightData> intermediatestops1_data = new List<FlightData>
            {
                new FlightData {Name = "Dulles Int'l Airport", From = "Raleigh", To = "Chennai", Intermediate =  "Washington", Abbrev =  "IAD", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "IAD", Route1_Stop2 = "FRA" },
                new FlightData {Name = "Frankfurt Int'l Airport", From = "Chennai", To = "Raleigh", Intermediate =  "Frankfurt", Abbrev =  "FRA", Departure = "MAA", Arrival = "RDU", Route1_Stop1 = "FRA", Route1_Stop2 = "IAD" },
                new FlightData { Name = "Atlanta Int'l Airport", From = "Raleigh", To = "Chennai", Intermediate =  "Atlanta", Abbrev =  "ATL", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "ATL", Route1_Stop2 = "DXB" },
                new FlightData { Name = "John F Kennedy Int'l Airport", From = "Raleigh", To = "Chennai", Intermediate =  "Newyork", Abbrev =  "JFK", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "JFK", Route1_Stop2 = "DXB" }
            };
            return intermediatestops1_data;
        }

        public static List<FlightData> GetIntermediateStops2_Data()
        {
            List<FlightData> intermediatestops2_data = new List<FlightData>
            {
                new FlightData { Name = "Dubai Int'l Airport", From = "Chennai", To = "Raleigh", Intermediate =  "Dubai", Abbrev =  "DXB", Departure = "MAA", Arrival = "RDU", Route1_Stop1 = "DXB", Route1_Stop2 = "JFK", Route2_Stop1 = "DXB", Route2_Stop2 = "ATL" }
            };
            return intermediatestops2_data;
        }

        public static List<FlightData> GetFlightRoutes_Data()
        {
            List<FlightData> flightroutes_data = new List<FlightData>
            {
                new FlightData { Name = "Route4", Abbrev =  "RDU", From = "Raleigh", To = "Chennai", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "ATL", Route1_Stop2 = "DXB" },
                new FlightData { Name = "Route5", Abbrev =  "RDU", From = "Raleigh", To = "Chennai", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "ATL", Route1_Stop2 = "DXB" },
                new FlightData { Name = "Route6", Abbrev =  "RDU", From = "Raleigh", To = "Chennai", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "ATL", Route1_Stop2 = "DXB" },
                new FlightData { Name = "Route7", Abbrev =  "RDU", From = "Raleigh", To = "Chennai", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "JFK", Route1_Stop2 = "DXB" },
                new FlightData { Name = "Route8", Abbrev =  "RDU", From = "Raleigh", To = "Chennai", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "JFK", Route1_Stop2 = "DXB" },
                new FlightData { Name = "Route9", Abbrev =  "RDU", From = "Raleigh", To = "Chennai", Departure = "RDU", Arrival = "MAA", Route1_Stop1 = "JFK", Route1_Stop2 = "DXB" },
                new FlightData { Name = "Route10", Abbrev =  "MAA", From = "Chennai", To = "Raleigh", Departure = "MAA", Arrival = "RDU", Route1_Stop1 = "FRA", Route1_Stop2 = "IAD" },
                new FlightData { Name = "Route11", Abbrev =  "MAA", From = "Chennai", To = "Raleigh", Departure = "MAA", Arrival = "RDU", Route1_Stop1 = "FRA", Route1_Stop2 = "IAD" },
                new FlightData { Name = "Route12", Abbrev =  "MAA", From = "Chennai", To = "Raleigh", Departure = "MAA", Arrival = "RDU", Route1_Stop1 = "FRA", Route1_Stop2 = "IAD" }

            };
            return flightroutes_data;
        }
    }

    public class FlightData
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string to;

        public string To
        {
            get { return to; }
            set { to = value; }
        }

        private string abbrev;

        public string Abbrev
        {
            get { return abbrev; }
            set { abbrev = value; }
        }

        private string departure;

        public string Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        private string arrival;

        public string Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }

        private string route1_stop1;

        public string Route1_Stop1
        {
            get { return route1_stop1; }
            set { route1_stop1 = value; }
        }

        private string route1_stop2;

        public string Route1_Stop2
        {
            get { return route1_stop2; }
            set { route1_stop2 = value; }
        }

        private string route2_stop1;

        public string Route2_Stop1
        {
            get { return route2_stop1; }
            set { route2_stop1 = value; }
        }

        private string route2_stop2;

        public string Route2_Stop2
        {
            get { return route2_stop2; }
            set { route2_stop2 = value; }
        }

        private string route3_stop1;

        public string Route3_Stop1
        {
            get { return route3_stop1; }
            set { route3_stop1 = value; }
        }

        private string route3_stop2;

        public string Route3_Stop2
        {
            get { return route3_stop2; }
            set { route3_stop2 = value; }
        }
        private string intermediate;

        public string Intermediate
        {
            get { return intermediate; }
            set { intermediate = value; }
        }
    }

    public class Country_LatLongPoints
    {
        public static List<LatLongPoints> GetCountryLatLongPoints()
        {
            List<LatLongPoints> countryLatLongPoints = new List<LatLongPoints>
            {
                new LatLongPoints {Name = "Afghanistan", Latitude = 33, Longitude = 65 },
                new LatLongPoints {Name = "Albania", Latitude = 41, Longitude = 20 },
                new LatLongPoints {Name = "Algeria", Latitude = 28, Longitude = 3 },
                new LatLongPoints {Name = "Angola", Latitude = -12.5, Longitude = 18.5 },
                new LatLongPoints {Name = "Anguilla", Latitude = 18.25, Longitude = -63.1667 },
                new LatLongPoints {Name = "Argentina", Latitude = -34, Longitude = -64 },
                new LatLongPoints {Name = "Armenia", Latitude = 40, Longitude = 45 },
                new LatLongPoints {Name = "Australia", Latitude = -27, Longitude = 133 },
                new LatLongPoints {Name = "Austria", Latitude = 47.3333, Longitude = 13.3333 },
                new LatLongPoints {Name = "Azerbaijan", Latitude = 40.5, Longitude = 47.5 },
                new LatLongPoints {Name = "Bahamas", Latitude = 24.25, Longitude = -76 },
                new LatLongPoints {Name = "Bangladesh", Latitude = 24, Longitude = 90 },
                new LatLongPoints {Name = "Belarus", Latitude = 53, Longitude = 28 },
                new LatLongPoints {Name = "Belgium", Latitude = 50.8333, Longitude = 4 },
                new LatLongPoints {Name = "Belize", Latitude = 17.25, Longitude = -88.75 },
                new LatLongPoints {Name = "Benin", Latitude = 9.5, Longitude = 2.25 },
                new LatLongPoints {Name = "Bhutan", Latitude = 27.5, Longitude = 90.5 },
                new LatLongPoints {Name = "Bolivia", Latitude = -17, Longitude = -65 },
                new LatLongPoints {Name = "Bosnia and Herzegovina", Latitude = 44, Longitude = 18 },
                new LatLongPoints {Name = "Botswana", Latitude = -22, Longitude = 24 },
                new LatLongPoints {Name = "Brazil", Latitude = -10, Longitude = -55 },
                new LatLongPoints {Name = "Brunei", Latitude = 4.5, Longitude = 114.6667 },
                new LatLongPoints {Name = "Bulgaria", Latitude = 43, Longitude = 25 },
                new LatLongPoints {Name = "Burkina Faso", Latitude = 13, Longitude = -2 },
                new LatLongPoints {Name = "Burundi", Latitude = -3.5, Longitude = 30 },
                new LatLongPoints {Name = "Cambodia", Latitude = 13, Longitude = 105 },
                new LatLongPoints {Name = "Cameroon", Latitude = 6, Longitude = 12 },
                new LatLongPoints {Name = "Canada", Latitude = 60, Longitude = -95 },
                new LatLongPoints {Name = "Central African Republic", Latitude = 7, Longitude = 21 },
                new LatLongPoints {Name = "Chad", Latitude = 15, Longitude = 19 },
                new LatLongPoints {Name = "Chile", Latitude = -30, Longitude = -71 },
                new LatLongPoints {Name = "China", Latitude = 35, Longitude = 105 },
                new LatLongPoints {Name = "Cocos (Keeling) Islands", Latitude = -12.5, Longitude = 96.8333 },
                new LatLongPoints {Name = "Colombia", Latitude = 4, Longitude = -72 },
                new LatLongPoints {Name = "Congo", Latitude = -1, Longitude = 15 },
                new LatLongPoints {Name = "Costa Rica", Latitude = 10, Longitude = -84 },
                new LatLongPoints {Name = "Cuba", Latitude = 21.5, Longitude = -80 },
                new LatLongPoints {Name = "Czech Republic", Latitude = 49.75, Longitude = 15.5 },
                new LatLongPoints {Name = "Denmark", Latitude = 56, Longitude = 10 },
                new LatLongPoints {Name = "Djibouti", Latitude = 11.5, Longitude = 43 },
                new LatLongPoints {Name =  "Dominica", Latitude = 15.4167, Longitude = -61.3333 },
                new LatLongPoints {Name =  "Dominican Republic", Latitude = 19, Longitude = -70.6667 },
                new LatLongPoints {Name =  "East Timor", Latitude = 0, Longitude = 0 },
                new LatLongPoints {Name = "Ecuador", Latitude = -2, Longitude = -77.5 },
                new LatLongPoints {Name = "Egypt", Latitude = 27, Longitude = 30 },
                new LatLongPoints {Name = "El Salvador", Latitude = 13.8333, Longitude = -88.9167 },
                new LatLongPoints {Name = "Equatorial Guinea", Latitude = 2, Longitude = 10 },
                new LatLongPoints {Name = "Eritrea", Latitude = 15, Longitude = 39 },
                new LatLongPoints {Name = "Estonia", Latitude = 59, Longitude = 26 },
                new LatLongPoints {Name = "Ethiopia", Latitude = 8, Longitude = 38 },
                new LatLongPoints {Name = "Fiji", Latitude = -18, Longitude = 175 },
                new LatLongPoints {Name = "Finland", Latitude = 64, Longitude = 26 },
                new LatLongPoints {Name = "France", Latitude = 46, Longitude = 2 },
                new LatLongPoints {Name = "French Guiana", Latitude = 4, Longitude = -53 },
                new LatLongPoints {Name = "French Polynesia", Latitude = -15, Longitude = -140 },
                new LatLongPoints {Name = "Gabon", Latitude = -1, Longitude = 11.75 },
                new LatLongPoints {Name = "Georgia", Latitude = 42, Longitude = 43.5 },
                new LatLongPoints {Name = "Germany", Latitude = 51, Longitude = 9 },
                new LatLongPoints {Name = "Ghana", Latitude = 8, Longitude = -2 },
                new LatLongPoints {Name = "Greece", Latitude = 39, Longitude = 22 },
                new LatLongPoints {Name = "Greenland", Latitude = 72, Longitude = -40 },
                new LatLongPoints {Name = "Guatemala", Latitude = 15.5, Longitude = -90.25 },
                new LatLongPoints {Name = "Guinea", Latitude = 11, Longitude = -10 },
                new LatLongPoints {Name = "Guinea-Bissau", Latitude = 12, Longitude = -15 },
                new LatLongPoints {Name = "Guyana", Latitude = 5, Longitude = -59 },
                new LatLongPoints {Name = "Haiti", Latitude = 19, Longitude = -72.4167 },
                new LatLongPoints {Name = "Honduras", Latitude = 15, Longitude = -86.5 },
                new LatLongPoints {Name = "Hungary", Latitude = 47, Longitude = 20 },
                new LatLongPoints {Name = "Iceland", Latitude = 65, Longitude = -18 },
                new LatLongPoints {Name = "India", Latitude = 20, Longitude = 77 },
                new LatLongPoints {Name = "Indonesia", Latitude = -5, Longitude = 120 },
                new LatLongPoints {Name = "Iran", Latitude = 32, Longitude = 53 },
                new LatLongPoints {Name = "Iraq", Latitude = 33, Longitude = 44 },
                new LatLongPoints {Name = "Ireland", Latitude = 53, Longitude = -8 },
                new LatLongPoints {Name = "Israel", Latitude = 31.5, Longitude = 34.75 },
                new LatLongPoints {Name = "Italy", Latitude = 42.8333, Longitude = 12.8333 },
                new LatLongPoints {Name = "Jamaica", Latitude = 18.25, Longitude = -77.5 },
                new LatLongPoints {Name = "Japan", Latitude = 36, Longitude = 138 },
                new LatLongPoints {Name = "Jordan", Latitude = 31, Longitude = 36 },
                new LatLongPoints {Name = "Kazakhstan", Latitude = 48, Longitude = 68 },
                new LatLongPoints {Name = "Kenya", Latitude = 1, Longitude = 38 },
                new LatLongPoints {Name = "Korea", Latitude = 40, Longitude = 127 },
                new LatLongPoints {Name = "Kuwait", Latitude = 29.3375, Longitude = 47.6581 },
                new LatLongPoints {Name = "Kyrgyzstan", Latitude = 41, Longitude = 75 },
                new LatLongPoints {Name = "Latvia", Latitude = 57, Longitude = 25 },
                new LatLongPoints {Name = "Lebanon", Latitude = 33.8333, Longitude = 35.8333 },
                new LatLongPoints {Name = "Lesotho", Latitude = -29.5, Longitude = 28.5 },
                new LatLongPoints {Name = "Liberia", Latitude = 6.5, Longitude = -9.5 },
                new LatLongPoints {Name = "Lithuania", Latitude = 56, Longitude = 24 },
                new LatLongPoints {Name = "Macedonia", Latitude = 41.8333, Longitude = 22 },
                new LatLongPoints {Name = "Madagascar", Latitude = -20, Longitude = 47 },
                new LatLongPoints {Name = "Malawi", Latitude = -13.5, Longitude = 34 },
                new LatLongPoints {Name = "Malaysia", Latitude = 2.5, Longitude = 112.5 },
                new LatLongPoints {Name = "Maldives", Latitude = 3.25, Longitude = 73 },
                new LatLongPoints {Name = "Mali", Latitude = 17, Longitude = -4 },
                new LatLongPoints {Name = "Martinique", Latitude = 14.6667, Longitude = -61 },
                new LatLongPoints {Name = "Mauritania", Latitude = 20, Longitude = -12 },
                new LatLongPoints {Name = "Mexico", Latitude = 23, Longitude = -102 },
                new LatLongPoints {Name = "Moldova", Latitude = 47, Longitude = 29 },
                new LatLongPoints {Name = "Mongolia", Latitude = 46, Longitude = 105 },
                new LatLongPoints {Name = "Morocco", Latitude = 32, Longitude = -5 },
                new LatLongPoints {Name = "Mozambique", Latitude = -18.25, Longitude = 35 },
                new LatLongPoints {Name = "Myanmar", Latitude = 22, Longitude = 98 },
                new LatLongPoints {Name = "Namibia", Latitude = -22, Longitude = 17 },
                new LatLongPoints {Name = "Nepal", Latitude = 28, Longitude = 84 },
                new LatLongPoints {Name = "Netherlands", Latitude = 52.5, Longitude = 5.75 },
                new LatLongPoints {Name = "New Caledonia", Latitude = -21.5, Longitude = 165.5 },
                new LatLongPoints {Name = "New Zealand", Latitude = -41, Longitude = 174 },
                new LatLongPoints {Name = "Nicaragua", Latitude = 13, Longitude = -85 },
                new LatLongPoints {Name = "Niger", Latitude = 16, Longitude = 8 },
                new LatLongPoints {Name = "Nigeria", Latitude = 10, Longitude = 8 },
                new LatLongPoints {Name = "Norway", Latitude = 62, Longitude = 10 },
                new LatLongPoints {Name = "Oman", Latitude = 21, Longitude = 57 },
                new LatLongPoints {Name = "Pakistan", Latitude = 30, Longitude = 70 },
                new LatLongPoints {Name = "Panama", Latitude = 9, Longitude = -80 },
                new LatLongPoints {Name = "Papua New Guinea", Latitude = -6, Longitude = 147 },
                new LatLongPoints {Name = "Paraguay", Latitude = -23, Longitude = -58 },
                new LatLongPoints {Name = "Philippines", Latitude = 13, Longitude = 122 },
                new LatLongPoints {Name = "Poland", Latitude = 52, Longitude = 20 },
                new LatLongPoints {Name = "Portugal", Latitude = 39.5, Longitude = -8 },
                new LatLongPoints {Name = "Puerto Rico", Latitude = 18.25, Longitude = -66.5 },
                new LatLongPoints {Name = "Qatar", Latitude = 25.5, Longitude = 51.25 },
                new LatLongPoints {Name = "Romania", Latitude = 46, Longitude = 25 },
                new LatLongPoints {Name = "Russia", Latitude = 60, Longitude = 100 },
                new LatLongPoints {Name = "Rwanda", Latitude = -2, Longitude = 30 },
                new LatLongPoints {Name = "Sao Tome and Principe", Latitude = 1, Longitude = 7 },
                new LatLongPoints {Name = "Saudi Arabia", Latitude = 25, Longitude = 45 },
                new LatLongPoints {Name = "Senegal", Latitude = 14, Longitude = -14 },
                new LatLongPoints {Name = "Slovenia", Latitude = 46, Longitude = 15 },
                new LatLongPoints {Name = "Somalia", Latitude = 10, Longitude = 49 },
                new LatLongPoints {Name = "South Africa", Latitude = -29, Longitude = 24 },
                new LatLongPoints {Name = "Spain", Latitude = 40, Longitude = -4 },
                new LatLongPoints {Name = "Sri Lanka", Latitude = 7, Longitude = 81 },
                new LatLongPoints {Name = "Sudan", Latitude = 15, Longitude = 30 },
                new LatLongPoints {Name = "Suriname", Latitude = 4, Longitude = -56 },
                new LatLongPoints {Name = "Swaziland", Latitude = -26.5, Longitude = 31.5 },
                new LatLongPoints {Name = "Sweden", Latitude = 62, Longitude = 15 },
                new LatLongPoints {Name = "Switzerland", Latitude = 47, Longitude = 8 },
                new LatLongPoints {Name = "Syria", Latitude = 35, Longitude = 38 },
                new LatLongPoints {Name = "Taiwan", Latitude = 23.5, Longitude = 121 },
                new LatLongPoints {Name = "Tajikistan", Latitude = 39, Longitude = 71 },
                new LatLongPoints {Name = "Tanzania", Latitude = -6, Longitude = 35 },
                new LatLongPoints {Name = "Thailand", Latitude = 15, Longitude = 100 },
                new LatLongPoints {Name = "Togo", Latitude = 8, Longitude = 1.1667 },
                new LatLongPoints {Name = "Trinidad and Tobago", Latitude = 11, Longitude = -61 },
                new LatLongPoints {Name = "Tunisia", Latitude = 34, Longitude = 9 },
                new LatLongPoints {Name = "Turkey", Latitude = 39, Longitude = 35 },
                new LatLongPoints {Name = "Turkmenistan", Latitude = 40, Longitude = 60 },
                new LatLongPoints {Name = "Ukraine", Latitude = 49, Longitude = 32 },
                new LatLongPoints {Name = "United Arab Emirates", Latitude = 24, Longitude = 54 },
                new LatLongPoints {Name = "United Kingdom", Latitude = 54, Longitude = -2 },
                new LatLongPoints {Name = "United States", Latitude = 38, Longitude = -97 },
                new LatLongPoints {Name = "Uruguay", Latitude = -33, Longitude = -56 },
                new LatLongPoints {Name = "Uzbekistan", Latitude = 41, Longitude = 64 },
                new LatLongPoints {Name = "Vanuatu", Latitude = -16, Longitude = 167 },
                new LatLongPoints {Name = "Vatican City", Latitude = 41.9, Longitude = 12.45 },
                new LatLongPoints {Name = "Vietnam", Latitude = 16, Longitude = 106 },
                new LatLongPoints {Name = "Yemen", Latitude = 15, Longitude = 48 },
                new LatLongPoints {Name =  "Yugoslavia", Latitude = 0, Longitude = 0 },
                new LatLongPoints {Name = "Zaire", Latitude = -20, Longitude = 30 }
            };
            return countryLatLongPoints;
        }
    }

    public class LatLongPoints
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double latitude;

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double longitude;

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

    }

   

}