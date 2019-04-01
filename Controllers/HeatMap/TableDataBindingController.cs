#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        public ActionResult TableDataBinding()
        {
            HeatMapProperties Heatmap = new HeatMapProperties();
            List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
            colorCollection.Add(new HeatMapColorMapping() { Color = "#8ec8f8", Label = new HeatMapLabel() { Text = "0" }, Value = 0 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#0d47a1", Label = new HeatMapLabel() { Text = "100" }, Value = 100 });
            Heatmap.ColorMappingCollection = colorCollection;
            Heatmap.LegendCollection.Add("heatmapLegend");
            TableMapping TableMapping = new TableMapping();
            TableMapping.HeaderMapping = new HeaderMapping() { PropertyName = "ProductName", DisplayName = "Product Name", ColumnStyle = new ColumnStyle() { Width = 140, TextAlign = HeatMapTextAlign.Right } };
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2010", DisplayName = "Y2010" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2011", DisplayName = "Y2011" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2012", DisplayName = "Y2012" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2013", DisplayName = "Y2013" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2014", DisplayName = "Y2014" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2015", DisplayName = "Y2015" });
            Heatmap.ItemsMapping = TableMapping;
            Heatmap.IsResponsive = true;
            Heatmap.ItemsSource = GetTableSource();
            Heatmap.Width = "100%";
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

        public Collection GetTableSource()
        {
            Collection collection = new Collection();
            Random random = new Random();
            string[] rows = { "Vegie-spread", "Tofuaa", "Alice Mutton", "Konbu", "Fløtemysost", "Perth Pasties", "Boston Crab Meat", "Raclette Courdavault" };
            for (int i = 0; i < 8; i++)
            {
                collection.Add(new SampleTableData()
                {
                    ProductName = rows[i],
                    Y2010 = random.Next(0, 100),
                    Y2011 = random.Next(0, 100),
                    Y2012 = random.Next(0, 100),
                    Y2013 = random.Next(0, 100),
                    Y2014 = random.Next(0, 100),
                    Y2015 = random.Next(0, 100)
                });
            }
            return collection;
        }
    }

    [Serializable]
    public class SampleTableData
    {
        private string productName;
        [JsonProperty("ProductName")]
        [DefaultValue("")]
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double y2010;
        [JsonProperty("Y2010")]
        [DefaultValue("")]
        public double Y2010
        {
            get { return y2010; }
            set { y2010 = value; }
        }

        private double y2011;
        [JsonProperty("Y2011")]
        [DefaultValue("")]
        public double Y2011
        {
            get { return y2011; }
            set { y2011 = value; }
        }

        private double y2012;
        [JsonProperty("Y2012")]
        [DefaultValue("")]
        public double Y2012
        {
            get { return y2012; }
            set { y2012 = value; }
        }

        private double y2013;
        [JsonProperty("Y2013")]
        [DefaultValue("")]
        public double Y2013
        {
            get { return y2013; }
            set { y2013 = value; }
        }

        private double y2014;
        [JsonProperty("Y2014")]
        [DefaultValue("")]
        public double Y2014
        {
            get { return y2014; }
            set { y2014 = value; }
        }

        private double y2015;
        [JsonProperty("Y2015")]
        [DefaultValue("")]
        public double Y2015
        {
            get { return y2015; }
            set { y2015 = value; }
        }
    }
}