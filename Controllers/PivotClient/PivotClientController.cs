#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers.PivotClient
{
    public partial class PivotClientController : Controller
    {
        //
        // GET: /PivotClient/

        public ActionResult AdvancedFiltering()
        {
            return View();
        }
        public ActionResult CalculatedMembers()
        {
            return View();
        }
        public ActionResult Customization()
        {
            return View();
        }
        public ActionResult ExportingModes()
        {
            return View();
        }
        public ActionResult Localization()
        {
            return View();
        }
        public ActionResult OlapDefault()
        {
            return View();
        }
        public ActionResult OlapWCF()
        {
            return View();
        }
        public ActionResult OlapWebAPI()
        {
            return View();
        }
        public ActionResult Paging()
        {
            return View();
        }
        public ActionResult RelationalDefault()
        {
            return View();
        }
        public ActionResult RelationalWCF()
        {
            return View();
        }
        public ActionResult RelationalWebAPI()
        {
            return View();
        }
        public ActionResult RTL()
        {
            return View();

        }
        public ActionResult DrillThrough()
        {
            return View();

        }
        public void ExportPivotClient()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };
            PivotClientExport olapClient = new PivotClientExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            olapClient.ExportPivotClient(string.Empty, args, System.Web.HttpContext.Current.Response);

        }  
        
    }
}
