using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class KanbanBoardController : Controller
    {
        //
        // GET: /Adaptive/
        
        public ActionResult Adaptive()
        {
            return View();
        }
        public ActionResult AdaptiveKanban()
        {
            var data = new NorthwindDataContext().Tasks.Take(10).ToList();
            ViewBag.datasource = data;
            return PartialView();
        }

    }
}
