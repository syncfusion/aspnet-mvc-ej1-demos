#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.DigitalGauge
{
    public partial class DigitalGaugeController : Controller
    {
        //
        // GET: /ExportImage/

        List<FileFormat> fileType = new List<FileFormat>();
        public ActionResult ExportImage()
        {
            fileType.Add(new FileFormat { fileType = "JPEG" });
            fileType.Add(new FileFormat { fileType = "PNG" });
            ViewBag.datasource = fileType;
            return View();
        }

    }
}
