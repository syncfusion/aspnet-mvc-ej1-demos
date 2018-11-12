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
        // GET: /FreezePane/

        public ActionResult FreezePane()
        {
            var dataSource = PersonDetail.GetAllPersonList.ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}
