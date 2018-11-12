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
        // GET: /OrganizationChart/
        public ActionResult OrganizationChart()
        {
            DiagramProperties model = new DiagramProperties();

            model.Height = "450px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.PageSettings.MultiplePage = false;
            model.Layout.Type = LayoutTypes.OrganizationalChart;
            model.Layout.HorizontalSpacing = 30;
            model.Layout.VerticalSpacing = 30;
            model.Layout.Margin.Top = 15;
            model.Layout.Margin.Left = 0;
            model.Layout.GetLayoutInfo = "getLayoutInfo";
            model.DataSourceSettings.DataSource = GetOrganizationChart();
            model.DataSourceSettings.Parent = "Phase";
            model.DataSourceSettings.Id = "Id";
            model.Create = "create";
            Dictionary<string, object> addInfo = new Dictionary<string, object>();
            addInfo.Add("orientation", "vertical");
            addInfo.Add("type", "alternate");
            model.DefaultSettings.Node = new Node()
            {
                Constraints = NodeConstraints.Select | NodeConstraints.PointerEvents,
                Width = 110,
                Height = 40,
                BorderColor = "black",
                AddInfo = addInfo
            };
            Label label = new Label() { FontColor = "#ffffff", Margin = new LabelMargin() { Left = 10, Right = 10 } };
            model.DefaultSettings.Node.Labels.Add(label);
            model.DefaultSettings.Connector = new Connector()
            {
                Constraints = ConnectorConstraints.None,
                LineColor = "#000000",
                Segments = new Collection() { new Segment(Segments.Orthogonal) },
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.None }
            };
            model.SelectedItems.Constraints = ~SelectorConstraints.Rotator;
            model.SelectionChange = "selectionChanged";
            model.Click = "diagramClick";
            model.Tool = Tool.SingleSelect | Tool.ZoomPan;
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.Tool = Tool.SingleSelect;
            model.NodeTemplate = "nodeTemplate";
            ViewData["diagramModel"] = model;
            return View();
        }
        public Array GetOrganizationChart()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/OrganizationChart.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}