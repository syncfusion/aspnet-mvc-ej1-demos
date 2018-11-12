using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ.ReportWriter;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportWriterController : Controller
    {
        // GET: ConditionalFormatting
        public ActionResult ConditionalFormatting()
        {
            return View();
        }

         [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ConditionalFormatting(string writerFormat)
        {
            try
            {
                string fileName = null;
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Remote;
                reportWriter.ReportPath = Server.MapPath("~/App_Data/Reports/ConditionalFormating.rdl");
                
                if (writerFormat == "PDF")
                {
                    fileName = "ConditionalFormating.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "ConditionalFormating.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "ConditionalFormating.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "ConditionalFormating.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch
            {
            }
            return View();
        }
    }
    }