using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class AutocompleteController : Controller
    {
        // GET: /AutocompleteRtl/
        public ActionResult Rtl()
        {
            ViewBag.datasource = CarsList.GetCarList();
            return View();
        }
    }
}
