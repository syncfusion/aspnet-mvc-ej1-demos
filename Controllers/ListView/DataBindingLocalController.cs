#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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

namespace MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {
        //
        // GET: /DataBindingLocal/

        public ActionResult DataBindingLocal()
        {
            ListDataModal.clearSource();
            return View(ListDataModal.setListDataSource());
            
        }

    }
}