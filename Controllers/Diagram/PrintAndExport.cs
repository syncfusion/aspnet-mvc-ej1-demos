#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        public ActionResult PrintAndExport()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "400px";
            model.Width = "750px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.SnapSettings.SnapConstraints = SnapConstraints.All;

            BPMNNode node = CreateBPMN(model, "node1", BPMNShapes.Event, 60, 60, 55, 200, "Select Support Ticket");
            node.Event = BPMNEvents.Start;

            CreateBPMN(model, "node2", BPMNShapes.Activity, 75, 70, 190, 200, "Handle Support Ticket");
            node.Activity = BPMNActivity.Task;
            node = CreateBPMN(model, "node3", BPMNShapes.Gateway, 75, 70, 355, 200, "");
            node.Gateway = BPMNGateways.Exclusive;

            node = CreateBPMN(model, "node4", BPMNShapes.Activity, 75, 70, 530, 90, "Respond to customer");
            node.Activity = BPMNActivity.Task;
            node.Task.Type = BPMNTasks.Service;

            node = CreateBPMN(model, "node5", BPMNShapes.Activity, 75, 70, 530, 200, "Close ticket");
            node.Activity = BPMNActivity.Task;
            node.Task.Type = BPMNTasks.Service;

            node = CreateBPMN(model, "node6", BPMNShapes.Activity, 75, 70, 530, 300, "Escalate ticket");
            node.Activity = BPMNActivity.Task;
            node.Task.Type = BPMNTasks.Service;

            node = CreateBPMN(model, "node7", BPMNShapes.Event, 60, 60, 660, 90, "");
            node.Event = BPMNEvents.End;

            node = CreateBPMN(model, "node8", BPMNShapes.Event, 60, 60, 660, 200, "");
            node.Event = BPMNEvents.End;

            node = CreateBPMN(model, "node9", BPMNShapes.Event, 60, 60, 660, 300, "");
            node.Event = BPMNEvents.End;

            ConnBPMNNode(model, "node1", "node2");

            ConnBPMNNode(model, "node2", "node3");

            Collection segments = new Collection() { 
                new Segment(){Type=Segments.Orthogonal, Length=75, Direction="top"},
                new Segment(){Type=Segments.Orthogonal, Length=85, Direction="right"},
            };
            Label label = new Label() { Text = "Respond", FillColor = "white", Wrapping = TextWrapping.Wrap };
            ConnBPMNNode(model, "node3", "node4",segments,label);
            
            
            label = new Label() { Text = "Close", FillColor = "white", Wrapping = TextWrapping.Wrap };
            segments = new Collection() { 
                new Segment(){Type=Segments.Orthogonal, Length=15, Direction="right"},
            };
            ConnBPMNNode(model, "node3", "node5", segments, label);
            

            label = new Label() { Text = "Escalate", FillColor = "white" };
            segments = new Collection() { 
                new Segment(){Type=Segments.Orthogonal, Length=65, Direction="bottom"},
                new Segment(){Type=Segments.Orthogonal, Length=75, Direction="right"},
            };
            ConnBPMNNode(model, "node3", "node6", segments, label);
            

            ConnBPMNNode(model, "node4", "node7");

            ConnBPMNNode(model, "node5", "node8");
            ConnBPMNNode(model, "node6", "node9");

            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            ViewData["diagramModel"] = model;
            return View();
        }
        private BPMNNode CreateBPMN(DiagramProperties model, String name, BPMNShapes shape, double width, double height, double offsetx, double offsety, string text = "")
        {
            BPMNNode node = new BPMNNode();
            node.Name = name;
            node.Shape = shape;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            Label label = new Label();
            label.Text = text;
            label.FontColor = "black";
            if (shape == BPMNShapes.Event && shape == BPMNShapes.Activity && text != "")
            {
                label.Offset = new DiagramPoint() { Y = 1 };
                label.VerticalAlignment = VerticalAlignment.Top;
            }
            else label.Offset = new DiagramPoint() { Y = 0.5f };
            node.Labels.Add(label);
            model.Nodes.Add(node);
            return node;
        }
        private void ConnBPMNNode(DiagramProperties model, string sourceNode, string targetNode, Collection segments = null, Label label = null)
        {
            Connector connector = new Connector();
            connector.TargetNode = targetNode;
            connector.SourceNode = sourceNode;
            if (segments == null) segments = new Collection() { new Segment() { Type = Segments.Orthogonal } };
            connector.Segments = segments; 
            if (label != null)
            {
                label.FillColor = "white";
                connector.Labels = new Collection() { label };
            }
            model.Connectors.Add(connector);

        }
    }
}