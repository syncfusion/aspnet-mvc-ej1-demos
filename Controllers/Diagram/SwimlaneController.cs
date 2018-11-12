using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.DataVisualization.Models;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using MVCSampleBrowser.Models.Digram;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        SymbolPaletteProperties symbolPalette = new SymbolPaletteProperties();
        DiagramProperties diagram = new DiagramProperties();
        public ActionResult Swimlane()
        {
            SwimlaneModel swimlaneModel = new SwimlaneModel();
            swimlaneModel.createSymbolPalette(symbolPalette);
            swimlaneModel.GenerateBasicShapes(symbolPalette);
            swimlaneModel.GenerateSwimlaneShapes(symbolPalette);
            swimlaneModel.GenerateConnectors(symbolPalette);
            swimlaneModel.GenerateDiagram(diagram);
            diagram.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            ViewData["DiagramModel"] = diagram;
            ViewData["SymbolPaletteModel"] = symbolPalette;
            return View();
        }
    }
}