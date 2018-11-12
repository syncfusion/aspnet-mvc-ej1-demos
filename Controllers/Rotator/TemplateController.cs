using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class RotatorController : Controller
    {
        //
        // GET: /RotatorTemplate/
        List<localdata> LocalValue = new List<localdata>();
        public ActionResult Template()
        {
            LocalValue.Add(new localdata { text = "Louis", color = "#43BDC2", eimg = "03", desig = "Representative", country = "England" });
            LocalValue.Add(new localdata { text = "Silivia", color = "#80C344", eimg = "04", desig = "Representative", country = "Norway" });
            LocalValue.Add(new localdata { text = "Linden", color = "#F68A3F", eimg = "05", desig = "Representative", country = "Australia" });
            LocalValue.Add(new localdata { text = "Lawrence", color = "#E4BF21", eimg = "06", desig = "Representative", country = "India" });
            ViewBag.datasource = LocalValue;
            return View();
        }
    }
}