using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {
        //
        // GET: /DefaultFunctionalities/

        public ActionResult Default()
        {
            ListLocalDataModal.clearSource();
            return View(ListLocalDataModal.setListSource());
        }

    }
}
