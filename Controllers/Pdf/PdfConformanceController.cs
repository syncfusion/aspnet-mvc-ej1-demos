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
using System.IO;
using System.Drawing;
using Syncfusion.Pdf.Interactive;

namespace MVCSampleBrowser.Controllers
{
    public partial class PdfController : Controller
    {
        //
        // GET: /PdfConformance/

        public ActionResult PdfConformance()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PdfConformance(string Browser, string radioButton)
        {
		    PdfDocument doc = null;
			
			if (radioButton == "Pdf_A1B")
            {
                //Create a new document with PDF/A standard.
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A1B);
            }
            else if (radioButton == "Pdf_A2B")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A2B);
            }
            else if (radioButton == "Pdf_A3B")
			{
				doc = new PdfDocument(PdfConformanceLevel.Pdf_A3B);
				PdfAttachment attachment = new PdfAttachment(ResolveApplicationDataPath("PDF_A.rtf"));
                attachment.Relationship = PdfAttachmentRelationship.Alternative;
                attachment.ModificationDate = DateTime.Now;

                attachment.Description = "PDF_A";

                attachment.MimeType = "application/xml";

                doc.Attachments.Add(attachment);
			}
			else if (radioButton == "Pdf_X1A2001")
			{
				doc = new PdfDocument(PdfConformanceLevel.Pdf_X1A2001);
			}
            //Add a page
            PdfPage page = doc.Pages.Add();

            //Create Pdf graphics for the page
            PdfGraphics g = page.Graphics;

            string jpgImage = ResolveApplicationImagePath("AdventureCycle.jpg");
            PdfImage image = new PdfBitmap(jpgImage);

            //Draw the image in the specified location and size.
            g.DrawImage(image, new RectangleF(150, 30, 200, 100));

            PdfFont font = new PdfTrueTypeFont(new Font("Arial", 14));

            PdfTextElement textElement = new PdfTextElement("Adventure Works Cycles, the fictitious company on which the AdventureWorks sample databases are based," +
                                " is a large, multinational manufacturing company. The company manufactures and sells metal and composite bicycles to North American, " +
                                "European and Asian commercial markets. While its base operation is located in Bothell, Washington with 290 employees, several regional" +
                                " sales teams are located throughout their market base.")
            {
                Font = font
            };
            PdfLayoutResult layoutResult = textElement.Draw(page, new RectangleF(0, 150, page.GetClientSize().Width, page.GetClientSize().Height));

            //Stream the output to the browser.    
            if (Browser == "Browser")
            {
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }

        }

    }
}
