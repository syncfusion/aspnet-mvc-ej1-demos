using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
     public partial class UploadController : Controller
    {
        //
        // GET: /Draganddrop/

         public ActionResult DragAndDrop()
        {
            return View();
        }
        public ActionResult SaveDraganddrop(IEnumerable<HttpPostedFileBase> Draganddrop)
        {
            foreach (var file in Draganddrop)
            {
                var fileName = Path.GetFileName(file.FileName);
                var destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                //file.SaveAs(destinationPath);
            }
            return Content("");
        }
        public ActionResult RemoveDraganddrop(string[] fileNames)
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

