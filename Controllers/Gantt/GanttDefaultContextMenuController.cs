using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttDefaultContextMenu/

        public ActionResult GanttDefaultContextMenu()
        {
            var DataSource = GanttData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }
    }
}
