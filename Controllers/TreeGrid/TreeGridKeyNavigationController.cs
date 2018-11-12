using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridKeyNavigation/

        public ActionResult TreeGridKeyNavigation()
        {
            var data = this.GetDefaultData();
            ViewBag.datasource = data;
            return View();
        }

    }
}
