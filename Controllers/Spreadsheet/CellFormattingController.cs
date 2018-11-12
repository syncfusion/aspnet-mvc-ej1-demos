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
        // GET: /CellFormatting/

        public ActionResult CellFormatting()
        {
            var dataSource = CellFormatData.GetCellFormats.ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
