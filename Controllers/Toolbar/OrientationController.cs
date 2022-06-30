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
        // GET: /ToolbarOrientation/
        List<ToolbarOrientation> t1 = new List<ToolbarOrientation>();
        public ActionResult Orientation()
        {
            t1.Add(new ToolbarOrientation { edid = "1", spriteCss = "cursor" });
            t1.Add(new ToolbarOrientation { edid = "2", spriteCss = "select" });
            t1.Add(new ToolbarOrientation { edid = "3", spriteCss = "move" });
            t1.Add(new ToolbarOrientation { edid = "4", spriteCss = "rectselect" });
            t1.Add(new ToolbarOrientation { edid = "5", spriteCss = "roundselect" });
            t1.Add(new ToolbarOrientation { edid = "6", spriteCss = "brush" });
            t1.Add(new ToolbarOrientation { edid = "7", spriteCss = "pen" });
            t1.Add(new ToolbarOrientation { edid = "8", spriteCss = "gradient" });
            t1.Add(new ToolbarOrientation { edid = "9", spriteCss = "crop" });
            t1.Add(new ToolbarOrientation { edid = "10", spriteCss = "symbols" });
            ViewBag.datasource = t1;
            return View();
        }

    }
}
