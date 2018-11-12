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
        // GET: /ZoomAndPan/

        public ActionResult ZoomAndPan()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "500px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.PageSettings.PageHeight = 500;
            model.PageSettings.PageWidth = 635;
            model.PageSettings.PageOrientation = PageOrientation.Landscape;
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.EnableContextMenu = false;
            model.PageSettings.PageBackgroundColor = "transparent";
            model.BackgroundImage.Source = "../images/Employee/ZoomImage.jpg";
            model.BackgroundImage.Alignment = ImageAlignment.XMinYMid;
            model.BackgroundImage.Scale = ScaleConstraints.Slice;
            ViewData["diagramModel"] = model;
            return View();
        }
    }
}