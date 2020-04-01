#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
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
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;
using DiagramBuilder.Models;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Areas.DiagramBuilder.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /DiagramBuilder/Home/

        public ActionResult Index()
        {
            DiagramBuilderModel diagramModel = new DiagramBuilderModel();
            SymbolPaletteProperties symbolpalette = new SymbolPaletteProperties();
            diagramModel.Palette(symbolpalette);
            diagramModel.GenerateBasicShapes(symbolpalette);
            diagramModel.GenerateFlowShapes(symbolpalette);
            diagramModel.GenerateArrowShapes(symbolpalette);
            diagramModel.GenerateElectricalShapes(symbolpalette);
            diagramModel.GenerateBpmnShapes(symbolpalette);
            diagramModel.GenerateConnectors(symbolpalette);
            diagramModel.GenerateSwimLanes(symbolpalette);
            MapPath(symbolpalette);

            
            SymbolPaletteProperties searchSymbolPalette = new SymbolPaletteProperties();
            diagramModel.Palette(searchSymbolPalette);
            searchSymbolPalette.SelectedPaletteName = "filteredShapes";
            Palette palette = new Palette();
            palette.Name = "filteredShapes";
            searchSymbolPalette.Palettes.Add(palette);

            ViewData["DiagramModel"] = diagramModel.Model;
            ViewData["SymbolPaletteModel"] = symbolpalette;
            ViewData["searchPaletteModel"] = searchSymbolPalette;
            SetDropDownDataSource();
            SetDropDownTemplates();
            return View();
        }

        public void SetDropDownTemplates()
        {
            ViewBag.ColorPaletteTemplate = "<div class=\"ddl-color-list\" style=\"background-color: ${color1};\"></div>" 
                                         + "<div class=\"ddl-color-list\" style=\"background-color: ${color2};\"></div>"
                                         + "<div class=\"ddl-color-list\" style=\"background-color: ${color3};\"></div>";

            ViewBag.BorderTemplate = "<div style=\"margin-top: 3px; height: 25px\">" +
                                     "<label style=\"font-weight: bold\">${text}</label>" +
                                     "<div style=\"background-color: black; width: 45px; height: ${height};float: right; margin-top: 11px; margin-left: 20px; margin-right: 5px\"></div>" +
                                     "</div>";

            ViewBag.PageColorTemplate = "<div class=\"ddl-color-list\" style=\"background-color: ${color1};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color2};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color3};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color4};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color5};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color6};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color7};\"></div>"
                                      + "<div class=\"ddl-color-list\" style=\"background-color: ${color8};\"></div>";
        }

        public void SetDropDownDataSource()
        {
            ViewBag.ColorPaletteDataSource = new List<ColorList>()
            {
                new ColorList(){ color1= "#FFFFFF", color2="#F9D9D9", color3= "#FFE6CC" },
                new ColorList(){ color1= "#FFFF99", color2= "#CCFFCC", color3= "#CCFFFF" },
                new ColorList(){ color1= "#D4D4F9", color2= "#E5CCFF", color3= "#FFCCFF" },
                new ColorList(){ color1= "#FFCCE6", color2= "#E5E5E5", color3= "#FF9999" },
                new ColorList(){ color1= "#FCC088", color2= "#FFFF33", color3= "#99FF33" },
                new ColorList(){ color1= "#66FFFF", color2= "#7E7EFC", color3= "#CC99FF" },
                new ColorList(){ color1= "#FF99FF", color2= "#FF8000", color3= "#CCCC00" },
                new ColorList(){ color1= "#FF66B3", color2= "#262626", color3= "#FF0000" },
                new ColorList(){ color1= "#66CC00", color2= "#00CCCC", color3= "#3333FF" },
                new ColorList(){ color1= "#7F00FF", color2= "#FF00FF", color3= "#FF0080" }
                //new ColorList(){ color1= "#0C0C0C", color2= "#CC0000", color3= "#99004D" }
            };

            ViewBag.BorderDataSource = new List<BorderWidthList>()
            {
                new BorderWidthList(){ text= "1 px", height= "1px" },
                new BorderWidthList(){ text= "2 px", height= "2px" },
                new BorderWidthList(){ text= "3 px", height= "3px" },
                new BorderWidthList(){ text= "4 px", height= "4px" },
                new BorderWidthList(){ text= "5 px", height= "5px" },
                new BorderWidthList(){ text= "6 px", height= "6px" },
                new BorderWidthList(){ text= "7 px", height= "7px" },
                new BorderWidthList(){ text= "8 px", height= "8px" }
            };

            ViewBag.PageBackColorSource = new List<PageColorList>()
            {
                new PageColorList() { color1= "#FFFFFF", color2= "#F9D9D9", color3= "#FFE6CC", color4= "#FFFF99", color5= "#CCFFCC", color6= "#CCFFFF", color7= "#D4D4F9", color8= "#E5CCFF" },
                new PageColorList() { color1= "#FFCCFF", color2= "#FFCCE6", color3= "#E5E5E5", color4= "#FF9999", color5= "#FCC088", color6= "#FFFF33", color7= "#99FF33", color8= "#66FFFF" },
                new PageColorList() { color1= "#7E7EFC", color2= "#CC99FF", color3= "#FF99FF", color4= "#FF66B3", color5= "#262626", color6= "#FF0000", color7= "#FF8000", color8= "#CCCC00" },
                new PageColorList() { color1= "#66CC00", color2= "#00CCCC", color3= "#3333FF", color4= "#7F00FF", color5= "#FF00FF", color6= "#FF0080", color7= "#0C0C0C", color8= "#CC0000" },
                new PageColorList() { color1= "#994C00", color2= "#999900", color3= "#006600", color4= "#009999", color5= "#000066", color6= "#4C0099", color7= "#990099", color8= "#99004D" }
            };

            ViewBag.FontSize = new List<int>()
            {
                8,9,10,11,12,13,14,15,16,17,18,19,20
            };

            ViewBag.FontStyleList = new List<string>()
            {
                 "Arial","Aharoni","Bell MT","Fantasy","Times New Roman","Segoe UI","Verdana" 
            };

            ViewBag.ZoomLevelList = new List<string>()
            {
                  "400%","200%","150%","100%","75%","50%","25%" 
            };
        }

        private void MapPath(SymbolPaletteProperties symbolPalette)
        {
            for (int i = 0; i < symbolPalette.Palettes.Count; i++)
            {
                Palette palette = symbolPalette.Palettes[i] as Palette;
                Dictionary<string, object> addInfo = palette.AddInfo as Dictionary<string, object>;
                addInfo["source"] = Url.Content(addInfo["source"].ToString());
            }
        }

    }

    public class ColorList
    {
        public string color1 { get; set; }
        public string color2 { get; set; }
        public string color3 { get; set; }
    }

    public class PageColorList : ColorList
    {
        public string color4 { get; set; }
        public string color5 { get; set; }
        public string color6 { get; set; }
        public string color7 { get; set; }
        public string color8 { get; set; }
    }

    public class BorderWidthList
    {
        public string text { get; set; }
        public string height { get; set; }
    }
}
