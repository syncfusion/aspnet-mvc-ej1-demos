using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /SignalR/
        public ActionResult SignalR()
        {
            ViewBag.Datasource = new OrderItemsDataContext().GetSignalRRecords().ToList();
            return View();
        }
    }

   
}
