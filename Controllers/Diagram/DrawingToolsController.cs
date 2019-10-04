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
using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /DrawingTools/

        public ActionResult DrawingTools()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "700px";
            model.Width = "700px";
            BasicShape rectangle = CreateNode(BasicShapes.Rectangle, 100, 100, 150, 150, "Rectangle", "#fcbc7c", "#f89b4c");
            BasicShape RoundedRectangle = CreateNode(BasicShapes.Rectangle, 100, 100, 350, 150, "RoundRect", "#f58f7a", "#f15e50");
            RoundedRectangle.CornerRadius = 5;
            BasicShape Ellipse = CreateNode(BasicShapes.Ellipse, 100, 100, 550, 150, "Ellipse", "#85cec1", "#4bbca7");
            BasicShape Polygon = CreateNode(BasicShapes.Polygon, 100, 100, 150, 350, "Polygon", "#c19ab8", "#ad6fa1");
            Collection points = new Collection();
            points.Add(new DiagramPoint(13.560f, 67.524f));
            points.Add(new DiagramPoint(21.941f, 41.731f));
            points.Add(new DiagramPoint(0.05f, 25.790f));
            points.Add(new DiagramPoint(27.120f, 25.790f));
            points.Add(new DiagramPoint(35.501f, 0.05f));
            points.Add(new DiagramPoint(43.882f, 25.790f));
            points.Add(new DiagramPoint(71.000f, 25.790f));
            points.Add(new DiagramPoint(49.061f, 41.731f));
            points.Add(new DiagramPoint(57.441f, 67.524f));
            points.Add(new DiagramPoint(35.501f, 51.583f));
            points.Add(new DiagramPoint(13.560f, 67.524f));
            Polygon.Points = points;
            BasicShape Path = CreateNode(BasicShapes.Path, 100, 100, 350, 350, "Path", "#fbe172", "#f4cd2a");
            Path.PathData = "M78.631,3.425c-0.699-1.229-2.177-2.653-5.222-2.394c-8.975,0.759-26.612,16.34-30.804,22.411c-0.167-0.79-0.551-2.049-1.377-2.741c1.176-2.069,3.035-5.709,3.813-9.156c0.18-0.044,0.338-0.161,0.385-0.41c0.083-0.423,0.146-0.848,0.23-1.268c0.135-0.706-0.962-0.944-1.086-0.245c-0.078,0.431-0.158,0.852-0.234,1.286c-0.04,0.26,0.076,0.464,0.26,0.569c-0.756,3.361-2.575,6.93-3.737,8.975c-0.2-0.105-0.415-0.189-0.661-0.224c-0.07-0.009-0.132,0.005-0.199,0.003c-0.067,0.002-0.129-0.012-0.199-0.003c-0.246,0.035-0.461,0.119-0.661,0.224c-1.162-2.045-2.981-5.613-3.737-8.975c0.185-0.104,0.301-0.309,0.26-0.569c-0.076-0.434-0.156-0.855-0.234-1.286c-0.124-0.699-1.221-0.46-1.086,0.245c0.085,0.42,0.147,0.845,0.23,1.268c0.047,0.249,0.205,0.367,0.385,0.41c0.777,3.446,2.637,7.087,3.813,9.156c-0.826,0.692-1.21,1.951-1.377,2.741C33.203,17.371,15.566,1.789,6.591,1.031C3.546,0.772,2.068,2.196,1.369,3.425c-0.818,1.407-0.185,4.303,0.993,9.321c0.53,2.228,1.075,4.521,1.465,6.779c0.208,1.239,0.404,2.471,0.59,3.65c0.819,5.33,1.503,9.766,3.714,11.187c0.606,0.39,1.313,0.55,2.179,0.442c2.107-0.46,4.627-0.845,7.293-1.12c-2.613,1.77-5.88,4.65-6.953,8.474c-0.827,2.989-0.175,6.031,1.932,9.083c2.482,3.569,5.027,5.915,7.406,7.444c4.756,3.057,8.874,2.843,10.613,2.75c0.179-0.002,0.318-0.014,0.453-0.018c1.324-0.017,2.23-1.868,4.161-6.064c0.948-2.044,2.358-5.088,3.546-6.638c0.249,0.57,0.96,0.972,1.331,1.085c-0.03,0.014-0.067,0.039-0.094,0.049c0.034-0.007,0.074-0.03,0.111-0.042c0.022,0.006,0.055,0.023,0.074,0.027c-0.017-0.006-0.046-0.022-0.066-0.03c0.391-0.131,0.876-0.532,1.119-1.088c1.188,1.549,2.598,4.594,3.546,6.638c1.931,4.196,2.838,6.047,4.161,6.064c0.135,0.004,0.274,0.016,0.453,0.018c1.739,0.093,5.857,0.307,10.613-2.75c2.379-1.529,4.924-3.875,7.406-7.444c2.106-3.052,2.759-6.094,1.932-9.083c-1.073-3.823-4.34-6.704-6.953-8.474c2.667,0.274,5.186,0.659,7.293,1.12c0.866,0.108,1.573-0.053,2.179-0.442c2.211-1.421,2.895-5.857,3.714-11.187c0.185-1.18,0.382-2.411,0.59-3.65c0.39-2.258,0.935-4.551,1.465-6.779C78.816,7.728,79.448,4.832,78.631,3.425z M41.184,48.732c-0.343,0.551-0.781,0.918-1.082,1.065c-0.324-0.135-0.933-0.497-1.286-1.065c0,0-1.506-19.959-1.349-24.911c0,0,0.509-3.147,2.533-3.169c2.024,0.022,2.533,3.169,2.533,3.169C42.69,28.773,41.184,48.732,41.184,48.732z";
            ImageNode Image = new ImageNode { Name = "Image", Width = 100, Height = 100, OffsetX = 550, OffsetY = 350, FillColor = "white", BorderColor = "black",Scale= ScaleConstraints.Stretch, Labels = new Collection() { new Label() } };
            Image.Source = "../images/Employee/6.png";
            HtmlNode Html = new HtmlNode() { Name = "Html", Type = Shapes.Html, Width = 100, Height = 100, OffsetX = 150, OffsetY = 550, FillColor = "#68a3d6", BorderColor = "#3382c4", TemplateId = "htmlTemplate" };
            NativeNode Native = new NativeNode { Name = "Native", Width = 100, Height = 100, OffsetX = 350, OffsetY = 550, FillColor = "#de6ca9", BorderColor = "#de6ca9", Scale = ScaleConstraints.Stretch, TemplateId = "svgTemplate", Labels = new Collection() { new Label() } };
            TextNode Text = new TextNode() { Name = "Text", Width = 100, Height = 100, OffsetX = 550, OffsetY = 550, FillColor = "transparent", BorderColor = "transparent",  Labels = new Collection() { new Label() } };
            TextBlock block = new TextBlock();
            block.Text = "Text Node";
            Text.TextBlock = block;
            model.Nodes.Add(rectangle);
            model.Nodes.Add(RoundedRectangle);
            model.Nodes.Add(Ellipse);
            model.Nodes.Add(Polygon);
            model.Nodes.Add(Path);
            model.Nodes.Add(Image);
            model.Nodes.Add(Html);
            model.Nodes.Add(Native);
            model.Nodes.Add(Text);
            model.NodeCollectionChange = "nodeCollectionChange";
            ViewData["diagramModel"] = model;
            return View();
        }
        private BasicShape CreateNode(BasicShapes shape, double width, double height, double offsetx, double offsety, string labelText, string fillColor, string borderColor)
        {
            BasicShape node = new BasicShape();
            node.Name = labelText;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            node.FillColor = fillColor;
            node.BorderColor = borderColor;
            node.Shape = shape;
            Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
            label.Text = labelText;
            label.FontColor = "white";
            label.Name = labelText + "_label";
            node.Labels.Add(label);
            return node;
        }

    }
}
