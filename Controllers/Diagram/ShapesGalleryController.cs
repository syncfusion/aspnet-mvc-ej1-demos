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
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.DataVisualization.Models;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /ShapesGallery/
        public ActionResult ShapesGallery()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "550px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.SnapSettings.SnapConstraints = SnapConstraints.None;
            model.Create = "diaramCreate";
            model.DefaultSettings.Node = new Node() { MarginLeft = 10, MarginBottom = 10, MarginRight = 10, MarginTop = 10 };
            ViewData["diagramModel"] = model;
            return View();
        }
	}
}