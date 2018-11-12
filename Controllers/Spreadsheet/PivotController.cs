using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /Pivot/

        public ActionResult Pivot()
        {
            var dataSource = PivotData.GetPivotDetails.ToList();
            ViewBag.DataSource = dataSource;
            return View();
        }
      
    }
}
