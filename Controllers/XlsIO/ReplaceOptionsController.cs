using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Collections;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {

        public ActionResult ReplaceOptions(string FindList, string CheckBox1, string CheckBox2, string ReplaceText, string button)
        {
            if (FindList == null)
            {
                return View();
            }
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"ReplaceOptions.xlsx"), ExcelOpenType.Automatic);
                return excelEngine.SaveAsActionResult(workbook, "ReplaceOptions.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

            }
            else
            {

                ExcelEngine excelEngine = new ExcelEngine();
                //Get the path of the input file
                string inputPath = ResolveApplicationDataPath("ReplaceOptions.xlsx");
                IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
                IWorksheet sheet = workbook.Worksheets[0];

                ExcelFindOptions options = ExcelFindOptions.None;
                if (CheckBox1 != null) options |= ExcelFindOptions.MatchCase;
                if (CheckBox2 != null) options |= ExcelFindOptions.MatchEntireCellContent;

                sheet.Replace(FindList, ReplaceText, options);
                                
                workbook.Version = ExcelVersion.Excel2016;
                return excelEngine.SaveAsActionResult(workbook, "ReplaceOptions.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

            }
        }
    }
}
