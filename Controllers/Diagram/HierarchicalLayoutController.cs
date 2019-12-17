#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        // GET: /HierarchicalLayout/
        public ActionResult HierarchicalLayout()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "400px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.HierarchicalTree;
            model.Layout.HorizontalSpacing = 25;
            model.Layout.VerticalSpacing = 35;
            model.Layout.Margin.Left = 0;
            model.Layout.Margin.Top = 10;
            model.DataSourceSettings.DataSource = GetHierarchicalLayout();
            model.DataSourceSettings.Parent = "ReportingPerson";
            model.DataSourceSettings.Id = "Name";
            model.Create = "create";
            model.DefaultSettings.Node = new Node()
            {
                Constraints = NodeConstraints.Select | NodeConstraints.PointerEvents,
                FillColor = "#88C65C",
                Width = 115,
                Height = 45,
                BorderWidth = 1,
                BorderColor = "black"
            };
            Label label = new Label() { FontColor = "white", FontSize = 12 };
            model.DefaultSettings.Node.Labels.Add(label);
            model.DefaultSettings.Connector = new Connector()
            {
                LineColor = "#000000",
                Segments = new Collection() { new Segment(Segments.Orthogonal) },
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.Arrow },
                Constraints = ConnectorConstraints.None
            };
            model.SelectedItems.Constraints = ~SelectorConstraints.Rotator;
            model.SelectionChange = "selectionChange";
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.Tool = Tool.SingleSelect;
            model.NodeTemplate = "nodeTemplate";
            ViewData["diagramModel"] = model;
            return View();
        }
        public Array GetHierarchicalLayout()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/HierarchicalLayout.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}