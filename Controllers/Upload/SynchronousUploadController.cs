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
