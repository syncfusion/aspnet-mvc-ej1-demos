#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
