using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportViewerController : Controller
    {
        //
        // GET: /DataBindingLocal/


        public ActionResult DataBindingLocal()
        {
            ViewData["bill_2012"] = Billionaires.GetList_2012();
            ViewData["bill_2013"] = Billionaires.GetList_2013();
            ViewData["bill_desc"] = Indicator.GetIndicator();
            return View();
        }

    }
}
