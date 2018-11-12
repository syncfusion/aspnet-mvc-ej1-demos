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
        // GET: /CellEditType/

        public ActionResult CellEditType()
        {
            var DataSource = OrderRepository.GetAllRecords().ToList();
            ViewBag.datasource = DataSource;
            return View();
        }

        public ActionResult CellEditUpdate(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CellEditInsert(EditableOrder value)
        {
            OrderRepository.Add(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CellEditDelete(int key)
        {
            OrderRepository.Delete(key);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
