using MVCSampleBrowser.Models.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
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
