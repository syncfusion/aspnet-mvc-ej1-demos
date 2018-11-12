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
        // GET: /Events/        
        public ActionResult Events()
        {
            ViewBag.datasource = Colors.GetColors();
            return View();
        }
    }
}
