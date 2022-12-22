#region Copyright
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
        #region doc to PDF
        public ActionResult DOCtoPDF(string button, string renderingMode, string renderingMode1, string renderingMode2, string renderingMode3, string renderingMode4, string renderingMode5, string renderingMode6, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".doc" || extension == ".docx" || extension == ".dot" || extension == ".dotx" || extension == ".dotm" || extension == ".docm"
                   || extension == ".xml"  || extension == ".rtf")
                {
                    WordDocument document = new WordDocument(file.InputStream);

                    //Initialize chart to image converter for converting charts in Word to PDF conversion
                    document.ChartToImageConverter = new ChartToImageConverter();
                    document.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;

                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Enable Direct PDF rendering mode for faster conversion.
                    if (renderingMode == "DirectPDF")
                        converter.Settings.EnableFastRendering = true;
                    if (renderingMode1 == "PreserveStructureTags")
                        converter.Settings.AutoTag = true;
                    if (renderingMode2 == "PreserveFormFields")
                        converter.Settings.PreserveFormFields = true;
                    converter.Settings.ExportBookmarks = renderingMode3 == "PreserveWordHeadingsToPDFBookmarks"
                                      					 ? Syncfusion.DocIO.ExportBookmarkType.Headings
														 : Syncfusion.DocIO.ExportBookmarkType.Bookmarks;
                    if (renderingMode4 == "EnablesCompleteFont")
                        converter.Settings.EmbedCompleteFonts = true;
                    if (renderingMode5 == "EnablesSubsetFont")
                        converter.Settings.EmbedFonts = true;
                    if(renderingMode6 == "ShowRevisions")
                        document.RevisionOptions.ShowMarkup = RevisionType.Deletions | RevisionType.Formatting | RevisionType.Insertions;
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    try
                    {
                        return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                    }
                    catch (Exception)
                    { }
                    finally
                    {

                    }
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose Word format document to convert to PDF");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a Word document and then click the button to convert as a PDF document");
            }

            return View();
        }

        #endregion doc to PDF
    }
}