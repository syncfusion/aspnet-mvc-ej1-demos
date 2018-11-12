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
        // GET: /ExternalFormEditing/

        public ActionResult ExternalFormEditing()
        {
            var DataSource = OrderRepository.GetAllRecords();
            ViewBag.datasource = DataSource;
            return View();
        }

        public ActionResult ExternalUpdate(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ExternalInsert(EditableOrder value)
        {
            OrderRepository.Add(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ExternalDelete(int key)
        {
            OrderRepository.Delete(key);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
