using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ToolbarController : Controller
    {
        //
        // GET: /ToolbarMethods/
        List<ToolbarMethods> m = new List<ToolbarMethods>();
        public ActionResult Methods()
        {
            m.Add(new ToolbarMethods { text = "None", value = "none" });
            m.Add(new ToolbarMethods { text = "Left", value = "Left" });
            m.Add(new ToolbarMethods { text = "Center", value = "Center" });
            m.Add(new ToolbarMethods { text = "Right", value = "Right" });
            m.Add(new ToolbarMethods { text = "Justify", value = "Justify" });
            m.Add(new ToolbarMethods { text = "Bold", value = "Bold" });
            m.Add(new ToolbarMethods { text = "Italic", value = "Italic" });
            m.Add(new ToolbarMethods { text = "StrikeThrough", value = "StrikeThrough" });
            m.Add(new ToolbarMethods { text = "Underline", value = "Underline" });
            ViewBag.datasource = m;
            return View();
        }

    }
}
