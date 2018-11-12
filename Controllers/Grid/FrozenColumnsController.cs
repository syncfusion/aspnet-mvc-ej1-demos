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
        // GET: /FrozenColumns/

        public ActionResult FrozenColumns()
        {
            var DataSource = OrderRepository.GetAllRecords().ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
