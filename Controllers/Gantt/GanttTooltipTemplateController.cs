using System;
using System.Collections.Generic;
using System.Linq;
using MVCSampleBrowser.Models;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttTooltipTemplate/

        public ActionResult GanttTooltipTemplate()
        {
            var DataSource = GetTaskData();
            ViewBag.datasource = DataSource;
            var DataSource1 = ResourceDataContext.GetResourceData();
            ViewBag.datasource1 = DataSource1;
            return View();
        }
    }
}
