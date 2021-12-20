#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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

namespace MvcSampleBrowser.Controllers.PivotChart
{
    public partial class PivotChartController : Controller
    {
        public ActionResult Chart3D()
        {
            return View();
        }
        public ActionResult MultiLevelLabels()
        {
            return View();
        }
        public ActionResult ChartTypes()
        {
            return View();
        }
        public ActionResult Exporting()
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
        public ActionResult MultipleAxes()
        {
            return View();
        }

        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };

        public void ExcelExport()
        {
            PivotChartExcelExport pivotChartExcelExport = new PivotChartExcelExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            Dictionary<string, string> chartParams = serializer.Deserialize<Dictionary<string, string>>(args);
            pivotChartExcelExport.ExportToExcel(chartParams);
        }

        public void WordExport()
        {
            PivotChartWordExport pivotChartWordExport = new PivotChartWordExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            Dictionary<string, string> chartParams = serializer.Deserialize<Dictionary<string, string>>(args);
            pivotChartWordExport.ExportToWord(chartParams);
        }

        public void PDFExport()
        {
            PivotChartPDFExport pivotChartPDFExport = new PivotChartPDFExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            Dictionary<string, string> chartParams = serializer.Deserialize<Dictionary<string, string>>(args);
            pivotChartPDFExport.ExportToPDF(chartParams);
        }

        public void ImageExport()
        {
            PivotChartImageExport pivotChartImageExport = new PivotChartImageExport();
            string args = System.Web.HttpContext.Current.Request.Form.GetValues(0)[0];
            Dictionary<string, string> chartParams = serializer.Deserialize<Dictionary<string, string>>(args);
            pivotChartImageExport.ExportToImage(chartParams);
        }
    }
}
