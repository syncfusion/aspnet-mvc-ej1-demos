using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf;

namespace MVCSampleBrowser.Controllers
{
    public partial class PdfController : Controller
    {
        //
        // GET: /TextExtraction/

        public ActionResult TextExtraction()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TextExtraction(string Extract)
        {

            //Stream sfile1 = fileUpload1.PostedFile.InputStream;
            Stream sfile1 = new FileStream(ResolveApplicationDataPath("Manual.Pdf"), FileMode.Open, FileAccess.Read, FileShare.Read);
            // Load an existing PDF
            PdfLoadedDocument ldoc = new PdfLoadedDocument(sfile1);

            // Loading Page collections
            PdfLoadedPageCollection loadedPages = ldoc.Pages;

            string s = "";

            // Extract text from PDF document pages
            foreach (PdfLoadedPage lpage in loadedPages)
            {
                s += lpage.ExtractText();
            }

            //Load the text in TextBox
            ViewData["ExtractedText"] = s;


            return View();
        }

    }
}
