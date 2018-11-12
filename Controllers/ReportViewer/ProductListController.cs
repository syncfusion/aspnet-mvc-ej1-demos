using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Syncfusion.JavaScript.Models;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportViewerController : Controller
    {
        //
        // GET: /ProductList/

        public ActionResult ProductList()
        {
            ProductList prodlist = new Models.ProductList();
            ViewData["reportDsource"] = prodlist.GetData();
            return View();
        }

    }
}
