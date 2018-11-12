using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /Adaptive/

        public ActionResult CheckboxSelection()
        {
            ViewBag.datasource = new NorthwindDataContext().OrdersViews.ToList();
            return View();
        }
        

    }
}
