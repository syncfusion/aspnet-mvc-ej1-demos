#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using System.IO;

namespace MVCSampleBrowser.Controllers
{
    public partial class PdfController : Controller
    {
        //
        // GET: /MergeDocuments/

        public ActionResult MergeDocuments()
        {
            ViewData["Error"] = "";
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MergeDocuments(string InsideBrowser)
        {

            Stream stream1 = new FileStream(ResolveApplicationDataPath("Essential_Pdf.pdf"), FileMode.Open, FileAccess.Read);
            Stream stream2 = new FileStream(ResolveApplicationDataPath("Essential_XlsIO.pdf"), FileMode.Open, FileAccess.Read);

            //Load the documents as streams
            PdfLoadedDocument doc1 = new PdfLoadedDocument(stream1);
            PdfLoadedDocument doc2 = new PdfLoadedDocument(stream2);

            object[] dobj = { doc1, doc2 };
            PdfDocument doc = new PdfDocument();
            PdfDocument.Merge(doc, dobj);

            if (InsideBrowser == "Browser")
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }

    }
}
