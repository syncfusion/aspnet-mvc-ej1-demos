using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class RotatorController : Controller
    {
        //
        // GET: /RotatorProperties/
        List<LocalData> pagerPosition = new List<LocalData>();
        List<LocalData> animation = new List<LocalData>();
        public ActionResult Properties()
        {
            pagerPosition.Add(new LocalData { value = "topleft", text = "TopLeft" });
            pagerPosition.Add(new LocalData { value = "topright", text = "TopRight" });
            pagerPosition.Add(new LocalData { value = "bottomleft", text = "BottomLeft" });
            pagerPosition.Add(new LocalData { value = "bottomright", text = "BottomRight" });
            pagerPosition.Add(new LocalData { value = "outside", text = "Outside" });
            ViewBag.datasource = pagerPosition;
            animation.Add(new LocalData { value = "slide", text = "Slide" });
            animation.Add(new LocalData { value = "slowSlide", text = "SlowSlide" });
            animation.Add(new LocalData { value = "fastSlide", text = "FastSlide" });
            animation.Add(new LocalData { value = "slideshow", text = "Slideshow" });
            ViewBag.animationsource = animation;
            return View();
        }

    }
}
