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
        // GET: /Print/

        public ActionResult Print()
        {
            ViewBag.Datasource = new OrderItemsDataContext().GetPrintRecords().ToList();
            return View();
        }

    }
}
