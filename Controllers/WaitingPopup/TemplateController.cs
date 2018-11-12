using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class WaitingPopupController : Controller
    {
        //
        // GET: /WaitingPopupTemplate/

        public ActionResult Template()
        {
            return View();
        }

    }
}
