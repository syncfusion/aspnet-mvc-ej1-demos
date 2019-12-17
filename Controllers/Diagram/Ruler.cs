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

        public ActionResult Ruler()
        {
            DiagramProperties Diagram = new DiagramProperties();
            CreateDiagram(Diagram);             
            ViewData["diagramModel"] = Diagram; 
            return View();
        }
        public void CreateDiagram(DiagramProperties Diagram)
        {
            Diagram.Height = "600px";
            Diagram.Width = "100%";
            Diagram.RulerSettings.ShowRulers = true;
            Diagram.RulerSettings.HorizontalRuler.Interval = 6;
            Diagram.RulerSettings.HorizontalRuler.ArrangeTick = "arrangeTick";
            Diagram.RulerSettings.VerticalRuler.Interval = 6;
            Diagram.RulerSettings.VerticalRuler.ArrangeTick = "arrangeTick";
            CreateRularNode("NewIdea", 150, 60, 300, 60, "New idea identified", FlowShapes.Terminator,Diagram);
            CreateRularNode("Meeting", 150, 60, 300, 155, "Meeting with board", FlowShapes.Process, Diagram);
            CreateRularNode("BoardDecision", 150, 110, 300, 280, "Board decides \nwhether \nto proceed", FlowShapes.Decision, Diagram);
            CreateRularNode("Project", 150, 100, 300, 430, "Find Project \nmanager", FlowShapes.Decision, Diagram);
            CreateRularNode("End", 150, 60, 300, 555, "Implement and Deliver", FlowShapes.Process, Diagram);
            CreateRularNode("Decision", 250, 60, 550, 60, "Decision Process for new software ideas", FlowShapes.Card, Diagram);
            CreateRularNode("Reject", 150, 60, 550, 285, "Reject and write report", FlowShapes.Process, Diagram);
            CreateRularNode("Resources", 150, 60, 550, 430, "Hire new resources", FlowShapes.Process, Diagram);

            createRulerConnector("connector1", "NewIdea", "Meeting", null,Diagram);
            createRulerConnector("connector2", "Meeting", "BoardDecision", null, Diagram);
            createRulerConnector("connector3", "BoardDecision", "Project", "Yes", Diagram);
            createRulerConnector("connector4", "Project", "End", "Yes", Diagram);
            createRulerConnector("connector5", "BoardDecision", "Reject", "No", Diagram);
            createRulerConnector("connector6", "Project", "Resources", "No", Diagram);
        }
        
        
        public void CreateRularNode(string name, double width, double height, double offsetX, double offsetY, string text, FlowShapes shape, DiagramProperties model)
        {
            FlowShape node = new FlowShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetX;
            node.OffsetY = offsetY;
            if (node.Name == "Decision")
            {
                node.FillColor = "#858585";
                node.BorderColor = "#858585";
            }
            else
            {
                node.FillColor = "#1BA0E2";
                node.BorderColor = "#1BA0E2";
            }
            node.Type = Shapes.Flow;
            node.Shape = shape;
            node.Labels.Add(new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label { Text = text, FontColor = "white" });
            model.Nodes.Add(node);
        }

        public void createRulerConnector(string name, string sourceNode, string targetNode, string text, DiagramProperties model)
        {
            Connector connector = new Connector();
            connector.Name = name;
            connector.SourceNode = sourceNode;
            connector.TargetNode = targetNode;
            connector.LineColor = "#606060";
            connector.Labels.Add(new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label { Text = text, FillColor = "white" });
            model.Connectors.Add(connector);
        }
    }
}
