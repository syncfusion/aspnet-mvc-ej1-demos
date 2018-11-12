using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.Invoice.Controllers
{
    public class InvoiceTemplateController : Controller
    {
        //
        // GET: /Invoice/InvoiceTemplate/

        public ActionResult Invoice()
        {
            return View();
        }

    }
}
