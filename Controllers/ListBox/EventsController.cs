using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ListBoxController : Controller
    {
        //
        // GET: /Events/

        List<Countries> c = new List<Countries>();
        public ActionResult Events()
        {
            c.Add(new Countries { country = "Australia" });
            c.Add(new Countries { country = "Austria" });
            c.Add(new Countries { country = "Bangladesh" });
            c.Add(new Countries { country = "Brazil" });
            c.Add(new Countries { country = "Canada" });
            c.Add(new Countries { country = "China" });
            c.Add(new Countries { country = "Denmark" });
            c.Add(new Countries { country = "Europe" });
            c.Add(new Countries { country = "France" });
            c.Add(new Countries { country = "Germany" });
            c.Add(new Countries { country = "India" });
            c.Add(new Countries { country = "Japan" });
            c.Add(new Countries { country = "Kuwait" });
            c.Add(new Countries { country = "Malaysia" });
            c.Add(new Countries { country = "NewZealand" });
            ViewBag.datasource = c;
            return View();
        }
    }
}
