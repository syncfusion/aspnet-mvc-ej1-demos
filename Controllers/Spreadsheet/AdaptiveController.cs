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
        // GET: /Adaptive/

        public ActionResult Adaptive()
        {
            return View();
        }

        public ActionResult AdaptiveSpreadsheet()
        {
            var DataSource = ItemData.GetAllItemDetails.ToList();
            ViewBag.Datasource = DataSource;
            return PartialView();
        }

    }
}
