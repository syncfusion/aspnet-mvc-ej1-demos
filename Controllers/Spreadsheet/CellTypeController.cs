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
        // GET: /CellType/

        public ActionResult CellType()
        {
            var DataSource = CellTypeData.GetItemDetails.ToList();
            ViewBag.Datasource = DataSource;
            return View();
        }

    }
}
