using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ButtonController : Controller
    {
        //
        // GET: /ButtonToggleButtons/

        public ActionResult ToggleButtons()
        {
            return View();
        }

    }
}
