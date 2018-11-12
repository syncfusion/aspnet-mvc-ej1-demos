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
        // GET: /Table/

        public ActionResult Table()
        {
            var dataSource = TableData.GetTableDetails.ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
