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
        // GET: /DialogEditing/

        public ActionResult DialogEditing()
        {
            var DataSource = OrderRepository.GetAllRecords();
            ViewBag.datasource = DataSource;
            return View();
        }

        public ActionResult CrudUrl(EditableOrder value, int? key, string action)
        {
            if (action == "update")
                OrderRepository.Update(value);
            else if (action == "insert")
                OrderRepository.Add(value);
            else if (action == "remove")
                OrderRepository.Delete(key);
            return Json(value, JsonRequestBehavior.AllowGet);
        }

    }
}
