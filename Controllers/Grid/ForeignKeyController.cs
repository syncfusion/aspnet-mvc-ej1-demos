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
        // GET: ForeignKey
        public ActionResult ForeignKey()
        {
            var DataSource = OrderRepository.GetAllRecords();
            ViewBag.datasource = DataSource;
            ViewBag.foreignCol = new NorthwindDataContext().EmployeeViews.ToList();
            return View();
        }

        public ActionResult ForeignKeyUpdate(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ForeignKeyInsert(EditableOrder value)
        {
            OrderRepository.Add(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ForeignKeyDelete(int key)
        {
            OrderRepository.Delete(key);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}