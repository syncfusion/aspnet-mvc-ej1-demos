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