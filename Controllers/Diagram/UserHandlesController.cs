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
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {

        // GET: /UserHandles/
        List<ColorData> colors = new List<ColorData>();
        public ActionResult UserHandles()
        {
            colors.Add(new ColorData { value = "Black", text = "Black" });
            colors.Add(new ColorData { value = "White", text = "White" });
            colors.Add(new ColorData { value = "Goldenrod", text = "Goldenrod" });
            colors.Add(new ColorData { value = "Indigo", text = "Indigo" });
            colors.Add(new ColorData { value = "DarkGoldenRod", text = "DarkGoldenRod" });
            colors.Add(new ColorData { value = "FireBrick", text = "FireBrick" });
            colors.Add(new ColorData { value = "DarkRed", text = "DarkRed" });
            colors.Add(new ColorData { value = "Khaki", text = "Khaki" });
            colors.Add(new ColorData { value = "LightCoral", text = "LightCoral" });
            colors.Add(new ColorData { value = "Moccasin", text = "Moccasin" });
            colors.Add(new ColorData { value = "Teal", text = "Teal" });

            DiagramProperties model = new DiagramProperties();
            model.Height = "600px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.SelectionChange = "selectionChanged";
            model.DefaultSettings.Node = new Node()
            {
                BorderColor = "black",
                Labels = new Collection()
                {
                    new Label(){ FontColor="white"}
                }
            };
            model.DefaultSettings.Connector = new Connector()
            {
                TargetDecorator = new Decorator()
                {
                    Shape = DecoratorShapes.Arrow,
                    BorderColor = "black",
                    Width = 5,
                    Height = 10
                },
                Segments = new Collection()
                {
                    new Segment() { 
                        Type= Segments.Orthogonal 
                    }
                },

            };

            CreateBPMNNode( model, "node1", BPMNShapes.Event, 40, 40, 85, 230, 0, 0, "");

            BPMNNode node = CreateBPMNNode(model, "node2", BPMNShapes.Activity, 520, 250, 405, 230, 0, 0, "");
            node.Activity = BPMNActivity.SubProcess;
            node.SubProcess.Collapsed = false;
            node.SubProcess.Type = BPMNSubProcessTypes.Transaction;
            node.SubProcess.Events = new Collection() {
                new BPMNEvent(){ Event = BPMNEvents.Intermediate, Name="intermediateerror", Trigger=BPMNTriggers.Error, Offset = new DiagramPoint() { X= 0.25f, Y=1 } },
                new BPMNEvent(){ Event = BPMNEvents.Intermediate, Name="intermediatecancel", Trigger=BPMNTriggers.Cancel, Offset = new DiagramPoint() {X= 0.75f, Y=1 } }
            };
            Collection Processes = new Collection();
            Processes.Add(new BPMNNode()
            {
                Name = "subnode01",
                MarginLeft = 20,
                MarginTop = 40,
                Height = 30,
                Width = 30,
                Shape = BPMNShapes.Event
            });
            Collection label = new Collection() { new Label() { Text = "book hotel", Offset = new DiagramPoint(0.5f, 0.5f) } };
            BPMNTask task = new BPMNTask()
            {
                Type= BPMNTasks.Service,
                Loop = BPMNLoops.ParallelMultiInstance,
            };
            Processes.Add(new BPMNNode()
            {
                Name = "subnode02",
                MarginLeft = 110,
                MarginTop = 20,
                Width = 95,
                Height = 70,
                FillColor = "#6FAAB0",
                Shape = BPMNShapes.Activity,
                Activity = BPMNActivity.Task,
                Task = task,
                Labels = label
            });
            Processes.Add(new BPMNNode()
            {
                Name = "subnodecompensation",
                MarginLeft = 170,
                MarginTop = 75,
                Width = 30,
                Height = 30,
                Shape = BPMNShapes.Event,
                Event = BPMNEvents.Intermediate,
                Trigger = BPMNTriggers.Compensation

            });
            label = new Collection() { new Label() { Text = "charge credit card", Offset = new DiagramPoint(0.5f, 0.6f) } };
            task = new BPMNTask()
            {
                Type = BPMNTasks.Service
            };
            Processes.Add(new BPMNNode()
            {
                Name = "subnode03",
                MarginLeft = 290,
                MarginTop = 20,
                Width = 95,
                Height = 70,
                FillColor = "#F6B53F",
                Shape = BPMNShapes.Activity,
                Labels = label,
                Activity = BPMNActivity.Task,
                Task = task
            });
            Processes.Add(new BPMNNode()
            {
                Name = "subnodeerror",
                MarginLeft = 350,
                MarginTop = 75,
                Width = 30,
                Height = 30,
                Shape = BPMNShapes.Event,
                Event = BPMNEvents.Intermediate,
                Trigger = BPMNTriggers.Error
            });
            Processes.Add(new BPMNNode()
            {
                Name = "subnode04",
                MarginLeft = 440,
                MarginTop = 40,
                Width = 30,
                Height = 30,
                Shape = BPMNShapes.Event,
                Event = BPMNEvents.End
            });
            label = new Collection() { new Label() { Text = "cancel hotel reservation", Offset = new DiagramPoint(0.5f, 0.5f) } };
            task = new BPMNTask()
            {
                 Type= BPMNTasks.User,
                 Compensation=true
            };
            Processes.Add(new BPMNNode()
            {
                Name = "subnode05",
                MarginLeft = 240,
                MarginTop = 130,
                Width = 90,
                Height = 80,
                FillColor = "#E94649",
                Shape = BPMNShapes.Activity,
                Activity = BPMNActivity.Task,
                Labels = label,
                Task = task
            });
            Processes.Add(new BPMNNode()
            {
                Name = "subnode06",
                MarginLeft = 440,
                MarginTop = 155,
                Width = 30,
                Height = 30,
                Shape = BPMNShapes.Event,
                Event = BPMNEvents.End
            });
            node.SubProcess.Processes = Processes;
            node = CreateBPMNNode(model, "node3", BPMNShapes.Event, 40, 40, 355, 420, 0, 0, "hazard");
            node.Event = BPMNEvents.End;
            node = CreateBPMNNode(model, "node4", BPMNShapes.Event, 40, 40, 595, 420, 0, 0, "cancelled");
            node.Event = BPMNEvents.End;
            node = CreateBPMNNode(model, "node5", BPMNShapes.Event, 40, 40, 715, 230, 0, 0, "successful");
            node.Event = BPMNEvents.End;

            ConnectBPMN(model, "node1", "node2");
            ConnectBPMN(model, "node2", "node5");
            Connector connector = ConnectBPMN(model, "intermediateerror", "node3");
            connector.Segments = new Collection() {
                new Segment()
                {
                    Type=Segments.Orthogonal, 
                    Length=50, 
                    Direction="bottom"
                }
            };
            connector.Labels = new Collection() { new Label() { Text = "Booking system failure", FillColor = "white", Offset = new DiagramPoint(0.5f, 0.5f) } };

            connector = ConnectBPMN(model, "intermediatecancel", "node4");
            connector.Segments = new Collection() {
                new Segment() {
                    Type=Segments.Orthogonal, 
                    Length=50, 
                    Direction="bottom"
                }
            };
            ConnectBPMN(model, "subnode01", "subnode02");
            ConnectBPMN(model, "subnode02", "subnode03");
            ConnectBPMN(model, "subnode03", "subnode04");

            connector = ConnectBPMN(model, "subnodecompensation", "subnode05");
            connector.Segments = new Collection() {
                new Segment(){Type=Segments.Orthogonal, Length=30, Direction="bottom"},
                new Segment(){Type=Segments.Orthogonal, Length=80, Direction="right"}
            };
            connector.Shape = new ConnectorShape()
            {
                Type = ConnectorShapes.BPMN,
                Flow = BPMNFlows.Association,
                Association = AssociationFlows.Directional
            };

            connector = ConnectBPMN(model, "subnodeerror", "subnode06");
            connector.Segments = new Collection() {
                new Segment()
                {
                    Type=Segments.Orthogonal, 
                    Length=50, 
                    Direction="bottom"
                }
            };
            connector.Labels = new Collection() { new Label() { Text = "cannot charge card", FillColor = "white", Offset = new DiagramPoint(0.75f, 0.55f) } };

            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            ViewData["diagramModel"] = model;
            ViewBag.datasource = colors;
            return View();
        }
        private BPMNNode CreateBPMNNode(DiagramProperties model, String name, BPMNShapes shape, double width, double height, double offsetx, double offsety, double marginleft, double margintop, string text = "")
        {
            BPMNNode node = new BPMNNode();
            node.Name = name;
            node.Shape = shape;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx - 60;
            node.OffsetY = offsety;
            node.MarginLeft = marginleft;
            node.MarginTop = margintop;
            Label label = new Label();
            label.Text = text;
            label.FontColor = "black";
            if (shape == BPMNShapes.Event && text != "")
            {
                label.Offset = new DiagramPoint() { Y = 1 };
                label.VerticalAlignment = VerticalAlignment.Top;
            }
            else label.Offset = new DiagramPoint() { Y = 0.5f };
            node.Labels.Add(label);
            model.Nodes.Add(node);
            return node;
        }
        private Connector ConnectBPMN(DiagramProperties model, string sourceNode, string targetNode, Collection segments = null, Label label = null)
        {
            Connector connector = new Connector();
            connector.TargetNode = targetNode;
            connector.SourceNode = sourceNode;
            connector.TargetDecorator.Width = 10;
            connector.TargetDecorator.Height = 10;
            if (segments == null) segments = new Collection() { new Segment() { Type = Segments.Orthogonal } };
            connector.Segments = segments;
            model.Connectors.Add(connector);
            return connector;
        }
    }
}