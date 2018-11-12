using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ComboBoxController : Controller
    {
        //
        // GET: /Filtering/

        public ActionResult Filtering()
        {
            ViewBag.datasource = Countries.GetCountries();
			return View();
        }

    }
}
