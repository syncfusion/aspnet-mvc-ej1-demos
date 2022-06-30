#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.DocIO.DLS;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.XlsIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        // GET: ColumnTemplateExporting
        public ActionResult ColumnTemplateExporting()
        {
            var DataSource = new NorthwindDataContext().EmployeeViews.Take(8).ToList();
            ViewBag.datasource = DataSource;
            return View();
        }
        public void ColumnTemplateExportToExcel(string GridModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = new NorthwindDataContext().EmployeeViews.Take(8).ToList();
            GridProperties obj = ConvertGridObject3(GridModel);
            obj.ExcelColumnTemplateInfo = ExceltemplateInfo;
            exp.Export(obj, DataSource, "Export.xlsx", ExcelVersion.Excel2010, false, true, "flat-saffron");
        }

        public void ColumnTemplateToWord(string GridModel)
        {
            WordExport exp = new WordExport();
            var DataSource = new NorthwindDataContext().EmployeeViews.Take(8).ToList();
            GridProperties obj = ConvertGridObject3(GridModel);
            obj.WordColumnTemplateInfo = WordTemplateInfo;
            exp.Export(obj, DataSource, "Export.docx", false, true, "flat-saffron");
        }

        public void ColumnTemplateExportToPdf(string GridModel)
        {
            PdfExport exp = new PdfExport();
            var DataSource = new NorthwindDataContext().EmployeeViews.Take(8).ToList();
            GridProperties obj = ConvertGridObject(GridModel);
            obj.PdfColumnTemplateInfo = PdfTemplateInfo;
            exp.Export(obj, DataSource, "Export.pdf", false, true, "flat-saffron");
        }
        public void ExceltemplateInfo(object currentCell, object row)
        {
            IRange range = (IRange)currentCell;
            object templatevalue;
            foreach (var ds in row.GetType().GetProperties())
            {
                if (range.Value.ToString().Contains(ds.Name))
                {
                    templatevalue = row.GetType().GetProperty(ds.Name).GetValue(row, null);
                    range.Value = range.Value.Replace(ds.Name, templatevalue.ToString());
                    var regex = new Regex("<a [^>]*href=(?:'(?<href>.*?)')|(?:\"(?<href>.*?)\")", RegexOptions.IgnoreCase);
                    var urls = regex.Matches(range.Value.ToString()).OfType<Match>().Select(m => m.Groups["href"].Value).SingleOrDefault();
                    IHyperLink hyperlink = (range.Parent as Syncfusion.XlsIO.Implementation.WorksheetImpl).HyperLinks.Add(range);
                    hyperlink.Type = ExcelHyperLinkType.Url;
                    hyperlink.TextToDisplay = templatevalue.ToString();
                    hyperlink.Address = urls; 
                }
            }
        }
        public void PdfTemplateInfo(object currentCell, object row)
        {
            Syncfusion.Pdf.Grid.PdfGridCell range = (Syncfusion.Pdf.Grid.PdfGridCell)currentCell;
            object templatevalue;
            foreach (var ds in row.GetType().GetProperties())
            {
                if (range.Value.ToString().Contains(ds.Name))
                {
                    templatevalue = row.GetType().GetProperty(ds.Name).GetValue(row, null);
                    var regex = new Regex("<a [^>]*href=(?:'(?<href>.*?)')|(?:\"(?<href>.*?)\")", RegexOptions.IgnoreCase);
                    var urls = regex.Matches(range.Value.ToString()).OfType<Match>().Select(m => m.Groups["href"].Value).SingleOrDefault();
                    RectangleF rectangle = new RectangleF(10, 40, 30, 30);
                    PdfUriAnnotation uriAnnotation = new PdfUriAnnotation(rectangle, urls);
                    uriAnnotation.Text = templatevalue.ToString();
                    range.Value = uriAnnotation;
                
                }
            }
        }
        public void WordTemplateInfo(object currentCell, object row)
        {
            WTableCell wCell = (WTableCell)currentCell;
            object templatevalue;
            foreach (var ds in row.GetType().GetProperties())
            {
                if (wCell.LastParagraph.Text.ToString().Contains(ds.Name))
                {
                    templatevalue = row.GetType().GetProperty(ds.Name).GetValue(row, null);
                    var regex = new Regex("<a [^>]*href=(?:'(?<href>.*?)')|(?:\"(?<href>.*?)\")", RegexOptions.IgnoreCase);
                    var urls = regex.Matches(wCell.LastParagraph.Text).OfType<Match>().Select(m => m.Groups["href"].Value).SingleOrDefault();
                    wCell.LastParagraph.Text = "";
                    IWField field = wCell.LastParagraph.AppendHyperlink(urls, templatevalue.ToString(), HyperlinkType.WebLink);
                   
                }
            }
        }
        private GridProperties ConvertGridObject3(string gridProperty)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            IEnumerable div = (IEnumerable)serializer.Deserialize(gridProperty, typeof(IEnumerable));
            GridProperties gridProp = new GridProperties();
            foreach (KeyValuePair<string, object> ds in div)
            {
                var property = gridProp.GetType().GetProperty(ds.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
                if (property != null)
                {
                    Type type = property.PropertyType;
                    string serialize = serializer.Serialize(ds.Value);
                    object value = serializer.Deserialize(serialize, type);
                    property.SetValue(gridProp, value, null);
                }
            }
            return gridProp;
        }
    }
}