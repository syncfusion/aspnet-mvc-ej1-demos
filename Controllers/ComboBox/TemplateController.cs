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
        // GET: /Template/       
        public ActionResult Template()
        {
            ViewBag.datasource = empList.GetEmpList();
            return View();
        }
    }
}
