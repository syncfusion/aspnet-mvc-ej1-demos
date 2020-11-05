#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
using Syncfusion.DocIO.DLS;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /LargeData/

        public ActionResult LargeData()
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            for (int i = 0; i < 50; i++)
            {
                row = new Dictionary<string, object>();
                for (int j = 0; j < 50; j++)
                {
                    row.Add("Column" + j, "DS" + i + j);
                }
                rows.Add(row);
            }
            ViewBag.datasource = rows;
            return View();
        }

    }
}
