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
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ToolbarController : Controller
    {
        //
        // GET: /ToolbarRtl/
        List<ToolbarOrientation> tool = new List<ToolbarOrientation>();
        public ActionResult Rtl()
        {
            tool.Add(new ToolbarOrientation { edid = "1", spriteCss = "cursor" });
            tool.Add(new ToolbarOrientation { edid = "2", spriteCss = "select" });
            tool.Add(new ToolbarOrientation { edid = "3", spriteCss = "move" });
            tool.Add(new ToolbarOrientation { edid = "4", spriteCss = "rectselect" });
            tool.Add(new ToolbarOrientation { edid = "5", spriteCss = "roundselect" });
            tool.Add(new ToolbarOrientation { edid = "6", spriteCss = "brush" });
            tool.Add(new ToolbarOrientation { edid = "7", spriteCss = "pen" });
            tool.Add(new ToolbarOrientation { edid = "8", spriteCss = "gradient" });
            tool.Add(new ToolbarOrientation { edid = "9", spriteCss = "crop" });
            tool.Add(new ToolbarOrientation { edid = "10", spriteCss = "symbols" });
            ViewBag.datasource = tool;
            return View();
        }

    }
}
