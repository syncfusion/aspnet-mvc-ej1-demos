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
        public ActionResult Network()
        {
            DiagramProperties Diagram = new DiagramProperties();
            SymbolPaletteProperties symbolPalette = new SymbolPaletteProperties();
            createSymbolPaletteNetwork(symbolPalette);
            GenerateNaiveShapes(symbolPalette);
            createSymbolPaletteNode(symbolPalette);
            GenerateDiagram1(Diagram);
            Diagram.Create = "created";
            ViewData["diagramModel"] = Diagram;
            ViewData["symbolPaletteModel"] = symbolPalette;
            return View();
        }
        public void createSymbolPaletteNetwork(SymbolPaletteProperties symbolpalette)
        {
            symbolpalette.Height = "100%";
            symbolpalette.Width = "100%";
            symbolpalette.PaletteItemHeight = 51;
            symbolpalette.PaletteItemWidth = 51;
            symbolpalette.PreviewHeight = 100;
            symbolpalette.PreviewWidth = 100;
            symbolpalette.SelectedPaletteName = "network Shapes";
            symbolpalette.ShowPaletteItemText = false;
            symbolpalette.DiagramId = "DiagramContent";
        }
        private void GenerateNativeShape(Palette Palette, string name, int height, int width, string tempid, int offsetX, int offsetY)
        {
            NativeNode native = new NativeNode();
            native.Width = height;
            native.Height = width;
            native.OffsetX = offsetX;
            native.OffsetY = offsetY;
            native.TemplateId = tempid;
            native.BorderColor = "transparent";
            native.Scale = ScaleConstraints.Stretch; ;
            Palette.Items.Add(native);
        }
        public void GenerateNaiveShapes(SymbolPaletteProperties symbolpalette)
        {
            Palette swimlaneShapes = new Palette("Native Shapes");
            GenerateNativeShape(swimlaneShapes, "native", 40, 40, "svgTemplate7", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native1", 40, 40, "svgTemplate8", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native2", 40, 40, "svgTemplate6", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native3", 25, 40, "svgTemplate4", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native4", 40, 40, "svgTemplate3", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native5", 40, 40, "svgTemplate5", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native6", 40, 40, "svgTemplate1", 100, 100);
            GenerateNativeShape(swimlaneShapes, "native7", 40, 40, "svgTemplate2", 100, 100);
            swimlaneShapes.AppendChild(CreateDiagramNode("arrow1", 100, 100, "white", "", 100, 100, true));
            symbolpalette.Palettes.Add(swimlaneShapes);
        }
        public void createSymbolPaletteNode(SymbolPaletteProperties symbolpalette)
        {
            Palette connectors = new Palette("Connectors");
            connectors.Expanded = true;
            Collection segments = new Collection();
            Segment seg = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Segment(Segments.Orthogonal);
            segments.Add(seg);
            connectors.Items.Add(new Connector { Name = "link1", Segments = segments, SourcePoint = new DiagramPoint(0, 0), TargetPoint = new DiagramPoint(40, 40), LineWidth = 1 });
            segments = new Collection();
            seg = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Segment(Segments.Straight);
            segments.Add(seg);
            connectors.Items.Add(new Connector { Name = "link2", Segments = segments, SourcePoint = new DiagramPoint(0, 0), TargetPoint = new DiagramPoint(40, 40), LineWidth = 1 });
            symbolpalette.Palettes.Add(connectors);
        }
        public void GenerateDiagram1(DiagramProperties DiagramContent)
        {
            DiagramContent.Height = "100%";
            DiagramContent.Width = "100%";
            DiagramContent.SnapSettings.SnapConstraints = SnapConstraints.None;
            GenerateDiagramNodes(DiagramContent);
            GenerateDiagramConnectors(DiagramContent);
        }
        private void GenerateDiagramNodes(DiagramProperties DiagramContent)
        {
            DiagramContent.Nodes.Add(GenerateDiagramNode("server1", 50, 65, 130, 75, "svgTemplate7", "server", "Bottom", 10, 0F, 0F, "port"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("server2", 50, 65, 80, 75, "svgTemplate7", "", "", 0, 0.5f, 0.5f, "port"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("WorkStation1", 60, 70, 250, 75, "svgTemplate8", "WorkStation", "Bottom", 10, 1.4f, 0.2f, "port2"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("WorkStation2", 60, 75, 350, 75, "svgTemplate8", "", "", 0, 0.5f, 0.5f, "port2"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("modem1", 40, 40, 450, 125, "svgTemplate6", "Modem", "Right", 20, 0f, 0.5f, "portmo"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("modem2", 40, 40, 525, 175, "svgTemplate6", "Modem1", "Bottom", 10, 0.5f, 0f, "portmo"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("RemoteController1", 25, 50, 600, 125, "svgTemplate4", "RemoteController", "Bottom", 10, 0.5f, 0f, "portrc"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("modem3", 40, 40, 350, 205, "svgTemplate6", "Modem4", "Left", 25, 1f, 0.5f, "portmo"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("modem4", 40, 40, 450, 245, "svgTemplate6", "Modem2", "", 0, 0.5f, 1.2f, "portmo"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("modem5", 40, 40, 350, 330, "svgTemplate6", "Modem3", "Right", 25, 0f, 0.5f, "portmo"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("WorkStation3", 60, 70, 600, 250, "svgTemplate8", "RemoteWorkstation", "Bottom", 7, 0.5f, 0, "port2"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("WorkStation4", 60, 70, 600, 335, "svgTemplate8", "PortableWorkstation", "Top", 7, 0.5f, 1f, "port2"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("RemoteController2", 25, 50, 70, 400, "svgTemplate4", "ControlLogic", "Top", 8, 0.5f, 1f, "portrc"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("RemoteController3", 25, 50, 500, 400, "svgTemplate4", "ControlLogic1", "Top", 8, 0.5f, 1f, "portrc"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("AnalogIO", 40, 50, 160, 500, "svgTemplate5", "AnalogIO", "Top", 13, 0.5f, 1f, "port"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("sensor", 50, 55, 260, 510, "svgTemplate1", "sensor", "Right", 15, 0.7f, 1f, "portws"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("DeviceDriver1", 40, 50, 360, 500, "svgTemplate2", "Driver", "", 0, 0.5f, 1.2f, "port"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("DeviceDriver2", 40, 50, 460, 500, "svgTemplate2", "Driver", "", 0, 0.5f, 1.2f, "port"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("DeviceDriver3", 40, 50, 550, 500, "svgTemplate2", "Driver", "", 0, 0.5f, 1.2f, "port"));
            DiagramContent.Nodes.Add(GenerateDiagramNode("HMI", 40, 50, 625, 450, "svgTemplate3", "HMI", "", 0, 0.5f, 1.2f, "portmo"));
            DiagramContent.Nodes.Add(CreateTextNode("controlNet", 127, 40, "Control Net", 218.5, 380));
            DiagramContent.Nodes.Add(CreateTextNode("etherNet", 127, 40, "Ethernet", 218.5, 190));
            DiagramContent.Nodes.Add(CreateTextNode("deviceNet", 127, 40, "Device Net", 345.5, 575));
        }
        private Node GenerateDiagramNode(string name, int width, int height, int OffsetX, int OffsetY, string templateId, string text, string MPosition, int Mvalue, float labelX, float labelY, string port)
        {
            NativeNode node = new NativeNode();
            node.Name = name;
            node.Height = height;
            node.Width = width;
            node.OffsetX = OffsetX;
            node.OffsetY = OffsetY;
            node.BorderColor = "transparent";
            node.TemplateId = templateId;
            node.Scale = ScaleConstraints.Stretch;
            var label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label { Text = text, FontColor = "black",FontSize=11};
            label.Margin = new LabelMargin();
            if ((MPosition == "Bottom"))
            {
                label.Margin.Bottom = Mvalue;
            }
            else if ((MPosition == "Right"))
            {
                label.Margin.Right = Mvalue;
            }
            else if ((MPosition == "Top"))
            {
                label.Margin.Top = Mvalue;
            }
            else if ((MPosition == "Left"))
            {
                label.Margin.Left = Mvalue;
            }
            label.Offset = new DiagramPoint(labelX, labelY);
            node.Labels.Add(label);
            if (port == "port2")
            {
                node.Ports.Add(AddPorts("port1", 0.5f, 0.5f, PortShapes.Square));
                node.Ports.Add(AddPorts("port2", 0.88f, 0.5f, PortShapes.Square));
                node.Ports.Add(AddPorts("port3", 0.5f, 0.9f, PortShapes.Square));
            }
            else if (port == "portmo")
            {
                node.Ports.Add(AddPorts("port1", 0.15f, 0.6f, PortShapes.Square));
                node.Ports.Add(AddPorts("port2", 0.85f, 0.6f, PortShapes.Square));
                node.Ports.Add(AddPorts("port3", 0.5f, 0.4f, PortShapes.Square));
                node.Ports.Add(AddPorts("port4", 0.5f, 0.85f, PortShapes.Square));
            }
            else if (port == "portrc")
            {
                node.Ports.Add(AddPorts("port1", 0.2f, 0.5f, PortShapes.Square));
                node.Ports.Add(AddPorts("port2", 0.85f, 0.5f, PortShapes.Square));
                node.Ports.Add(AddPorts("port3", 0.88f, 0.16f, PortShapes.Square));
                node.Ports.Add(AddPorts("port4", 0.6f, 0.9f, PortShapes.Square));
            }
            else if (port == "portws")
            {
                node.Ports.Add(AddPorts("port1", 0.5f, 0.15f, PortShapes.Square));
                node.Ports.Add(AddPorts("port2", 0.4f, 0.8f, PortShapes.Square));
                node.Ports.Add(AddPorts("port3", 0.5f, 0.2f, PortShapes.Square));
            }
            else if (port == "port")
            {
                node.Ports.Add(AddPorts("port1", 0.05f, 0.5f, PortShapes.Square));
                node.Ports.Add(AddPorts("port2", 0.8f, 0.6f, PortShapes.Square));
                node.Ports.Add(AddPorts("port3", 0.5f, 0.15f, PortShapes.Square));
                node.Ports.Add(AddPorts("port4", 0.5f, 0.85f, PortShapes.Square));
            }
            return node;
        }
        public Port AddPorts(string name, float offsetX, float offsetY, PortShapes shape)
        {
            Port port = new Port();
            port.Name = name;
            port.Offset = new DiagramPoint(offsetX, offsetY);
            port.Visibility = PortVisibility.Hidden;
            port.Shape = shape;
            port.BorderColor = "transparent";
            port.ConnectorPadding = 4;
            return port;
        }
        private Node CreateDiagramNode(string name, int width, int height, string fillColor, string text, int x, int y, bool path)
        {
            BasicShape node = new BasicShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.FillColor = fillColor;
            node.OffsetX = x;
            node.OffsetY = y;
            node.BorderColor = "black";
            node.Labels.Add(new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label { Text = text, FontSize = 11 });
            if (path)
            {
                node.Shape = BasicShapes.Path;
                node.PathData = "M 0 26.4576 L 26.4576 0 L 26.4576 0 L 26.4576 17.46239 L 26.4576 17.46239 L 113.3856 17.46239 L 113.3856 17.46239 L 113.3856 35.45279 L 113.3856 35.45279 L 26.4576 35.45279 L 26.4576 35.45279 L 26.4576 52.91519 L 26.4576 52.91519 L 0 26.4576 Z";
            }
            return node;
        }
        private Node CreateTextNode(string name, int width, int height, string text, double x, int y)
        {
            TextNode node = new TextNode();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.TextBlock = (new TextBlock { Text = text, Bold = true, FontSize = 16 });
            node.OffsetX = x;
            node.OffsetY = y;
            node.BorderColor = "black";
            return node;
        }
        private void GenerateDiagramConnectors(DiagramProperties DiagramContent)
        {
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector1", "server1", "WorkStation1", false, "", "port1"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector2", "WorkStation1", "WorkStation2", false, "port2", "port1"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector3", "WorkStation2", "modem1", true, "port2", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector4", "modem2", "modem1", true, "port1", "port4"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector5", "modem2", "RemoteController1", true, "port2", "port1"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector6", "WorkStation2", "modem3", false, "port3", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector7", "modem4", "modem3", true, "port1", "port4"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector8", "modem5", "modem3", false, "port3", "port4"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector9", "modem5", "WorkStation4", false, "port2", "port1"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector10", "modem4", "WorkStation3", false, "port2", "port1"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector11", "RemoteController2", "RemoteController3", false, "", "port1"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector12", "server2", "RemoteController2", false, "port4", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector13", "modem3", "server2", true, "port1", "port4"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector14", "RemoteController2", "AnalogIO", true, "port2", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector15", "RemoteController2", "sensor", true, "port2", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector16", "RemoteController2", "DeviceDriver1", true, "port2", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector17", "RemoteController2", "DeviceDriver2", true, "port2", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector18", "HMI", "DeviceDriver3", true, "port1", "port3"));
            DiagramContent.Connectors.Add(GenerateDiagramConnector("connector19", "HMI", "DeviceDriver2", true, "port1", "port3"));
        }
        private Connector GenerateDiagramConnector(string name, string sName, string Tname, bool segment, string sPort, string tPort)
        {
            Connector connector = new Connector();
            connector.Name = name;
            connector.SourceNode = sName;
            if (sPort != "")
            {
                connector.SourcePort = sPort;
            }
            connector.TargetNode = Tname;
            if (tPort != "")
            {
                connector.TargetPort = tPort;
            }
            connector.LineColor = "#606060";
            Decorator decorator = new Decorator();
            decorator.Shape = DecoratorShapes.Arrow;
            decorator.BorderColor = "#606060";
            decorator.Width = 8;
            decorator.Height = 8;
            connector.TargetDecorator = decorator;
            if (segment)
            {
                connector.Segments.Add(new Segment() { Type = Segments.Orthogonal });
            }
            return connector;
        }
    }
}