using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Areas.ExpenseAnalysis.Controllers
{
    public class ExpenseController : Controller
    {

        public ActionResult Index()
        {
            List<string> ls = new List<string>();
            ls.Add("All");
            ls.Add("January");
            ls.Add("February");
            ls.Add("March");
            ls.Add("April");
            ls.Add("May");
            ls.Add("June");
            ls.Add("July");
            ls.Add("August");
            ls.Add("September");
            ls.Add("October");
            ls.Add("November");
            ls.Add("December");
            ViewBag.dropdown = ls;
            return View();
        }

       
       
    }
}