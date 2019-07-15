#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Syncfusion.EJ.ReportWriter;
using Syncfusion.Reports.EJ;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportWriterController : Controller
    {
        // GET: Default
        public ActionResult Default()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Export(string writerFormat)
        {
            try
            {
                string fileName = null;
                string reportserverUrl = WebConfigurationManager.AppSettings["ReportServerUrl"];
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Remote;
                reportWriter.ReportServerUrl = reportserverUrl;
                reportWriter.ReportPath = "/SSRSSamples2/Territory Sales new";
                reportWriter.ReportServerCredential = new System.Net.NetworkCredential("ssrs", "RDLReport1");

                DataSourceCredentials _credential = new DataSourceCredentials();
                _credential.Name = "AdventureWorks";
                _credential.UserId = "ssrs1";
                _credential.Password = "RDLReport1";

                IList<DataSourceCredentials> _credentials = new List<DataSourceCredentials>();
                _credentials.Add(_credential);
                reportWriter.SetDataSourceCredentials(_credentials);

                if (writerFormat == "PDF")
                {
                    fileName = "Territory Sales.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "Territory Sales.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "Territory Sales.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "Territory Sales.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch { }

            return View();
        }
    }
}