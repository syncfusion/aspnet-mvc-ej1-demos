using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class TreeViewController : Controller
    {
        //
        // GET: /TreeViewDefault/

        public ActionResult Default()
        {
            return View();
        }

    }
}
