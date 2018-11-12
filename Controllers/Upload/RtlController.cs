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
        // GET: /UploadRtl/

        public ActionResult Rtl()
        {
            return View();
        }
        public ActionResult SaveRtl(IEnumerable<HttpPostedFileBase> UploadRtl)
        {
            foreach (var file in UploadRtl)
            {
                var fileName = Path.GetFileName(file.FileName);
                var destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                //file.SaveAs(destinationPath);
            }
            return Content("");
        }
        public ActionResult RemoveRtl(string[] fileNames)
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
