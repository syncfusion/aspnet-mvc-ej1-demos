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
        // GET: /ColumnFormatting/

        public ActionResult ColumnFormatting()
        {
            var DataSource = new FormattingDataContext().GetData;
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
