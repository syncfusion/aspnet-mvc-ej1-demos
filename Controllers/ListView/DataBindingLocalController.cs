using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {
        //
        // GET: /DataBindingLocal/

        public ActionResult DataBindingLocal()
        {
            ListDataModal.clearSource();
            return View(ListDataModal.setListDataSource());
            
        }

    }
}
