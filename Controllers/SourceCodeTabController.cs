using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Helpers;

namespace MVCSampleBrowser.Controllers
{
    public class SourceCodeTabController : Controller
    {
        public ActionResult Index(string file, string seperateWindow)
        {
            return new SourceTabActionResult(file, seperateWindow);
        }

    }
}
