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
        // GET: /Connector/
        public ActionResult Connector()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "550px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            
            model.SelectionChange = "selectionChanged";


            //Initialize shapes
            CreateFlowShape("node1", FlowShapes.Terminator, 90, 40, 80, 90, "Start", model);
            CreateFlowShape("node2", FlowShapes.Decision, 130, 100, 260, 90, "Already installed the software?", model);
            CreateFlowShape("node3", FlowShapes.Process, 100, 50, 440, 90, "Show license agreement", model);
            CreateFlowShape("node4", FlowShapes.Decision, 90, 80, 620, 90, "Agreed?", model);
            CreateFlowShape("node5", FlowShapes.Decision, 130, 100, 260, 240, "Can override existing version?", model);
            CreateFlowShape("node6", FlowShapes.Process, 90, 50, 620, 240, "Select destination folder", model);
            CreateFlowShape("node7", FlowShapes.Decision, 110, 100, 620, 410, "Enough disk space?", model);
            CreateFlowShape("node8", FlowShapes.Process, 90, 50, 440, 410, "Free Space", model);
            FlowShape target = CreateFlowShape("node9", FlowShapes.Process, 90, 50, 260, 410, "Copy files", model, true);
            CreateFlowShape("node10", FlowShapes.Terminator, 90, 40, 80, 410, "End", model);


            //Connect Shapes
            ConnectShapes(model, "node1", "node2");
            ConnectShapes(model, "node2", "node3", null, new Label() { Text = "No" });
            ConnectShapes(model, "node3", "node4");

            Collection segments = new Collection() {
                new Segment(){Type=Segments.Orthogonal, Length=30, Direction="right"},
                new Segment(){Type=Segments.Orthogonal, Length=80, Direction="bottom"},
                new Segment(){Type=Segments.Orthogonal, Length=620, Direction="left"},
                new Segment(){Type=Segments.Orthogonal, Length=220, Direction="bottom"}
            };
            Label label = new Label() { Text = "No", FillColor = "white", Offset = new DiagramPoint(0.44f, 0.27f) };
            ConnectShapes(model, "node4", "node10", segments, label);

            label = new Label() { Text = "Yes", FillColor = "white", Offset = new DiagramPoint(0.2f, 0.2f) };
            ConnectShapes(model, "node2", "node5", null, label);

            label = new Label() { Text = "Yes", FillColor = "white", Offset = new DiagramPoint(0.2f, 0.2f) };
            ConnectShapes(model, "node4", "node6", null, label);

            ConnectShapes(model, "node6", "node7");
            ConnectShapes(model, "node7", "node8", null, new Label() { Text = "No" });

            Label label4 = new Label() { Text = "No", FillColor = "white" };
            ConnectShapes(model, "node8", "node9");

            ConnectShapes(model, "node9", "node10");

            segments = new Collection() { 
            new Segment(){Type=Segments.Orthogonal, Length=20, Direction="left"},
            new Segment(){Type=Segments.Orthogonal, Length=72, Direction="bottom"},
            new Segment(){Type=Segments.Orthogonal, Length=20, Direction="right"}
            };
            label = new Label() { Text = "Yes", FillColor = "white", Offset = new DiagramPoint(0.01f, 0.38f) };
            ConnectShapes(model, "node5", "node9", segments, label, (target.Ports[0] as Port).Name);

            segments = new Collection() { 
                new Segment(){Type=Segments.Orthogonal, Length=20, Direction="right"},
                new Segment(){Type=Segments.Orthogonal, Length=97, Direction="top"},
                new Segment(){Type=Segments.Orthogonal, Length=426, Direction="left"}
            };
            label = new Label() { Text = "Yes", FillColor = "white", Offset = new DiagramPoint(0.22f, 0.01f) };
            ConnectShapes(model, "node7", "node9", segments, label, (target.Ports[1] as Port).Name);

            ViewData["diagramModel"] = model;
            return View();
        }

        private FlowShape CreateFlowShape(String name, FlowShapes shape, double width, double height, double offsetx, double offsety, string labelText, DiagramProperties model, bool addPorts = false)
        {
            FlowShape node = new FlowShape();
            node.Name = name;
            node.Width = width;
            node.Shape = shape;
            node.Height = height;
            node.OffsetX = offsetx;
            node.BorderColor = "#000000";
            node.FillColor = "#6bbd45";
            node.OffsetY = offsety;
            node.Constraints = NodeConstraints.Default & ~NodeConstraints.Drag;
            Label label = new Label();
            label.Margin = new LabelMargin() { Bottom = 2, Top = 2, Left = 20, Right = 20 };
            label.Text = labelText;
            label.FontColor = "white";
            label.Name = name + "_label";
            node.Labels.Add(label);
            if (addPorts) AddPorts(node);
            model.Nodes.Add(node);
            return node;
        }

        private void AddPorts(FlowShape node)
        {
            Port port = new Port();
            port.Name = "in";
            port.Offset = new DiagramPoint(0.4f, 0.01f);
            port.Shape = PortShapes.Circle;
            node.Ports.Add(port);
            Port port1 = new Port();
            port1.Name = "inn";
            port1.Offset = new DiagramPoint(0.6f, 0.01f);
            port1.Shape = PortShapes.Circle;
            node.Ports.Add(port1);
        }

        private void ConnectShapes(DiagramProperties model, string sourceNode, string targetNode, Collection segments = null, Label label = null, string targetPort = "")
        {
            Connector connector = new Connector();
            connector.Name = "line" + model.Connectors.Count + 1;
            connector.TargetNode = targetNode;
            connector.SourceNode = sourceNode;
            connector.TargetPort = targetPort;
            connector.CornerRadius = 10;
            connector.LineWidth = 2;
            connector.Constraints = ConnectorConstraints.Default | ConnectorConstraints.Bridging;
            if (segments == null) segments = new Collection() { new Segment() { Type = Segments.Orthogonal } };
            connector.Segments = segments;
            connector.AddInfo = new Dictionary<string, object> { 
                {"segments", segments}
            };
            if (label != null)
            {
                label.FillColor = "white";
                connector.Labels = new Collection() { label };
            }
            model.Connectors.Add(connector);
        }
    }
}