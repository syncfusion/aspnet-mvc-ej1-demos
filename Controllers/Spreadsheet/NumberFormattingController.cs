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
        // GET: /NumberFormatting/

        public ActionResult NumberFormatting()
        {
            var dataSource = NumberFormatData.GetNumFormats.ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
