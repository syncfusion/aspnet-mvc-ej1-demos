using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttToolbarTemplate/

        public ActionResult GanttToolbarTemplate()
        {
            var DataSource = BaseLineGanttData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
