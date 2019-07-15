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
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.DataVisualization.Models;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /Diagram/
        public ActionResult PageSettings()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "500px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.PageSettings.PageHeight = 500;
            model.PageSettings.PageWidth = 500;
            model.PageSettings.PageBorderWidth = 1;
            model.PageSettings.PageBackgroundColor = "white";
            model.PageSettings.PageBorderColor = "black";
            model.PageSettings.PageMargin = 20;
            model.PageSettings.ShowPageBreak = true;
            model.PageSettings.MultiplePage = true;
            model.PageSettings.PageOrientation = PageOrientation.Landscape;
            model.PageSettings.BoundaryConstraints = BoundaryConstraints.Diagram;
            model.SnapSettings.EnableSnapToObject = true;
            model.SnapSettings.SnapAngle = 1;
            model.SnapSettings.SnapObjectDistance = 10;
            model.EnableContextMenu = false;
            model.Create = "diagramCreate";

            BasicShape node1 = CreateNodes("node1", 60, 60, 170, 105, "#99SF13", "#FBB040");
            BasicShape node2 = CreateNodes("node2", 60, 90, 240, 105, "#8BB23F", "#A0D05F");
            BasicShape node3 = CreateNodes("node3", 60, 120, 310, 105, "#27A9CC", "#7FDEFF");
            BasicShape node4 = CreateNodes("node4", 60, 90, 160, 255, "#99SF13", "#FBB040");
            BasicShape node5 = CreateNodes("node5", 90, 90, 240, 255, "#8BB23F", "#A0D05F");
            BasicShape node6 = CreateNodes("node6", 60, 90, 320, 255, "#27A9CC", "#7FDEFF");
            BasicShape node7 = CreateNodes("node7", 90, 60, 165, 400, "#99SF13", "#FBB040");
            BasicShape node8 = CreateNodes("node8", 90, 60, 240, 400, "#8BB23F", "#A0D05F");
            BasicShape node9 = CreateNodes("node9", 90, 60, 315, 400, "#27A9CC", "#7FDEFF");
            BasicShape node10 = CreateText("node10", 90, 40, 240, 170, "Same Width");
            BasicShape node11 = CreateText("node11", 90, 40, 240, 320, "Same Height");
            BasicShape node12 = CreateText("node12", 90, 40, 240, 450, "Same Size");

            model.Nodes.Add(node1);
            model.Nodes.Add(node2);
            model.Nodes.Add(node3);
            model.Nodes.Add(node4);
            model.Nodes.Add(node5);
            model.Nodes.Add(node6);
            model.Nodes.Add(node7);
            model.Nodes.Add(node8);
            model.Nodes.Add(node9);
            model.Nodes.Add(node10);
            model.Nodes.Add(node11);
            model.Nodes.Add(node12);

            ViewData["diagramModel"] = model;
            ViewData["DropDownSource"] = DropDownData.GetColors();
            ViewData["SnapDataSource"] = DropDownData.GetSnapItems();
            ViewData["Orientation"] = DropDownData.GetOrientation();
            ViewData["Boundary"] = DropDownData.GetBoundary();
            return View();
        }
        private BasicShape CreateNodes(String name, double width, double height, double offsetx, double offsety, string borderColor, string stopsColor)
        {
            BasicShape node = new BasicShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            node.BorderColor = borderColor;
            node.Shape = BasicShapes.Ellipse;
            RadialGradient Radial = new RadialGradient();
            Radial.CX = 50;
            Radial.CY = 50;
            Radial.FX = 50;
            Radial.FY = 50;
            Collection Stops = new Collection();
            Stop Stop = new Stop();
            Stop.Opacity = 0;
            Stop.Color = "white";
            Stop.Offset = 0;
            Stops.Add(Stop);
            Stop = new Stop();
            Stop.Opacity = 1;
            Stop.Color = stopsColor;
            Stop.Offset = 100;
            Stops.Add(Stop);
            Radial.Stops = Stops;
            node.Gradient = Radial;
            node.BorderWidth = 1;
            return node;
        }
        private BasicShape CreateText(String name, double width, double height, double offsetx, double offsety,string labelText)
        {
            BasicShape node = new BasicShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            node.FillColor = "transparent";
            node.BorderWidth = 1;
            node.BorderColor = "transparent";
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.Select;
            Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
            label.Text = labelText;
            label.Name = name + "_label";
            node.Labels.Add(label);
            return node;
        }
        
    }
}