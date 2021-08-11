#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /ProtectSheet/

        public ActionResult ProtectSheet()
        {
            ViewBag.DataSource = GetProtectDataSource();
            return View();
        }


        public Array GetProtectDataSource()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/ProtectSheet.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
        

    }
}
