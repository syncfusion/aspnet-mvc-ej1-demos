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
        // GET: /TreeGridFrozenColumns/
        public ActionResult TreeGridFrozenColumns()
        {
            ViewBag.datasource = this.GetDefaultData();
            return View();
        }
	}
}