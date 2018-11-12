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
