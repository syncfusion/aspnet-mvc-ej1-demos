#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Web;
using System.Linq.Expressions;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.Linq;


namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
    
        // GET: /ComprehensiveAngular/

        public ActionResult ComprehensiveAngular()
        {
            return View();
        }

        public ActionResult DataSource(DataManager dm)
        {
            IEnumerable DataSource = OrderRepository.GetAllRecords();
            DataResult result = new DataResult();
            DataOperations opt = new DataOperations();

            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {                
                DataSource = opt.PerformSorting(DataSource, dm.Sorted);
            }

            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                DataSource = opt.PerformWhereFilter(DataSource, dm.Where, dm.Where[0].Operator);
            }

            var count = DataSource.AsQueryable().Count(); //Paging
            if (dm.Skip != 0)
            {
                DataSource = opt.PerformSkip(DataSource, dm.Skip);
            }
            if (dm.Take != 0)
            {
                DataSource = opt.PerformTake(DataSource, dm.Take);
            }
            result.result = DataSource;
            result.count = count;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
               
        public class DataResult
        {
            public IEnumerable result { get; set; }
            public int count { get; set; }
        }
        public ActionResult AngularUpdate(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AngularInsert(EditableOrder value)
        {
            OrderRepository.Add(value);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AngularRemove(int key)
        {
            OrderRepository.Delete(key);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
