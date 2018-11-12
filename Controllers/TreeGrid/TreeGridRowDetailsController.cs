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
        // GET: /TreeGridRowDetails/

        public ActionResult TreeGridRowDetails()
        {
            ViewBag.dataSource = this.getRowData();
            return View();
        }
    }
}
