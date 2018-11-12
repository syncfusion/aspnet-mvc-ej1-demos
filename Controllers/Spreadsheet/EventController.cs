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
        // GET: /Event/

        public ActionResult Event()
        {
            var dataSource = new OrderItemsDataContext().GetAllRecords().ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
