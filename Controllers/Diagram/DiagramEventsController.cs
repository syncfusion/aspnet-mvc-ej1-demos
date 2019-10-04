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
using MVCSampleBrowser.Models.Digram;


namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {

        public ActionResult DiagramEvents()
        {
            SymbolPaletteProperties palette = new SymbolPaletteProperties();
            SwimlaneModel lane = new SwimlaneModel();
            lane.createSymbolPalette(palette);
            lane.GenerateBasicShapes(palette);
            lane.GenerateSwimlaneShapes(palette);
            lane.GenerateConnectors(palette);
            ViewData["SymbolPaletteModel"] = palette;
            DiagramProperties model = new DiagramProperties();
            model.Height = "600px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;

            model.SelectionChange = "selectionChange";
            model.SizeChange = "sizeChanged";
            model.ConnectorCollectionChange = "collectionChanged";
            model.NodeCollectionChange = "collectionChanged";
            model.TextChange = "textChanged";
            model.SegmentChange = "segmentChanged";
            model.RotationChange = "eventLog";
            model.ConnectorTargetChange = "endPointChanged";
            model.ConnectorSourceChange = "endPointChanged";
            model.ScrollChange = "scrollChanged";
            model.DoubleClick = "doubleClickd";
            model.DragEnter = "eventLog";
            model.DragOver = "eventLog";
            model.DragLeave = "eventLog";
            model.Drag = "dragd";
            model.Drop = "eventLog";
            model.GroupChange = "eventLog";
            model.HistoryChange = "eventLog";
            model.Click = "clicked";
            model.ConnectionChange = "eventLog";
            model.ContextMenuBeforeOpen = "eventLog";
            model.ContextMenuClick = "contextMenuClicked";

            FlowShape node1 = CreateDiagramNode("node1", 100, 60, 200, 50, "Start", FlowShapes.Terminator, "#05ADA4");
            FlowShape node2 = CreateDiagramNode("node2", 100, 70, 200, 150, "Process1", FlowShapes.Process, "#33AACA");
            FlowShape node3 = CreateDiagramNode("node3", 90, 90, 200, 270, "Decision1", FlowShapes.Decision, "#83A93F");
            FlowShape node4 = CreateDiagramNode("node4", 90, 90, 100, 450, "Decision2", FlowShapes.Decision, "#83A93F");
            FlowShape node5 = CreateDiagramNode("node5", 90, 90, 300, 450, "Process2", FlowShapes.Process, "#83A93F");
            FlowShape node6 = CreateDiagramNode("node6", 100, 60, 200, 550, "End", FlowShapes.Terminator, "#05ADA4");
            
            ConnectDiagramNode(model, node1, node2, "");
            ConnectDiagramNode(model, node2, node3, "");
            ConnectDiagramNode(model, node3, node4, "No");
            ConnectDiagramNode(model, node3, node5, "Yes");
            Connector connector = ConnectDiagramNode(model, node4, node6, "No");
            connector.Segments = new Collection(){
                new Segment()
                {
                    Type =  Segments.Orthogonal, 
                    Length = 50, 
                    Direction = "left" 
                }
            };
            connector = ConnectDiagramNode(model, node5, node6, "Yes");
            connector.Segments = new Collection(){
                new Segment()
                {
                    Type =  Segments.Orthogonal, 
                    Length = 50, 
                    Direction = "right" 
                }
            };

            model.Nodes.Add(node1);
            model.Nodes.Add(node2);
            model.Nodes.Add(node3);
            model.Nodes.Add(node4);
            model.Nodes.Add(node5);
            model.Nodes.Add(node6);
            model.EnableContextMenu = false;
            ViewData["DiagramModel"] = model;
            return View();
        }

        private FlowShape CreateDiagramNode(string name, double width, double height, double offsetx, double offsety, string labelText, FlowShapes shape, string fillColor)
        {
            FlowShape node = new FlowShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            node.FillColor = fillColor;
            //node.BorderColor = "#1BA0E2";
            node.Shape = shape;
            Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
            label.Text = labelText;
            label.FontColor = "white";
            label.Name = name + "_label";
            node.Labels.Add(label);
            return node;

        }

        private Connector ConnectDiagramNode(DiagramProperties model, Node targetNode, Node sourceNode, string labelText)
        {
            Connector connector = new Connector();
            connector.Name = "line" + model.Connectors.Count + 1;
            connector.Segments = new Collection();
            Segment seg = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Segment(Segments.Orthogonal);
            connector.Segments.Add(seg);
            connector.TargetNode = targetNode.Name;
            connector.SourceNode = sourceNode.Name;
            connector.LineWidth = 2;
            if (!string.IsNullOrEmpty(labelText))
            {
                Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
                label.FontColor = "black";
                label.FillColor = "white";
                label.Text = labelText;
                connector.Labels.Add(label);
            }
            connector.SourceDecorator.Shape = Syncfusion.JavaScript.DataVisualization.DiagramEnums.DecoratorShapes.Arrow;
            connector.TargetDecorator.Shape = Syncfusion.JavaScript.DataVisualization.DiagramEnums.DecoratorShapes.None;
            connector.TargetDecorator.BorderColor = "#606060";
            connector.TargetDecorator.Width = 10;
            connector.TargetDecorator.Height = 10;
            model.Connectors.Add(connector);
            return connector;
        }

    }
}
