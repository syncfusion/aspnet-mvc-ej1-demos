#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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

namespace MVCSampleBrowser.Controllers.BulletGraph
{
    public partial class BulletGraphController : Controller
    {
        //
        // GET: /LocalDataBinding/
        List<BulletLocalDataBind> lclbnd = new List<BulletLocalDataBind>();
        public ActionResult LocalDataBinding()
        {
            lclbnd.Add(new BulletLocalDataBind { catagory = "2001", value = "9.5", comparitiveMeasureValue = "7.5" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2002", value = "7.5", comparitiveMeasureValue = "5" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2003", value = "6", comparitiveMeasureValue = "6" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2004", value = "8", comparitiveMeasureValue = "8" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2005", value = "8.7", comparitiveMeasureValue = "5" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2006", value = "9.2", comparitiveMeasureValue = "6" });
            ViewBag.datasource = lclbnd;
            return View();
        }

    }
}
