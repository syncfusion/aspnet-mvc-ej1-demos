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
        // GET: /Filtering/

        public ActionResult Filtering()
        {
            var DataSource = OrderRepository.GetAllRecords().ToList();
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
