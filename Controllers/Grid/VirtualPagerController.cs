#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
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
        // GET: /VirtualPager/

        public ActionResult VirtualPager()
        {
            return View();
        }
        public ActionResult VirtualDataSource(DataManager dm)
        {
            IQueryable<OrdersView> datasource = new NorthwindDataContext().OrdersViews;
            var count = datasource.Count();
            if (dm.Skip >= 0)//for paging 
                datasource = QueryableDataOperations.PerformSkip(datasource, dm.Skip);
            if (dm.Take > 0)//for paging 
                datasource = QueryableDataOperations.PerformTake(datasource, dm.Take);
            return Json(new { result = datasource.ToList(), count = count });
        }
    }
}
