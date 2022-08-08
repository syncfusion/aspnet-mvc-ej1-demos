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
using System.Web.Mvc;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        // GET: DrillDown
        public ActionResult DrillDown()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "600px";
            model.Height = "600px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.HierarchicalTree;
            model.Layout.Margin = new Margin() { Top = 60 };
            model.Layout.VerticalSpacing = 60;
            model.PageSettings.PageWidth = 600;
            model.PageSettings.PageHeight = 600;
            model.PageSettings.PageBorderColor = "#f5f5f5";
            model.PageSettings.PageBorderWidth = 2;
  

            ImageNode node = new ImageNode();
            node.Name = "Image1";
            node.Source = "../Images/diagram/drilldown/image2.png";
            Dictionary<string, object> addinfo = new Dictionary<string, object>();
            addinfo.Add("toolvalue", "Click on node to drill down");
            node.AddInfo = addinfo;
            model.Nodes.Add(node);

            TextNode text = new TextNode();
            text.Name = "textNode";
            text.Width = 200;
            text.Height = 60;
            text.Constraints = NodeConstraints.None;
            text.OffsetX = 310;
            text.OffsetY = 30;
            text.ExcludeFromLayout = true;
            text.TextBlock.Text = "Coevals Diagram";
            text.TextBlock.FontColor = "blue";
            text.TextBlock.FontSize = 20;
            text.TextBlock.FontFamily = "Segoe UI";
            model.Nodes.Add(text);

            model.DefaultSettings.Node = new ImageNode()
            {
                Width = 50,
                Height = 50,
                BorderColor = "transparent",
                Labels = new Collection() { new Label(){ReadOnly=true}}
            };
            model.DefaultSettings.Connector = new Connector() { Segments = new Collection() { new Segment() { Type = Segments.Orthogonal } } };
            model.Click = "click";
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.SelectedItems.Constraints = SelectorConstraints.None;
            model.DoubleClick = "doubleclick";
            model.Tooltip = new Tooltip() { TemplateId = "mouseovertooltip" };
            model.Tooltip.Alignment = new Alignment() { Horizontal = HorizontalAlignment.Center, Vertical = VerticalAlignment.Bottom };
            ViewData["diagramModel"] = model;
            return View();
        }
        [HttpPost]
        public ActionResult getData()
        {
            return Json(GetDrillDownData());
        }
        public Array GetDrillDownData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/DrillDown.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}