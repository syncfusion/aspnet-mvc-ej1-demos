using MVCSampleBrowser.Models.LinearGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
        List<PoniterPlacement> placement = new List<PoniterPlacement>();
        List<MarkerStyle> style = new List<MarkerStyle>();
        public ActionResult Pointer()
        {
            placement.Add(new PoniterPlacement { Placement = "far" });
            placement.Add(new PoniterPlacement { Placement = "near" });
            placement.Add(new PoniterPlacement { Placement = "center" });
            ViewBag.datasource = placement;
            style.Add(new MarkerStyle { markerStyle = "diamond" });
            style.Add(new MarkerStyle { markerStyle = "rectangle" });
            style.Add(new MarkerStyle { markerStyle = "triangle" });
            style.Add(new MarkerStyle { markerStyle = "ellipse" });
            style.Add(new MarkerStyle { markerStyle = "pentagon" });
            style.Add(new MarkerStyle { markerStyle = "circle" });
            style.Add(new MarkerStyle { markerStyle = "star" });
            style.Add(new MarkerStyle { markerStyle = "slider" });
            style.Add(new MarkerStyle { markerStyle = "pointer" });
            style.Add(new MarkerStyle { markerStyle = "wedge" });
            style.Add(new MarkerStyle { markerStyle = "trapezoid" });
            style.Add(new MarkerStyle { markerStyle = "rounded rect" });
            ViewBag.datasource1 = style;
            return View();
        }

    }
}
