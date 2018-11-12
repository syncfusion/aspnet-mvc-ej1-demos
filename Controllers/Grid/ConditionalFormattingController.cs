using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /ConditionalFormatting/

        public ActionResult ConditionalFormatting()
        {
            var DataSource = new StockDataContext().GetStockData;
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
