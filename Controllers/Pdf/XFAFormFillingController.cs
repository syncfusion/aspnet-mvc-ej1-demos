#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
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
using Syncfusion.Pdf.Xfa;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System.IO;

namespace MVCSampleBrowser.Controllers
{
    public partial class PdfController : Controller
    {
        //
        // GET: /FormFilling/

        public ActionResult XFAFormFilling()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult XFAFormFilling(string submit1, string submit, string InsideBrowser, string Flatten)
        {
            if (submit1 == "View Template")
            {
                string dataPath = ResolveApplicationDataPath("xfaTemplate.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument doc = new PdfLoadedDocument(file2);
                return doc.ExportAsActionResult("XfaFormTemplate.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else if (submit == "Create PDF")
            {
                string dataPath = ResolveApplicationDataPath("xfaTemplate.pdf");

                Stream file1 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the existing XFA document.
                PdfLoadedXfaDocument ldoc = new PdfLoadedXfaDocument(file1);

                //Loaded the existing XFA form.
                PdfLoadedXfaForm lform = ldoc.XfaForm;

                //Fill the XFA form fields.
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["title[0]"] as PdfLoadedXfaComboBoxField).SelectedIndex = 0;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["fn[0]"] as PdfLoadedXfaTextBoxField).Text = "Simons";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["ln[0]"] as PdfLoadedXfaTextBoxField).Text = "Bistro";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["dob[0]"] as PdfLoadedXfaDateTimeField).Value = new DateTime(1989, 5, 21);
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["company[0]"] as PdfLoadedXfaTextBoxField).Text = "XYZ Pvt Ltd";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["jt[0]"] as PdfLoadedXfaTextBoxField).Text = "Developer";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["jd[0]"] as PdfLoadedXfaTextBoxField).Text = "Develop and maintain components and applications for the web, desktop and mobile platforms. \nWork with some of the best UI/UX designers in the world to craft Stunning user interfaces. \nRegular appraisals to ensure quick growth if you deliver on the job.";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["st[0]"] as PdfLoadedXfaTextBoxField).Text = "Vinbaeltet 34";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["ad1[0]"] as PdfLoadedXfaTextBoxField).Text = "Kobenhaven";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["city[0]"] as PdfLoadedXfaTextBoxField).Text = "Denmark";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["state[0]"] as PdfLoadedXfaComboBoxField).SelectedIndex = 1;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["zip[0]"] as PdfLoadedXfaNumericField).NumericValue = 24534;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["country[0]"] as PdfLoadedXfaTextBoxField).Text = "US";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["em[0]"] as PdfLoadedXfaTextBoxField).Text = "simonsbistro@outlook.com";
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["phone[0]"] as PdfLoadedXfaNumericField).NumericValue = 8765456789;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["sdn[0]"] as PdfLoadedXfaListBoxField).SelectedItems = new string[] { "Vegan", "Diary Free" };
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["san[0]"] as PdfLoadedXfaListBoxField).SelectedIndex = 0;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["email[0]"] as PdfLoadedXfaCheckBoxField).IsChecked = true;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["phone[1]"] as PdfLoadedXfaCheckBoxField).IsChecked = true;
                (((lform.Fields["subform1[0]"] as PdfLoadedXfaForm).Fields["subform3[0]"] as PdfLoadedXfaForm).Fields["group1[0]"] as PdfLoadedXfaRadioButtonGroup).Fields[1].IsChecked = true;

                if (Flatten == "Flatten")
                {
                    //Flatten the XFA form
                    ldoc.Flatten = true;
                }

                //Save to disk
                if (InsideBrowser == "Browser")
                {
                    return ldoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open, true);
                }
                else
                {
                    return ldoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save, true);
                }
            }
            return View();
        }

    }
}
