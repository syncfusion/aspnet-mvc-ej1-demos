using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.ReportViewerEnums;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportViewerController : Controller
    {
        //
        // GET: /ProductList/

        public ActionResult SalesPerYear()
        {

            var datasources = new List<Syncfusion.JavaScript.Models.ReportViewer.ReportDataSource>();
            datasources.Add(new Syncfusion.JavaScript.Models.ReportViewer.ReportDataSource("Sales", new CompanySales().GetData()));
            ViewData["viewer"] = datasources;
            return View();
        }

    }
}
