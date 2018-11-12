using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class TagCloudController : Controller
    {
        //
        // GET: /TagCloudDatabindingOdata/       

        public ActionResult DatabindingOdata()
        {
            return View();
        }

    }
}
