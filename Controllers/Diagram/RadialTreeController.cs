
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

        public ActionResult RadialTree()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "100%";
            model.Height = "600px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.RadialTree;
            model.Layout.Margin.Top = 50;
            model.Layout.HorizontalSpacing = 30;
            model.Layout.VerticalSpacing = 30;
            model.DataSourceSettings.DataSource = GetRadialTreeData();
            model.DataSourceSettings.Parent = "ReportingPerson";
            model.DataSourceSettings.Id = "Id";
            model.DefaultSettings.Node = new ImageNode()
            {
                Width = 50,
                Height = 50,
                BorderColor = "transparent",
                BorderWidth = 0,
                Constraints = NodeConstraints.InheritTooltip | NodeConstraints.PointerEvents
            };
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.NodeTemplate = "nodeTemplate";
            model.Tool = Tool.ZoomPan;
            model.Create = "create";
            model.Tooltip = new Tooltip() { TemplateId = "mouseovertoolTipId", Alignment = new Alignment() { Vertical = VerticalAlignment.Top } };
            ViewData["diagramModel"] = model;
            return View();
        }

        public Array GetRadialTreeData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/RadialData.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
    }
}
