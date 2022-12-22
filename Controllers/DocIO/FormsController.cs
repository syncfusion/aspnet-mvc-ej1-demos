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
        public ActionResult Forms(string Group1)
        {
            if (Group1 == null)
                return View();
            #region CreateForm
            // Create a new document.
            WordDocument document = new WordDocument();

            // Adding a new section to the document.
            IWSection section = document.AddSection();

            // Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            #region Document formatting
            //Set background color.
            document.Background.Gradient.Color1 = Color.FromArgb(232, 232, 232);
            document.Background.Gradient.Color2 = Color.FromArgb(255, 255, 255);
            document.Background.Type = BackgroundType.Gradient;
            document.Background.Gradient.ShadingStyle = GradientShadingStyle.Horizontal;
            document.Background.Gradient.ShadingVariant = GradientShadingVariant.ShadingDown;

            section.PageSetup.Margins.All = 30f;
            section.PageSetup.PageSize = new SizeF(600, 600f);
            #endregion

            #region Title Section
            IWTable table = section.Body.AddTable();
            table.ResetCells(1, 2);

            WTableRow row = table.Rows[0];
            row.Height = 25f;

            IWParagraph cellPara = row.Cells[0].AddParagraph();
            string s = ResolveApplicationDataPath("image.jpg", "Content\\DocIO");
            System.Drawing.Image img = System.Drawing.Image.FromFile(s);
            IWPicture pic = cellPara.AppendPicture(img);
            pic.Height = 80;
            pic.Width = 180;

            cellPara = row.Cells[1].AddParagraph();
            row.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row.Cells[1].CellFormat.BackColor = Color.FromArgb(173, 215, 255);
            IWTextRange txt = cellPara.AppendText("Job Application Form");
            cellPara.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            txt.CharacterFormat.Bold = true;
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 18f;

            row.Cells[0].Width = 200;
            row.Cells[1].Width = 300;
            //row.Cells[1].CellFormat.FitText = true;
            row.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
            #endregion

            section.AddParagraph();

            #region General Information
            table = section.Body.AddTable();
            table.TableFormat.Paddings.All = 5.4f;
            table.ResetCells(2, 1);
            row = table.Rows[0];
            row.Height = 20;
            row.Cells[0].Width = 500;
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(198, 227, 255);
            row.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            txt = cellPara.AppendText(" General Information");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.Bold = true;
            txt.CharacterFormat.FontSize = 11f;

            row = table.Rows[1];
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].Width = 500;
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(222, 239, 255);

            txt = cellPara.AppendText("\n Full Name:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            WTextFormField txtField = cellPara.AppendTextFormField("John");
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Birth Date:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField("BirthDayField", DateTime.Now.ToString("M/d/yyyy"));
            txtField.StringFormat = "M/d/yyyy";
            txtField.Type = TextFormFieldType.DateText;
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;
            txtField.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.CharacterFormat.FontName = "Arial";
            txtField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Address:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField("221b Baker Street");
            txtField.Type = TextFormFieldType.RegularText;
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Phone:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField("(206)555-3412");
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Email:\t\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField("John@company.com");
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;
            cellPara.AppendText("\n");
            #endregion

            section.AddParagraph();

            #region Educational Qualification
            table = section.Body.AddTable();
            table.ResetCells(2, 1);
            table.TableFormat.Paddings.All = 5.4f;
            row = table.Rows[0];
            row.Height = 20;
            row.Cells[0].Width = 500;
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(198, 227, 255);
            row.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            txt = cellPara.AppendText(" Educational Qualification");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.Bold = true;
            txt.CharacterFormat.FontSize = 11f;

            row = table.Rows[1];
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].Width = 500;
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(222, 239, 255);

            txt = cellPara.AppendText("\n Type:\t\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            WDropDownFormField dropField = cellPara.AppendDropDownFormField();
            dropField.DropDownItems.Add("Higher");
            dropField.DropDownItems.Add("Vocational");
            dropField.DropDownItems.Add("Universal");
            dropField.CharacterFormat.TextColor = Color.MidnightBlue;
            dropField.CharacterFormat.FontName = "Arial";
            dropField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Institution:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField("Michigan University");
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Programming Languages:");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txt = cellPara.AppendText("\n\n\t C#:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 9f;
            dropField = cellPara.AppendDropDownFormField();
            dropField.DropDownItems.Add("Perfect");
            dropField.DropDownItems.Add("Good");
            dropField.DropDownItems.Add("Excellent");
            dropField.CharacterFormat.TextColor = Color.MidnightBlue;
            dropField.CharacterFormat.FontName = "Arial";
            dropField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n\t VB:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 9f;
            dropField = cellPara.AppendDropDownFormField();
            dropField.DropDownItems.Add("Perfect");
            dropField.DropDownItems.Add("Good");
            dropField.DropDownItems.Add("Excellent");
            dropField.CharacterFormat.TextColor = Color.MidnightBlue;
            dropField.CharacterFormat.FontName = "Arial";
            dropField.CharacterFormat.FontSize = 11f;
            #endregion
            //Protect document
            document.ProtectionType = ProtectionType.AllowOnlyFormFields;
            MemoryStream st = new MemoryStream();
            document.Save(st, FormatType.Doc);
            st.Seek(0, SeekOrigin.Begin);
            #endregion CreateForm

            #region FillForm
            // Create a new document.
            WordDocument document1 = new WordDocument(st, FormatType.Doc);
            IWSection sec = document1.LastSection;
            WTextFormField textFF;
            WDropDownFormField dropFF;

            //Access the text field
            textFF = sec.Body.FormFields[0] as WTextFormField;

            //Fill value for the textfield
            textFF.TextRange.Text = "John";

            //Access the form field with feild name
            textFF = sec.Body.FormFields["BirthDayField"] as WTextFormField;
            textFF.TextRange.Text = "5.13.1980";

            textFF = sec.Body.FormFields[2] as WTextFormField;
            textFF.TextRange.Text = "221b Baker Street";

            textFF = sec.Body.FormFields[3] as WTextFormField;
            textFF.TextRange.Text = "(206)555-3412";

            textFF = sec.Body.FormFields[4] as WTextFormField;
            textFF.TextRange.Text = "John@company.com";

            dropFF = sec.Body.FormFields[5] as WDropDownFormField;

            //Set the value
            dropFF.DropDownSelectedIndex = 1;

            textFF = sec.Body.FormFields[6] as WTextFormField;
            textFF.TextRange.Text = "Michigan University";

            dropFF = sec.Body.FormFields[7] as WDropDownFormField;
            dropFF.DropDownSelectedIndex = 1;

            dropFF = sec.Body.FormFields[8] as WDropDownFormField;
            dropFF.DropDownSelectedIndex = 2;

            //Allow only to fill the form.
            document1.ProtectionType = ProtectionType.AllowOnlyFormFields;
            #endregion FillForm

            #region Document save option
            //Save as .doc format
            if (Group1 == "WordDoc")
            {
                return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (Group1 == "WordDocx")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);

                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            #endregion Document save option
            return View();
        }
    }
}