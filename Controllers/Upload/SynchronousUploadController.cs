#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCSampleBrowser.Controllers
{
    public partial class UploadController : Controller
    {
        //
        // GET: /SynchronousUpload/

        public ActionResult SynchronousUpload()
        {
            if (string.IsNullOrEmpty((string)TempData["status"]))
                ViewBag.status = string.Empty;
            else
                ViewBag.status = (string)TempData["status"];
            return View();
        }

        public ActionResult SaveSynchronous(IEnumerable<HttpPostedFileBase> Synchronous)
        {
            if (Synchronous != null)
            {
                foreach (var file in Synchronous)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                    //file.SaveAs(destinationPath);
                }
                TempData["status"]= "Successfully Uploaded";
                return RedirectToAction("SynchronousUpload");
            }
            else
            {
                TempData["status"]= "Select a file to upload";
                return RedirectToAction("SynchronousUpload");
            }

        }
    }
}
