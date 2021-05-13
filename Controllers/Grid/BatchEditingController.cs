#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.JavaScript.Shared.Serializer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /BatchEditing/

        public ActionResult BatchEditing()
        {
            System.Web.HttpContext.Current.Session["Records"] = null;          
            ViewData["EmployeeID"] = EmployeeID;
            ViewData["ShipCountry"] = ShipCountry;
            return View();
        }

        public ActionResult BatchDataSource(Syncfusion.JavaScript.DataManager dm)
        {
            IEnumerable DataSource = OrderRepository.GetComplexRecords().ToList();
            BatchDataResult result = new BatchDataResult();
            DataOperations obj = new DataOperations();
            if (dm.Skip != 0)
            {
                DataSource = obj.PerformSkip(DataSource, dm.Skip);
            }
            if (dm.Take != 0)
            {
                DataSource = obj.PerformTake(DataSource, dm.Take);
            }            
            result.result = DataSource;
            result.count = OrderRepository.GetComplexRecords().Count();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public class BatchDataResult
        {
            public IEnumerable result { get; set; }
            public int count { get; set; }
        }

        public List<object> EmployeeID
        {
            get
            {
                var employeeID = OrderRepository.GetComplexRecords().Select(s => s.EmployeeID).Distinct().ToList(); 
                var EmployeeID = new List<object>();
                foreach (var id in employeeID)
                {
                    EmployeeID.Add(new { value = id, text = id });
                }
                return EmployeeID;
            }
        }

        public List<object> ShipCountry
        {
            get
            {
                var shipCountry = OrderRepository.GetComplexRecords().Select(s => s.ShipCountry).Distinct().ToList();
                var ShipCountry = new List<object>();
                foreach (var id in shipCountry)
                {
                    ShipCountry.Add(new { value = id, text = id });
                }
                return ShipCountry;
            }
        }  

        public ActionResult BatchUpdate(List<EditableOrder> changed, List<EditableOrder> added, List<EditableOrder> deleted)
        {
            if (changed != null)
                OrderRepository.ComplexUpdate(changed);
            if (deleted != null)
                OrderRepository.ComplexDelete(deleted);
            if (added != null)
                OrderRepository.ComplexAdd(added);
            var data = OrderRepository.GetComplexRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
