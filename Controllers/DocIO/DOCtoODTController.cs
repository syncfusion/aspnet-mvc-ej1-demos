#region Copyright
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using Syncfusion.OfficeChartToImageConverter;

namespace MvcSampleBrowser_2012.Controllers
{
    public partial class DocIOController : Controller
    {
        #region doc to ODT
        public ActionResult DOCtoODT(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".doc" || extension == ".docx" || extension == ".dot" || extension == ".dotx" || extension == ".dotm" || extension == ".docm"
                   || extension == ".xml" || extension == ".rtf")
                {
                    WordDocument document = new WordDocument(file.InputStream);

                    //Convert word document into ODT document
                    try
                    {
                        return document.ExportAsActionResult("WordToODT.odt", FormatType.Odt, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    catch (Exception)
                    { }
                    finally
                    {

                    }
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose Word format document to convert to ODT");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a Word document and then click the button to convert as a ODT document");
            }

            return View();

        }
        #endregion doc to ODT
    }
}