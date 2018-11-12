using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class BarcodeController : Controller
    {
        //
        // GET: /BarcodeDefault/

        public ActionResult Code128C()
        {
            return View();
        }

    }
}
