using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /HyperlinkComment/

        public ActionResult HyperlinkComment()
        {
            var dataSource = HyperlinkData.GetHyperlinkDetails.ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
