using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.StockAnalysis.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /StockAnalysis/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
