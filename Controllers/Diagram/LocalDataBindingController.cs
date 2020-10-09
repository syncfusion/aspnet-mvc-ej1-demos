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

        public ActionResult LocalDataBinding()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "100%";
            model.Height = "490px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.HierarchicalTree;
            model.Layout.MarginY = 50;
            model.Layout.HorizontalSpacing = 30;
            model.Layout.VerticalSpacing = 40;
            model.DataSourceSettings.DataSource = GetData();
            model.DataSourceSettings.Parent = "TeamLead";
            model.DataSourceSettings.Id = "Id";
            model.DefaultSettings.Node = new Node() { Width = 110, Height = 40, BorderColor = "transparent" };
            Label label = new Label() { FontColor = "#ffffff", Margin = new LabelMargin() { Left = 5, Right = 5 } };
            model.DefaultSettings.Node.Labels.Add(label);
            model.DefaultSettings.Connector = new Connector()
            {
                Segments = new Collection() { new Segment(Segments.Orthogonal) },
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.Arrow }
            };
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.NodeTemplate = "nodeTemplate";
            model.Tool = Tool.ZoomPan;
            ViewData["diagramModel"] = model;
            return View();
        }

        public Array GetData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MarketChart.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}
