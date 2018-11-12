using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class RatingController : Controller
    {
        //
        // GET: /RatingDefault/

        public ActionResult Default()
        {
            return View();
        }

    }
}
