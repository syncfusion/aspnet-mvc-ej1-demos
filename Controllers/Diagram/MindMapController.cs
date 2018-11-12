using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /MindMap/
        Node root = new Node();
        public ActionResult MindMap()
        {
            DiagramProperties diagramModel = new DiagramProperties();
            diagramModel.Width = "100%";
            diagramModel.Height = "590px";
            diagramModel.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            root.OffsetX = 650;
            root.OffsetY = 325;
            diagramModel.Layout.Orientation = LayoutOrientations.LeftToRight;
            diagramModel.Layout.HorizontalSpacing = 30;
            diagramModel.Layout.VerticalSpacing = 60;
            diagramModel.Layout.Type = LayoutTypes.HierarchicalTree;
            diagramModel.SnapSettings.SnapConstraints = SnapConstraints.None;
            diagramModel.EnableContextMenu = false;
            diagramModel.Constraints = DiagramConstraints.Default & ~DiagramConstraints.Undoable;
            diagramModel.Create = "create";
            GenerateNodes(GetMindMapData(), diagramModel);
            ViewData["diagramModel"] = diagramModel;
            return View();
        }

        public Dictionary<string, object> GetMindMapData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MindMap.json"));
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            return requestArgs;
        }

        private Node GenerateNodes(Dictionary<string, object> requestArgs, DiagramProperties model)
        {
            Node node = addNode(requestArgs["type"].ToString(), requestArgs["text"].ToString(), requestArgs["fill"].ToString(), model);
            if (requestArgs["type"].ToString() == "root")
            {
                root = node;
                model.Layout.FixedNode = root.Name;
            }
            if (requestArgs.ContainsKey("branches"))
            {
                object[] branches = requestArgs["branches"] as object[];
                if (branches != null)
                {
                    foreach (object obj1 in branches)
                    {
                        Dictionary<string, object> branch = (Dictionary<string, object>)obj1;
                        Node child = GenerateNodes(branch, model);
                        Connect(node, child, model);
                    }
                }
            }
            return node;
        }

        //Adding  node
        private void InitializeNode(Node node, string type, string text, string fill, DiagramProperties model)
        {
            node.Name = "node_" + model.Nodes.Count;
            LabelMargin margin = new LabelMargin(5, 5, 5, 5);
            Label label = new Label();
            label.Text = text;
            label.Name = node.Name + "_label";
            label.Wrapping = TextWrapping.NoWrap;
            label.Margin = margin;
            label.Bold = true;
            label.FontFamily = "Segoe UI";
            node.Labels.Add(label);
            node.FillColor = fill;
            node.Visible = false;
            node.MinWidth = 50;
            node.MinHeight = 30;
            if (node is NativeNode) {
                (node as NativeNode).Scale = ScaleConstraints.Stretch;
            }
            node.Constraints = node.Constraints & ~(NodeConstraints.Drag | NodeConstraints.Rotate);
            if (type == "root")
            {
                node.Constraints = node.Constraints & ~NodeConstraints.Delete;
            }
            Dictionary<string, object> addInfo = new Dictionary<string, object>();
            addInfo.Add("type", type);
            node.AddInfo = addInfo;
            model.Nodes.Add(node);
        }

        private Node addNode(string type, string text, string fill, DiagramProperties model)
        {
            if (type == "right" || type == "left" || type == "root")
            {
                BasicShape node = new BasicShape();
                node.Ports.Add(GetPort(0, 0.5f, node));
                node.Ports.Add(GetPort(1, 0.5f, node));
                node.Shape = BasicShapes.Rectangle;
                node.CornerRadius = 5;
                InitializeNode(node, type, text, fill, model);
                return node;
            }
            else
            {
                NativeNode node = new NativeNode();
                node.Ports.Add(GetPort(0, 1, node));
                node.Ports.Add(GetPort(1, 1, node));
                node.TemplateId = "nativeContent";
                InitializeNode(node, type, text, fill, model);
                return node;
            }
        }

        //Adding a connection
        private void Connect(Node tail, Node head, DiagramProperties model)
        {
            Connector conn = new Connector();
            conn.Segments = new Collection();
            Segment seg = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Segment(Segments.Bezier);
            conn.Segments.Add(seg);
            conn.Constraints = conn.Constraints & ~(ConnectorConstraints.Select);
            conn.Name = "connector_" + model.Connectors.Count;
            conn.TargetNode = head.Name;
            conn.SourceNode = tail.Name;
            conn.Visible = false;
            Dictionary<string, object> addInfo = head.AddInfo as Dictionary<string, object>;
            if (addInfo["type"].ToString() == "right" || addInfo["type"].ToString() == "subright")
            {
                conn.SourcePort = (tail.Ports[1] as Port).Name;
                conn.TargetPort = (head.Ports[0] as Port).Name;
            }
            else if (addInfo["type"].ToString() == "left" || addInfo["type"].ToString() == "subleft")
            {
                conn.SourcePort = (tail.Ports[0] as Port).Name;
                conn.TargetPort = (head.Ports[1] as Port).Name;
            }
            conn.TargetDecorator.Shape = DecoratorShapes.None;
            model.Connectors.Add(conn);

        }

        //creating port
        private Port GetPort(float offsetx, float offsety, Node node)
        {

            Port port = new Port();
            port.Name = "port_" + node.Ports.Count;
            port.Offset = new DiagramPoint(offsetx, offsety);
            port.Visibility = PortVisibility.Hidden;
            return port;
        }

    }
}
