#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using Syncfusion.Linq;
using System.Collections;
using Syncfusion.JavaScript;
using MVCSampleBrowser.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using Syncfusion.JavaScript.DataSources;


namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /KORemoteBinding/

        public ActionResult KORemoteBinding()
        {
            return View();
        }

        public ActionResult KODataSource(DataManager dm)
        {
            IEnumerable DataSource = OrderRepository.GetAllRecords();
            KODataResult result = new KODataResult();
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

        public class KODataResult
        {
            public IEnumerable result { get; set; }
            public int count { get; set; }
        }
        public ActionResult Update(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Insert(EditableOrder value)
        {
            OrderRepository.Add(value);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Remove(int key)
        {
            OrderRepository.Delete(key);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    
    }
}
