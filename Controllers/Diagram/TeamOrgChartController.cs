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

        public ActionResult TeamOrgchart()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "100%";
            model.Height = "600px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.OrganizationalChart;
            model.Layout.Margin.Top = 50;
            model.Layout.HorizontalSpacing = 30;
            model.Layout.VerticalSpacing = 30;
            model.DataSourceSettings.DataSource = GetTeamChartData();
            model.DataSourceSettings.Parent = "ReportingPerson";
            model.DataSourceSettings.Id = "Id";
            model.DefaultSettings.Node = new ImageNode() { Width = 140, Height = 50, BorderColor = "transparent", BorderWidth = 0 };
            Label label = new Label() { Name = "name1", Text = "", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, FontSize = 11, Bold = true, FontFamily = "Segoe UI", Margin = new LabelMargin(-17, -17, 0, 0) };
            Label label1 = new Label() { Name = "name2", Text = "", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, FontSize = 10, FontFamily = "Segoe UI", Margin = new LabelMargin(-2, -17, 0, 0) };
            model.DefaultSettings.Node.Labels.Add(label);
            model.DefaultSettings.Node.Labels.Add(label1);
            model.DefaultSettings.Connector = new Connector()
            {
                Segments = new Collection() { new Segment(Segments.Orthogonal) },
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.None }
            };
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.NodeTemplate = "nodeTemplate";
            model.Tool = Tool.ZoomPan;
            ViewData["diagramModel"] = model;
            return View();
        }

        public Array GetTeamChartData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/OrgChart.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}
