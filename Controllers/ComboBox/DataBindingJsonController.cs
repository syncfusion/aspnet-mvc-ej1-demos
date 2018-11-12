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
        // GET: /DataBindingJson/        
        public ActionResult DatabindingJson()
        {
            ViewBag.datasource = States.GetStates();
            return View();
        }
    }
}
