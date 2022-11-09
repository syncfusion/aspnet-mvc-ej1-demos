#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.PivotGrid
{
    public partial class PivotGridController : Controller
    {
        public ActionResult AdvancedFiltering()
        {
            return View();
        }
		public ActionResult DrillThrough()
        {
            return View();
        }
        public ActionResult CalculatedFields()
        {
            return View();
        }
        public ActionResult CellContext()
        {
            return View();
        }
        public ActionResult CellEditing()
        {
            return View();
        }
        public ActionResult CellSelection()
        {
            return View();
        }
        public ActionResult ColumnResizing()
        {
            return View();
        }
        public ActionResult ConditionalFormatting()
        {
            return View();
        }
        public ActionResult ExcelLikeLayout()
        {
            return View();
        }
        public ActionResult Exporting()
        {
            return View();
        }
        public ActionResult FieldList()
        {
            return View();
        }
        public ActionResult FrozenHeaders()
        {
            return View();
        }
        public ActionResult GroupingBar()
        {
            return View();
        }
        public ActionResult Hyperlink()
        {
            return View();
        }
        public ActionResult KPI()
        {
            return View();
        }
        public ActionResult Localization()
        {
            return View();
        }
        public ActionResult NamedSets()
        {
            return View();
        }
        public ActionResult NumberFormats()
        {
            return View();
        }
        public ActionResult OlapDefault()
        {
            return View();
        }
        public ActionResult OlapWCF()
        {
            return View();
        }
        public ActionResult OlapWebAPI()
        {
            return View();
        }
        public ActionResult Paging()
        {
            return View();
        }
        public ActionResult RelationalDefault()
        {
            return View();
        }
        public ActionResult RelationalWCF()
        {
            return View();
        }
        public ActionResult RelationalWebAPI()
        {
            return View();
        }
        public ActionResult RTL()
        {
            return View();
        }
        public ActionResult SaveAndLoad()
        {
            return View();
        }
        public ActionResult SummaryCustomization()
        {
            return View();
        }
        public ActionResult SummaryTypes()
        {
            return View();
        }
        public ActionResult UserInteractions()
        {
            return View();
        }
        public ActionResult ValueSorting()
        {
            return View();
        }
        public void ExcelExport()
        {
            PivotGridExcelExport pGrid = new PivotGridExcelExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            string fileName = "Sample";
            pGrid.ExportToExcel(fileName, args, System.Web.HttpContext.Current.Response);
        }
        public void PDFExport()
        {
            PivotGridPDFExport pGrid = new PivotGridPDFExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            string fileName = "Sample";
            pGrid.ExportToPDF(fileName, args, System.Web.HttpContext.Current.Response);
        }

        public void CSVExport()
        {
            PivotGridCSVExport pGrid = new PivotGridCSVExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            string fileName = "Sample";
            pGrid.ExportToCSV(fileName, args, System.Web.HttpContext.Current.Response);
        }

        public void WordExport()
        {
            PivotGridWordExport pGrid = new PivotGridWordExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            string fileName = "Sample";
            pGrid.ExportToWord(fileName, args, System.Web.HttpContext.Current.Response);
        }
    }
}