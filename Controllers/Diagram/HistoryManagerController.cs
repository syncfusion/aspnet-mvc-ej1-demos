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
        //
        // GET: /Diagram/

        public ActionResult HistoryManager()
        {
            

            DiagramProperties model = new DiagramProperties();
            model.Height = "500px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.NodeCollectionChange ="nodecollectionchange";
            model.HistoryChange = "historyChange";
            model.HistoryManager.StackLimit = 3;

            CreateShape("node1", FlowShapes.Terminator, 90, 40, 380, 30, "#C44E5F", "Start", model);
            CreateShape("node2", FlowShapes.Process, 90, 40, 380, 100, "#5E5F5F", "Design", model, true);
            CreateShape("node3", FlowShapes.Process, 90, 40, 380, 180, "#5E5F5F", "Coding", model, true);
            CreateShape("node4", FlowShapes.Process, 90, 40, 380, 260, "#5E5F5F", "Testing", model);
            CreateShape("node5", FlowShapes.Decision, 90, 40, 380, 340, "#4EAB8B", "Errors?", model);
            CreateShape("node6", FlowShapes.Terminator, 90, 40, 380, 450, "#C44E5F", "End", model);
            CreateShape("node7", FlowShapes.Decision, 120, 40, 200, 180, "#4EAB8B", "Decision Error?", model, true);

            ConnectHistoryShapes(model, "node1", "node2");
            ConnectHistoryShapes(model, "node2", "node3");
            ConnectHistoryShapes(model, "node3", "node4");
            Label label1 = new Label() { Text = "Yes", FillColor = "white", Offset = new DiagramPoint(0.44f, 0.27f) };
            Connector connector = ConnectHistoryShapes(model, "node5", "node7",null,"innn");
            connector.Labels.Add(label1);
            Label label2 = new Label() { Text = "Yes", FillColor = "white", Offset = new DiagramPoint(0.44f, 0.27f) };
            connector = ConnectHistoryShapes(model, "node7", "node2", "inn", "in");
            connector.Labels.Add(label2);
            Label label3 = new Label() { Text = "No", FillColor = "white", Offset = new DiagramPoint(0.44f, 0.27f) };
            connector = ConnectHistoryShapes(model, "node7", "node3");
            connector.Labels.Add(label3);
            ConnectHistoryShapes(model, "node4", "node5");
            ConnectHistoryShapes(model, "node5", "node6");
            ViewData["diagramModel"] = model;
            return View();
        }

        private FlowShape CreateDiagramFlowShape(String name, FlowShapes shape, double width, double height, double offsetx, double offsety, string color, string labelText, DiagramProperties model, bool addPorts = false)
        {
            FlowShape node = new FlowShape();
            node.Name = name;
            node.Width = width;
            node.Shape = shape;
            node.Height = height;
            node.OffsetX = offsetx;
            node.FillColor = color;
            node.BorderColor = "#000000";
            node.OffsetY = offsety;
            //node.Constraints = NodeConstraints.Default & ~NodeConstraints.Drag;
            Label label = new Label();
            label.Margin = new LabelMargin() { Bottom = 2, Top = 2, Left = 20, Right = 20 };
            label.Text = labelText;
            label.FontColor = "white";
            label.Name = name + "_label";
            node.Labels.Add(label);
            if (addPorts) AddDiagramPorts(node);
            model.Nodes.Add(node);
            return node;
        }

        private void AddDiagramPorts(FlowShape node)
        {
            Port port = new Port();
            port.Name = "in";
            port.Offset = new DiagramPoint(0.5f, 0);
            port.Shape = PortShapes.Circle;
            node.Ports.Add(port);
            Port port1 = new Port();
            port1.Name = "inn";
            port1.Offset = new DiagramPoint(0.5f, 0);
            port1.Shape = PortShapes.Circle;
            node.Ports.Add(port1);
            Port port2 = new Port();
            port2.Name = "innn";
            port2.Offset = new DiagramPoint(0.5f, 1);
            port2.Shape = PortShapes.Circle;
            node.Ports.Add(port2);
        }
        private Connector ConnectHistoryShapes(DiagramProperties model, string sourceNode, string targetNode, string sourcePort = "", string targetPort = "")
        {
            Connector connector = new Connector();
            connector.Name = "line" + model.Connectors.Count + 1;
            connector.TargetNode = targetNode;
            connector.SourceNode = sourceNode;
            connector.SourcePort = sourcePort;
            connector.TargetPort = targetPort;
            connector.LineWidth = 2;
            connector.Constraints = ConnectorConstraints.Default | ConnectorConstraints.Bridging;
            connector.Segments = new Collection() { new Segment() { Type = Segments.Orthogonal } };
            model.Connectors.Add(connector);
            return connector;
        }
    }
}
