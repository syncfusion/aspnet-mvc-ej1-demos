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
        // GET: /Default/       
        public ActionResult Default()
        {
            ViewBag.datasource = CarsList.GetCarList();
            return View();
        }
    }
}
