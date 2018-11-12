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
        // GET: /Default/

        public ActionResult Default()
        {
            var DataSource = ItemData.GetAllItemDetails.ToList();
            ViewBag.Datasource = DataSource;
            return View();
        }

    }
}
