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
        public ActionResult Tooltip()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "450px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            BPMNNode node = CreateBPMNShape(model, "node1", BPMNShapes.Event, 60, 60, 95, 90, "Customer query", "Queries from the customer");
            node.Event = BPMNEvents.Start;
            node.Trigger = BPMNTriggers.Message;
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.InheritTooltip;
            node.Tooltip = new Tooltip() { TemplateId = "mouseovertoolTipId", Alignment = new Alignment() { Horizontal = HorizontalAlignment.Left }, Margin = new Margin() { Left = 180 } };

            CreateBPMNShape(model, "node2", BPMNShapes.Gateway, 75, 70, 200, 90, "Enough details?", "Whether the provided information is enough?");

            node = CreateBPMNShape(model, "node3", BPMNShapes.Activity, 60, 50, 325, 90, "Analyse", "Analysing the query");
            node.Activity = BPMNActivity.Task;

            node = CreateBPMNShape(model, "node4", BPMNShapes.Gateway, 75, 70, 450, 90, "", "");
            node.Gateway = BPMNGateways.Exclusive;
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.InheritTooltip;

            CreateBPMNShape(model, "node5", BPMNShapes.Gateway, 75, 70, 610, 90, "Validate", "Whether the reported/requested bug/feature is valid?");

            node = CreateBPMNShape(model, "node6", BPMNShapes.Event, 60, 60, 715, 90, "", "Send the invalid message to customer");
            node.Event = BPMNEvents.End;
            node.Trigger = BPMNTriggers.Message;
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.InheritTooltip;
            node.Tooltip = new Tooltip() { TemplateId = "mouseovertoolTipId", Alignment = new Alignment() { Horizontal = HorizontalAlignment.Left }, Margin = new Margin() { Left = 80 } };

            node = CreateBPMNShape(model, "node7", BPMNShapes.Activity, 60, 50, 200, 200, "Request", "Requesting for more information");

            node.Activity = BPMNActivity.Task;
            node.Task.Type = BPMNTasks.Send;

            node = CreateBPMNShape(model, "node8", BPMNShapes.Event, 60, 60, 450, 200, "", "Share the User Guide/Knowledge Base link");
            node.Event = BPMNEvents.End;
            node.Trigger = BPMNTriggers.Message;

            node = CreateBPMNShape(model, "node9", BPMNShapes.Activity, 70, 50, 610, 200, "Log bug/feature", "Log the bug/feature");
            node.Activity = BPMNActivity.Task;

            node = CreateBPMNShape(model, "node10", BPMNShapes.Activity, 75, 55, 450, 300, "Implement", "Fix the bug/Add the feature");
            node.Activity = BPMNActivity.SubProcess;
            node.SubProcess.Collapsed = false;
            node.SubProcess.Events = new Collection() { 
            new BPMNEvent(){Event = BPMNEvents.Intermediate, Trigger=BPMNTriggers.Timer,Offset = new DiagramPoint() {X= 0.5f,Y=1} }};

            node = CreateBPMNShape(model, "node12", BPMNShapes.Event, 60, 60, 325, 300, "", "Provide the solution");
            node.Event = BPMNEvents.End;
            node.Trigger = BPMNTriggers.Message;

            node = CreateBPMNShape(model, "node13", BPMNShapes.Event, 60, 60, 715, 300, "", "Share the task details");
            node.Event = BPMNEvents.End;
            node.Trigger = BPMNTriggers.Message;
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.InheritTooltip;
            node.Tooltip = new Tooltip() { TemplateId = "mouseovertoolTipId", Alignment = new Alignment() { Horizontal = HorizontalAlignment.Left }, Margin = new Margin() { Left = 70 } };

            node = CreateBPMNShape(model, "node14", BPMNShapes.Gateway, 60, 60, 610, 300, "", "");
            node.Gateway = BPMNGateways.Parallel;
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.InheritTooltip;

            ConnectBPMNNodes(model, "node1", "node2");

            ConnectBPMNNodes(model, "node2", "node3");

            ConnectBPMNNodes(model, "node3", "node4");

            Label label = new Label() { Text = "Feature/ Bug", FillColor = "white", Offset = new DiagramPoint(0.5f, 0.9f), Wrapping = TextWrapping.Wrap };
            ConnectBPMNNodes(model, "node4", "node5", null, label);

            label = new Label() { Text = "Invalid", FillColor = "white", Offset = new DiagramPoint(0.5f, 0.050f) };
            ConnectBPMNNodes(model, "node5", "node6", null, label);

            ConnectBPMNNodes(model, "node2", "node7");

            label = new Label() { Text = "How to?", FillColor = "white", Offset = new DiagramPoint(0.5f, 0.5f) };
            ConnectBPMNNodes(model, "node4", "node8", null, label);

            ConnectBPMNNodes(model, "node5", "node9");
            ConnectBPMNNodes(model, "node14", "node13");

            Collection segments = new Collection() { 
                new Segment(){Type=Segments.Orthogonal, Length=100, Direction="right"},
                new Segment(){Type=Segments.Orthogonal, Length=100, Direction="top"},
            };
            ConnectBPMNNodes(model, "node7", "node3", segments);

            ConnectBPMNNodes(model, "node14", "node10");
            ConnectBPMNNodes(model, "node10", "node12");
            ConnectBPMNNodes(model, "node9", "node14");

            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.Tooltip = new Tooltip() { TemplateId = "mouseovertoolTipId" };
            ViewData["diagramModel"] = model;
            return View();
        }
        private BPMNNode CreateBPMNShape(DiagramProperties model, String name, BPMNShapes shape, double width, double height, double offsetx, double offsety, string text = "", string description = "")
        {
            BPMNNode node = new BPMNNode();
            node.Name = name;
            node.Shape = shape;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx - 60;
            node.OffsetY = offsety;
            Label label = new Label();
            label.Text = text;
            label.FontColor = "black";
            if (shape == BPMNShapes.Event && text != "")
            {
                label.Offset = new DiagramPoint() { Y = 1 };
                label.VerticalAlignment = VerticalAlignment.Top;
            }
            else label.Offset = new DiagramPoint() { Y = 0.5f };
            if (description != "") node.AddInfo = new Dictionary<string, object> { 
            {"Description", description}};
            node.Labels.Add(label);
            model.Nodes.Add(node);
            return node;
        }
        private void ConnectBPMNNodes(DiagramProperties model, string sourceNode, string targetNode, Collection segments = null, Label label = null)
        {
            Connector connector = new Connector();
            connector.TargetNode = targetNode;
            connector.SourceNode = sourceNode;
            connector.TargetDecorator.Width = 10;
            connector.TargetDecorator.Height = 10;
            if (segments == null) segments = new Collection() { new Segment() { Type = Segments.Orthogonal } };
            connector.Constraints = ConnectorConstraints.Default & ~ConnectorConstraints.InheritTooltip;
            connector.Segments = segments;
            model.Connectors.Add(connector);
        }
    }
}