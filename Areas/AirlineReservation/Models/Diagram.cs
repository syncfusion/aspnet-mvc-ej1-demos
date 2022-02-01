#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Areas.AirlineReservation.Models
{
    public class Diagram
    {
        private List<Node> AddDiagramContents()
        {
            List<Node> nodes = new List<Node>();
            CreateNode("seatD1", 150, 78, 26, 23, nodes);
            CreateNode("seatD2", 190, 78, 26, 23, nodes);
            CreateNode("seatD3", 230, 78, 26, 23, nodes);
            CreateNode("seatD4", 270, 78, 26, 23, nodes, "booked");
            CreateNode("seatD5_1", 375, 79, 20, 18, nodes);
            CreateNode("seatD5_2", 375, 96, 20, 18, nodes);
            CreateNode("seatD6_1", 415, 79, 20, 18, nodes);
            CreateNode("seatD6_2", 415, 96, 20, 18, nodes);
            CreateNode("seatD7_1", 494, 79, 20, 18, nodes);
            CreateNode("seatD7_2", 494, 96, 20, 18, nodes);
            CreateNode("seatD8_1", 532, 79, 20, 18, nodes);
            CreateNode("seatD8_2", 532, 96, 20, 18, nodes);
            CreateNode("seatD9_1", 570, 79, 20, 18, nodes);
            CreateNode("seatD9_2", 570, 96, 20, 18, nodes);

            CreateNode("seatC1", 165, 139, 26, 23, nodes, "booked");
            CreateNode("seatC2", 210, 139, 26, 23, nodes);
            CreateNode("seatC3", 255, 139, 26, 23, nodes);
            CreateNode("seatC4_1", 375, 131, 20, 18, nodes);
            CreateNode("seatC4_2", 375, 148, 20, 18, nodes);
            CreateNode("seatC5_1", 415, 131, 20, 18, nodes);
            CreateNode("seatC5-2", 415, 148, 20, 18, nodes);
            CreateNode("seatC6_1", 494, 131, 20, 18, nodes);
            CreateNode("seatC6_2", 494, 148, 20, 18, nodes);
            CreateNode("seatC7_1", 532, 131, 20, 18, nodes);
            CreateNode("seatC7_2", 532, 148, 20, 18, nodes);
            CreateNode("seatC8_1", 570, 131, 20, 18, nodes);
            CreateNode("seatC8_2", 570, 148, 20, 18, nodes);

            CreateNode("seatB1", 165, 168, 26, 23, nodes);
            CreateNode("seatB2", 210, 168, 26, 23, nodes);
            CreateNode("seatB3", 255, 168, 26, 23, nodes, "booked");
            CreateNode("seatB4_1", 375, 165, 20, 18, nodes);
            CreateNode("seatB4_2", 375, 183, 20, 18, nodes);
            CreateNode("seatB5_1", 415, 165, 20, 18, nodes);
            CreateNode("seatB5_2", 415, 183, 20, 18, nodes);
            CreateNode("seatB6_1", 494, 165, 20, 18, nodes);
            CreateNode("seatB6_2", 494, 183, 20, 18, nodes);
            CreateNode("seatB7_1", 532, 165, 20, 18, nodes);
            CreateNode("seatB7_2", 532, 183, 20, 18, nodes);
            CreateNode("seatB8_1", 570, 165, 20, 18, nodes);
            CreateNode("seatB8_2", 570, 183, 20, 18, nodes);

            CreateNode("seatA1", 150, 227, 26, 23, nodes);
            CreateNode("seatA2", 190, 227, 26, 23, nodes);
            CreateNode("seatA3", 230, 227, 26, 23, nodes);
            CreateNode("seatA4", 270, 227, 26, 23, nodes);
            CreateNode("seatA5_1", 375, 217, 20, 18, nodes);
            CreateNode("seatA5_2", 375, 235, 20, 18, nodes);
            CreateNode("seatA6_1", 415, 217, 20, 18, nodes);
            CreateNode("seatA6_2", 415, 235, 20, 18, nodes);
            CreateNode("seatA7_1", 494, 217, 20, 18, nodes);
            CreateNode("seatA7_2", 494, 235, 20, 18, nodes);
            CreateNode("seatA8_1", 532, 217, 20, 18, nodes);
            CreateNode("seatA8_2", 532, 235, 20, 18, nodes);
            CreateNode("seatA9_1", 570, 217, 20, 18, nodes);
            CreateNode("seatA9_2", 570, 235, 20, 18, nodes);

            return nodes;
        }

        private void CreateNode(String nodeName, int x, int y, int width, int height, List<Node> nodeCollection, String addInfo = null)
        {
            BasicShape node = new BasicShape();
            node.Name = nodeName;
            node.OffsetX = x + 7;
            node.OffsetY = y + 12;
            node.Width = width;
            node.Height = height;
            if (addInfo == "booked")
            {
                node.FillColor = "red";
                node.AddInfo = addInfo;
            }
            else
                node.AddInfo = "";
            nodeCollection.Add(node);
        }

        public DiagramProperties GetDiagramModel
        {
            get
            {
                DiagramProperties model = new DiagramProperties();
                model.Width = "625px";
                model.Height = "357px";
                model.Click = "onNodeClick";
                model.Drop = "onItemDrop";
                model.Drag = "nodedragging";
                model.MouseLeave = "nodemouseleave";
                model.MouseEnter = "nodemouseenter";
                model.Create = "onDiagramCreation";
                model.PageSettings = new PageSettings()
                {
                    ShowPageBreak = false,
                    MultiplePage = false,
                    PageBackgroundColor = "transparent",
                    PageBorderWidth = 0,
                    ScrollLimit = ScrollLimit.Diagram,
                    PageWidth = 625,
                    PageHeight = 357,
                    PageOrientation = PageOrientation.Landscape
                };
                model.SnapSettings.SnapConstraints = SnapConstraints.None;
                model.Constraints = model.Constraints ^ DiagramConstraints.Zoomable;
                model.BackgroundImage.Source = "../../Images/AirLineReservation/plane-image.png";
                model.BackgroundImage.Alignment = ImageAlignment.None;
                model.BackgroundImage.Scale = ScaleConstraints.None;
                
                List<Node> nodes = AddDiagramContents();
                foreach (Node node in nodes)
                    model.Nodes.Add(node);
                return model;
            }
        }
    }
}