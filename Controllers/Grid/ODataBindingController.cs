using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{

    public partial class GridController : Controller
    {  //
        // GET: /Grid/

        public ActionResult ODataBinding()
        {
            return View();
        }

    }
}
