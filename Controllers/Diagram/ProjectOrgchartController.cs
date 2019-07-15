#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /Organization/

        public ActionResult ProjectOrgChart()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "100%";
            model.Height = "520px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.OrganizationalChart;
            model.Layout.Margin.Top = 50;
            model.Layout.HorizontalSpacing = 40;
            model.Layout.VerticalSpacing = 40;
            model.DataSourceSettings.DataSource = GetProjectChartData();
            model.DataSourceSettings.Parent = "Phase";
            model.DataSourceSettings.Id = "Id";
            model.DefaultSettings.Node = new Node()
             {
                 Width = 130,
                 Height = 40,
                 BorderColor = "transparent"
             };
            Label label = new Label() { FontColor = "#ffffff" };
            model.DefaultSettings.Node.Labels.Add(label);
            model.DefaultSettings.Connector = new Connector()
             {
                 Segments = new Collection() { new Segment(Segments.Orthogonal) },
                 TargetDecorator = new Decorator() { Shape = DecoratorShapes.None }
             };
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.Tool = Tool.ZoomPan;
            model.NodeTemplate = "nodeTemplate";
            ViewData["diagramModel"] = model;
            return View();
        }

        public Array GetProjectChartData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/ProjectChart.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}
