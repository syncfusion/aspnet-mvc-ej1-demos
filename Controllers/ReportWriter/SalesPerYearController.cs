#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ.ReportWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Reports.EJ;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportWriterController : Controller
    {
        // GET: SalesPerYear
        public ActionResult SalesPerYear()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SalesPerYear(string writerFormat)
        {
            try
            {
                string fileName = null;
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                MVCSampleBrowser.Models.CompanySales sales = new MVCSampleBrowser.Models.CompanySales();
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Local;
                reportWriter.ReportPath = Server.MapPath("~/App_Data/Reports/Company Sales.rdlc");
                reportWriter.DataSources = new ReportDataSourceCollection { new ReportDataSource { Name = "Sales", Value = sales.GetData() } };

                if (writerFormat == "PDF")
                {
                    fileName = "Company Sales.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "Company Sales.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "Company Sales.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "Company Sales.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch { }

            return View();
        }
    }
}