#region Copyright
// Copyright Syncfusion Inc. 2001 - 2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

namespace MvcSampleBrowser_2012.Controllers
{
    public partial class DocIOController : Controller
    {
        public ActionResult AdvancedReplace(string Group1, string Button)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("MasterTemplate.doc", ResolveApplicationDataPath("App_Data\\DocIO"), HttpContext.ApplicationInstance.Response);
            try
            {
                // Creating new documents.
                WordDocument docSource1 = new WordDocument();
                WordDocument docSource2 = new WordDocument();
                WordDocument docMaster = new WordDocument();

                // Load Templates.
                docSource1.Open(ResolveApplicationDataPath("SourceTemplate1.doc", "App_Data\\DocIO"), FormatType.Doc);
                docSource2.Open(ResolveApplicationDataPath("SourceTemplate2.doc", "App_Data\\DocIO"), FormatType.Doc);
                docMaster.Open(ResolveApplicationDataPath("MasterTemplate.doc", "App_Data\\DocIO"), FormatType.Doc);

                // Search for a string and store in TextSelection
                //The TextSelection copies a text segment with formatting.
                TextSelection selection1 = docSource1.Find("PlaceHolder text is replaced with this formatted animated text", false, false);

                //Get the text segment to replace the text across multiple paragraphs
                TextBodyPart replacePart = new TextBodyPart(docSource2);
                foreach (TextBodyItem bodyItem in docSource2.LastSection.Body.ChildEntities)
                    replacePart.BodyItems.Add(bodyItem.Clone());
                // Replacing the placeholder inside Master Template with matches found while
                //search the two template documents. 
                docMaster.Replace("PlaceHolder1", selection1, true, true, true);
                docMaster.ReplaceSingleLine((new System.Text.RegularExpressions.Regex("PlaceHolder2Start:Suppliers/Vendors of Northwind." +
                "Customers of Northwind.Employee details of Northwind traders.The product information.The inventory details.The shippers." +
                "PO transactions i.e Purchase Order transactions.Sales Order transaction.Inventory transactions.Invoices.PlaceHolder2End")), replacePart);

                #region document save option

                //Save as .doc format
                if (Group1 == "WordDoc")
                {
                    return docMaster.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .docx format
                else if (Group1 == "WordDocx")
                {
                    return docMaster.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                // Save as WordML(.xml) format
                else if (Group1 == "WordML")
                {
                    return docMaster.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .pdf format
                else if (Group1 == "Pdf")
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    PdfDocument pdfDoc = converter.ConvertToPDF(docMaster);
                    return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }

                #endregion document save option
            }
            catch (Exception)
            {
            }

            return View();
        }
    }
}
