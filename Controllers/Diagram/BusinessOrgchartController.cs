
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
        //
        // GET: /Organization/

        public ActionResult BusinessChart()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "100%";
            model.Height = "650px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.OrganizationalChart;
            model.Layout.HorizontalSpacing = 40;
            model.Layout.VerticalSpacing = 40;
            model.Layout.Margin.Top = 30;
            model.Layout.GetLayoutInfo = "getLayoutInfo";
            model.DataSourceSettings.DataSource = GetBusinessOrgChart();
            model.DataSourceSettings.Parent = "Manager";
            model.DataSourceSettings.Id = "Id";
            model.DefaultSettings.Node = new Node()
            {
                Width = 150,
                Height = 50,
                BorderColor = "transparent"
            };
            Label label = new Label() { FontColor = "#ffffff", Margin = new LabelMargin() { Left = 5, Right = 5 } };
            model.DefaultSettings.Node.Labels.Add(label);
            model.DefaultSettings.Connector = new Connector()
            {
                Segments = new Collection() { new Segment(Segments.Orthogonal) },
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.None }
            };
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.Tool = Tool.ZoomPan;
            model.NodeTemplate = "nodeTemplate";
            ViewData["diagramModel"] = model;
            return View();
        }

        public Array GetBusinessOrgChart()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/BusinessChart.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}
