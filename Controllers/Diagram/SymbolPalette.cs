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
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /Tooltip/
        public ActionResult SymbolPalette()
        {

            SymbolPaletteProperties model = new SymbolPaletteProperties();
            model.Height = "500px";
            model.Width = "300px";
            model.ShowPaletteItemText = true;
            model.SelectedPaletteName = "Flow Shapes";
            model.Palettes.Add(CreateFlowShapes());
            model.Palettes.Add(CreateConnectors());
            model.Palettes.Add(CreateBasicShapes());
            ViewData["SymbolPaletteModel"] = model;
            return View();
        }
        public Palette CreateFlowShapes()
        {
            Palette Palette = new Palette("Flow Shapes");
            Palette.Expanded = true; Palette.TemplateId = "svgTemplate";
            Palette.AddInfo = new Dictionary<string, object>();
            (Palette.AddInfo as Dictionary<string, object>).Add("source", Url.Content("~/Content/diagram/images/flow.png"));
            Palette.Items.Add(new FlowShape() { Name = "Process", Height = 40, Width = 44, OffsetX = 20, OffsetY = 20, Shape = FlowShapes.Process });
            Palette.Items.Add(new FlowShape() { Name = "Decision", Height = 40, Width = 44, OffsetX = 20, OffsetY = 20, Shape = FlowShapes.Decision });
            Palette.Items.Add(new FlowShape() { Name = "Sort", Height = 40, Width = 44, OffsetX = 20, OffsetY = 20, Shape = FlowShapes.Sort });
            Palette.Items.Add(new FlowShape() { Name = "Document", Height = 40, Width = 44, OffsetX = 20, OffsetY = 20, Shape = FlowShapes.Document });
            Palette.Items.Add(new FlowShape() { Name = "MultiDocument", Height = 40, Width = 43, OffsetX = 20, OffsetY = 20, Shape = FlowShapes.MultiDocument });
            return Palette;
        }
        public Palette CreateConnectors()
        {
            Palette Palette = new Palette("Connectors");
            Palette.Expanded = true; Palette.TemplateId = "svgTemplate";
            Palette.AddInfo = new Dictionary<string, object>();
            (Palette.AddInfo as Dictionary<string, object>).Add("source", Url.Content("~/Content/diagram/images/connector.png"));
            Collection Segments = new Collection();
            Segments.Add(new Segment() { Type = Syncfusion.JavaScript.DataVisualization.DiagramEnums.Segments.Orthogonal });
            PaletteItem PaletteItem = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.PaletteItem() { Height = 45, Width = 57, EnableScale = false };
            Palette.Items.Add(new Connector() { Name = "Link1", Segments = Segments, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, PaletteItem = PaletteItem, TargetDecorator = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Decorator() { Shape = DecoratorShapes.Arrow } });
            Palette.Items.Add(new Connector() { Name = "Link2", Segments = Segments, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, PaletteItem = PaletteItem, TargetDecorator = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Decorator() { Shape = DecoratorShapes.None } });
            Segments = new Collection();
            Segments.Add(new Segment() { Type = Syncfusion.JavaScript.DataVisualization.DiagramEnums.Segments.Straight });
            Palette.Items.Add(new Connector() { Name = "Link1", Segments = Segments, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, PaletteItem = PaletteItem, TargetDecorator = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Decorator() { Shape = DecoratorShapes.Arrow } });
            Palette.Items.Add(new Connector() { Name = "Link2", Segments = Segments, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, PaletteItem = PaletteItem, TargetDecorator = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Decorator() { Shape = DecoratorShapes.None } });
            return Palette;
        }
        public Palette CreateBasicShapes()
        {
            Palette Palette = new Palette("Basic Shapes");
            Palette.Expanded = true; Palette.TemplateId = "svgTemplate";
            Palette.AddInfo = new Dictionary<string, object>();
            (Palette.AddInfo as Dictionary<string, object>).Add("source", Url.Content("~/Content/diagram/images/basic.png"));
            PaletteItem PaletteItem = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.PaletteItem() { Margin = new Margin() { Left = 4, Right = 4, Top = 12, Bottom = 10 }, EnableScale = false };
            Palette.Items.Add(new BasicShape() { Name = "Rectangle1", Height = 160, Width = 80, Shape = BasicShapes.Rectangle, PaletteItem = PaletteItem });
            Palette.Items.Add(new BasicShape() { Name = "Rectangle2", Height = 70, Width = 70, Shape = BasicShapes.Rectangle });
            Palette.Items.Add(new BasicShape() { Name = "Ellipse", Height = 70, Width = 70, Shape = BasicShapes.Ellipse });
            Collection Collection = new Syncfusion.JavaScript.DataVisualization.Models.Collections.Collection();
            Collection.Add(new DiagramPoint() { X = 25, Y = 0 });
            Collection.Add(new DiagramPoint() { X = 75, Y = 0 });
            Collection.Add(new DiagramPoint() { X = 100, Y = 50 });
            Collection.Add(new DiagramPoint() { X = 75, Y = 100 });
            Collection.Add(new DiagramPoint() { X = 25, Y = 100 });
            Collection.Add(new DiagramPoint() { X = 0, Y = 50 });
            Palette.Items.Add(new BasicShape() { Name = "Hexagon", Height = 70, Width = 70, Shape = BasicShapes.Polygon, Points = Collection });
            Collection = new Syncfusion.JavaScript.DataVisualization.Models.Collections.Collection();
            Collection.Add(new DiagramPoint() { X = 50, Y = 0 });
            Collection.Add(new DiagramPoint() { X = 100, Y = 100 });
            Collection.Add(new DiagramPoint() { X = 0, Y = 100 });
            Palette.Items.Add(new BasicShape() { Name = "Triangle", Height = 70, Width = 70, Shape = BasicShapes.Polygon, Points = Collection });
            return Palette;
        }
    }
}