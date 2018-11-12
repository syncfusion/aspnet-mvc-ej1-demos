using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVCSampleBrowser.Controllers
{
    public partial class UploadController : Controller
    {
        //
        // GET: /UploadMethods/

        public ActionResult Methods()
        {
            return View();
        }
        public ActionResult SaveMethods(IEnumerable<HttpPostedFileBase> UploadMethods)
        {
            foreach (var file in UploadMethods)
            {
                var fileName = Path.GetFileName(file.FileName);
                var destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                //file.SaveAs(destinationPath);
            }
            return Content("");
        }
        public ActionResult RemoveMethods(string[] fileNames)
        {
            foreach (var fullName in fileNames)
            {
                var fileName = Path.GetFileName(fullName);
                var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                if (System.IO.File.Exists(physicalPath))
                {
                    System.IO.File.Delete(physicalPath);
                }
            }
            return Content("");
        } 

    }
}
