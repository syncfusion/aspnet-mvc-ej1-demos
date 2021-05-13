#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript.DataVisualization.HeatMapEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.Shared.Serializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class HeatMapController : Controller
    {
        //
        // GET: /ShapesGallery/
        public ActionResult Legend()
        {
            HeatMapProperties Heatmap = new HeatMapProperties();
            List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
            colorCollection.Add(new HeatMapColorMapping() { Color = "#fe0002", Label = new HeatMapLabel() { Text = "Poor" }, Value = 0 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#ffff01", Label = new HeatMapLabel() { Text = "Average" }, Value = 3 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#13ab11", Label = new HeatMapLabel() { Text = "Good" }, Value = 6 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#005ba2", Label = new HeatMapLabel() { Text = "Excellent" }, Value = 10 });
            Heatmap.ColorMappingCollection = colorCollection;
            Heatmap.IsResponsive = true;
            Heatmap.LegendCollection.Add("heatmapLegend");


            TableMapping TableMapping = new TableMapping();
            TableMapping.HeaderMapping = new HeaderMapping() { PropertyName = "EmpName", DisplayName = "Employee Name", ColumnStyle = new ColumnStyle() { Width = 100, TextAlign = HeatMapTextAlign.Right } };
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "January", DisplayName = "January" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "February", DisplayName = "February" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "March", DisplayName = "March" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "April", DisplayName = "April" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "May", DisplayName = "May" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "June", DisplayName = "June" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "July", DisplayName = "July" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "August", DisplayName = "August" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "September", DisplayName = "September" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "October", DisplayName = "October" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "November", DisplayName = "November" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "December", DisplayName = "December" });
            Heatmap.ItemsMapping = TableMapping;
            //Heatmap.Height = "auto";
            Heatmap.Width = "100%";
            Heatmap.ItemsSource = GetLegendSource();
            ViewData["HeatMapModel"] = Heatmap;

            HeatMapLegendProperties legend = new HeatMapLegendProperties();
            legend.ColorMappingCollection = colorCollection;
            legend.Orientation = HeatMapLegendOrientation.Horizontal;
            legend.LegendMode = HeatMapLegendMode.Gradient;
            legend.Height = "50px";
            legend.Width = "75%";
            legend.IsResponsive = true;
            ViewData["HeatMapLegendModel"] = legend;
            return View();
        }

        public Collection GetLegendSource()
        {
            Collection collection = new Collection();
            Random random = new Random();
            string[] rows = { "Peter Scott", "Maria Anders", "John Camino", "Philips Cramer", "Robert King", "Simon Crowther" };
            for (int i = 0; i < rows.Length; i++)
            {
                collection.Add(new HeatMapLegendData()
                {
                    EmpName = rows[i],
                    Jan = random.Next(0, 10),
                    Feb = random.Next(0, 10),
                    Mar = random.Next(0, 10),
                    Apr = random.Next(0, 10),
                    May = random.Next(0, 10),
                    Jun = random.Next(0, 10),
                    Jul = random.Next(0, 10),
                    Aug = random.Next(0, 10),
                    Sep = random.Next(0, 10),
                    Oct = random.Next(0, 10),
                    Nov = random.Next(0, 10),
                    Dec = random.Next(0, 10),
                });
            }
            return collection;
        }
    }

    [Serializable]
    public class HeatMapLegendData
    {
        private string empName;
        [JsonProperty("EmpName")]
        [DefaultValue("")]
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private double jan;
        [JsonProperty("January")]
        [DefaultValue("")]
        public double Jan
        {
            get { return jan; }
            set { jan = value; }
        }
        private double feb;
        [JsonProperty("February")]
        [DefaultValue("")]
        public double Feb
        {
            get { return feb; }
            set { feb = value; }
        }

        private double mar;
        [JsonProperty("March")]
        [DefaultValue("")]
        public double Mar
        {
            get { return mar; }
            set { mar = value; }
        }

        private double apr;
        [JsonProperty("April")]
        [DefaultValue("")]
        public double Apr
        {
            get { return apr; }
            set { apr = value; }
        }

        private double may;
        [JsonProperty("May")]
        [DefaultValue("")]
        public double May
        {
            get { return may; }
            set { may = value; }
        }

        private double jun;
        [JsonProperty("June")]
        [DefaultValue("")]
        public double Jun
        {
            get { return jun; }
            set { jun = value; }
        }

        private double jul;
        [JsonProperty("July")]
        [DefaultValue("")]
        public double Jul
        {
            get { return jul; }
            set { jul = value; }
        }

        private double aug;
        [JsonProperty("August")]
        [DefaultValue("")]
        public double Aug
        {
            get { return aug; }
            set { aug = value; }
        }

        private double sep;
        [JsonProperty("September")]
        [DefaultValue("")]
        public double Sep
        {
            get { return sep; }
            set { sep = value; }
        }

        private double oct;
        [JsonProperty("October")]
        [DefaultValue("")]
        public double Oct
        {
            get { return oct; }
            set { oct = value; }
        }

        private double nov;
        [JsonProperty("November")]
        [DefaultValue("")]
        public double Nov
        {
            get { return nov; }
            set { nov = value; }
        }

        private double dec;
        [JsonProperty("December")]
        [DefaultValue("")]
        public double Dec
        {
            get { return dec; }
            set { dec = value; }
        }
    }
}