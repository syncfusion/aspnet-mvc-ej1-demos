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
        // GET: /GanttWorkWeek/

        public ActionResult GanttWorkWeek()
        {
            var DataSource = GanttDefaultData.GetData();
            ViewBag.datasource = DataSource;
            //ViewBag.dropDownData = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return View();
        }

    }
}
