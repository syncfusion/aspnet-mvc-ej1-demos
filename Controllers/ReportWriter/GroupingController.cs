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
        // GET: Grouping
        public ActionResult Grouping()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Grouping(string writerFormat)
        {
            try
            {
                string fileName = null;
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Local;
                reportWriter.ReportPath = Server.MapPath("~/App_Data/Reports/drilldown.rdlc");
                reportWriter.DataSources.Clear();
                reportWriter.DataSources.Add(new ReportDataSource { Name = "Customers", Value = Customers.GetData() });

                if (writerFormat == "PDF")
                {
                    fileName = "Grouping.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "Grouping.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "Grouping.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "Grouping.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch { }

            return View();
        }
    }
}