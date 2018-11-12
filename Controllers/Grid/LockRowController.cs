using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /LockRow/

        public ActionResult LockRow()
        {
            var DataSource = OrderRepository.GetAllRecords().ToList();
            ViewBag.datasource = DataSource;
            return View();
        }

        public ActionResult LockRowUpdate(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }       
    }
}
