using Syncfusion.EJ.ReportWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportWriterController : Controller
    {
        // GET: RowFormatting
        public ActionResult RowFormatting()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult RowFormatting(string writerFormat)
        {
            try
            {
                string fileName = null;
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Remote;
                reportWriter.ReportPath = Server.MapPath("~/App_Data/Reports/ConditionalRowFormatting.rdl");

                if (writerFormat == "PDF")
                {
                    fileName = "ConditionalRowFormatting.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "ConditionalRowFormatting.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "ConditionalRowFormatting.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "ConditionalRowFormatting.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch { }

            return View();
        }
    }
}