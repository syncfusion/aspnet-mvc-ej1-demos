using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /ContextMenu/

        public ActionResult ContextMenu()
        {
            var dataSource = MarkDetail.GetAllMarkList.Take(10).ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
