#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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


namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        // GET: MultipleParent
        public ActionResult MultipleParent()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "450px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.HierarchicalTree;
            model.Layout.HorizontalSpacing = 40;
            model.Layout.VerticalSpacing = 40;
            model.Layout.Margin.Left = 0;
            model.Layout.Margin.Top = 30;
            model.DataSourceSettings.DataSource = GetMultipleParent();
            model.DataSourceSettings.Parent = "ReportingPerson";
            model.DataSourceSettings.Id = "Name";
            model.DefaultSettings.Node = new BasicShape()
            {
                Constraints = NodeConstraints.Select | NodeConstraints.PointerEvents,
                FillColor = "#88C65C",
                Width = 40,
                Height = 40,
                BorderWidth = 1,
                BorderColor = "#5e5e5e",
                CornerRadius = 7,
            };
            
            model.DefaultSettings.Connector = new Connector()
            {
                LineColor = "#000000",
                Segments = new Collection() { new Segment(Segments.Orthogonal) },
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.Arrow , Width = 5, Height = 5 },
                Constraints = ConnectorConstraints.None,
                CornerRadius = 10
            };
            model.SelectedItems.Constraints = ~SelectorConstraints.Rotator;
            model.SelectionChange = "selectionChange";
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.Tool = Tool.SingleSelect;
            model.Create = "diagramCreate";
            ViewData["diagramModel"] = model;
            return View();
        }
        public Array GetMultipleParent()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MultipleParent.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}