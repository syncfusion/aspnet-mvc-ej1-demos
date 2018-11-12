using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class MenuController : Controller
    {
        //
        // GET: /menuevents/

        public ActionResult events()
        {
            return View();
        }

    }
}
