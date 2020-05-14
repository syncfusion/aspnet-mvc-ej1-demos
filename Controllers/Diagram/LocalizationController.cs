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
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /Localization/

        public ActionResult Localization()
        {
            DiagramProperties diagram = new DiagramProperties();
            
            diagram.Height = "700px";
            diagram.Width = "100%";
            diagram.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            diagram.SnapSettings.SnapConstraints = SnapConstraints.All;

            BasicShape newIdea = CreateNode("NewIdea", 150, 60, 300, 60, "Start Terminator");
            newIdea.FillColor = "darkCyan";
            newIdea.Shape = BasicShapes.Path;
            newIdea.PathData = "M 45 220 L 45 220 A 20 30 0 0 1 45 280 L 45 280 A 20 30 0 0 1 45 220 Z";
            AddPort(newIdea);
            BasicShape meeting = CreateNode("Meeting", 150, 60, 300, 150, "Progress");
            meeting.FillColor = "darkCyan";
            AddPort(meeting);
            BasicShape boardDecision = CreateNode("BoardDecision", 150, 100, 300, 270, "Decision");
            boardDecision.FillColor = "darkCyan";
            LabelMargin margin = new LabelMargin(0, 20, 20, 0);
            ((Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label)boardDecision.Labels[0]).Margin = margin;
            boardDecision.Shape = BasicShapes.Polygon;
            boardDecision.Points = GetDecisionPoints();
            AddPort(boardDecision);

            BasicShape project = CreateNode("Data", 150, 100, 300, 420, "Data");
            project.FillColor = "darkCyan";
            project.Shape = BasicShapes.Polygon;
            project.Points = GetDecisionPoints();
            AddPort(project);
            BasicShape end = CreateNode("End", 120, 60, 300, 645, "End Terminator");
            end.FillColor = "darkCyan";
            AddPort(end);
            BasicShape document = CreateNode("Document", 150, 60, 300, 545, "Document");
            document.FillColor = "darkCyan";
            document.Shape = BasicShapes.Path;
            document.PathData = " M 87.3593 87.8807 L 87.3593 20.0773 L 0 20.0773 L 0 87.8807 C 0 87.8807 25.1638 100 43.6797 87.8807 C 62.1955 75.7614 77.5794 80.942 87.3593 87.8807 Z";
            AddPort(document);
            ConnectNode(diagram,"connector1", newIdea, meeting, "", false, "", "");
            ConnectNode(diagram, "connector2", meeting, boardDecision, "", false, "", "");
            ConnectNode(diagram, "connector3", boardDecision, project, "Yes", true, "", "");
            ConnectNode(diagram, "connector4", project, document, "", true, "", "");
            ConnectNode(diagram, "connector5", document, end, "", true, "", "");
            ConnectNode(diagram, "connector6", boardDecision, meeting, "No", true, "", "");

            diagram.Nodes.Add(newIdea);
            diagram.Nodes.Add(meeting);
            diagram.Nodes.Add(boardDecision);
            diagram.Nodes.Add(project);
            diagram.Nodes.Add(document);
            diagram.Nodes.Add(end);

            diagram.EnableContextMenu = true;
            ViewData["diagramModel"] = diagram;

            return View();

        }


        private BasicShape CreateNode(String name, double width, double height, double offsetx, double offsety, string labelText)
        {
            BasicShape node = new BasicShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            node.FillColor = "#1BA0E2";
            node.BorderColor = "#1BA0E2";
            Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
            label.Text = labelText;
            label.FontColor = "white";
            label.Name = name + "_label";
            node.Labels.Add(label);
            return node;

        }
        private Collection GetDecisionPoints()
        {
            Collection points = new Collection();
            points.Add(new DiagramPoint(310, 50));
            points.Add(new DiagramPoint(340, 80));
            points.Add(new DiagramPoint(310, 110));
            points.Add(new DiagramPoint(280, 80));
            return points;
        }
        private void ConnectNode(DiagramProperties model, string name,Node targetNode, Node sourceNode, string labelText, bool hasLabel, string sourcePort, string targetPort)
        {
            Connector connector = new Connector();
            connector.Name = name;           
            connector.TargetNode = targetNode.Name;
            connector.SourceNode = sourceNode.Name;
            connector.LineWidth = 2;
            if (name == "connector6")
            {
                Segment seg = new Segment();
                seg.Length = 50;
                seg.Direction = "right";
                seg.Type = Segments.Orthogonal;
                connector.Segments.Add(seg);
                seg = new Segment();
                seg.Type = Segments.Orthogonal;
                connector.Segments.Add(seg);
            }
            if (hasLabel)
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
            connector.SourcePort = targetPort;
            connector.TargetPort = sourcePort;
            model.Connectors.Add(connector);
        }
        public void AddPort(Node node, string name, float x, float y)
        {
            Port port = new Port();
            port.Name = name;
            port.Offset = new DiagramPoint(x, y);
            port.Visibility = PortVisibility.Hidden;
            node.Ports.Add(port);
        }

        public void AddPort(Node node)
        {
            AddPort(node, "aport", 0, 0.5f);
            AddPort(node, "bport", 0.5f, 0);
            AddPort(node, "cport", 1, 0.5f);
            AddPort(node, "dport", 0.5f, 1);
           
        }

    }
}
