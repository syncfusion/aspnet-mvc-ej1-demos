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
        // GET: /LiveUpdate/

        public ActionResult LiveUpdate()
        {
            var DataSource = new ProductDataContext().GetProductData;
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
