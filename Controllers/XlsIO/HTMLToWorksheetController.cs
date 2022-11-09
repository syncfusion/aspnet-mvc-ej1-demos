#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.Mvc;
using System.IO;
using Syncfusion.XlsIO;


namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /HTMLToWorksheet/

        public ActionResult HTMLToWorksheet(string button,string chkbox)
        {
            if (button == null)
                return View();
            else if (button == "Input Template")
            {
                Stream ms = new FileStream(ResolveApplicationDataPath("HTMLToExcel.html"), FileMode.Open, FileAccess.Read);
                return File(ms, "text/html", "Import-HTML-Table.html");
            }
            else
            {
                // The instantiation process consists of two steps.
                // Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                // Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                // A workbook is created.
                IWorkbook workbook = application.Workbooks.Create(1);

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                worksheet.ImportHtmlTable(ResolveApplicationDataPath(@"HTMLToExcel.html"), 1, 1);

                worksheet.UsedRange.AutofitColumns();
                worksheet.UsedRange.AutofitRows();

                MemoryStream ms = new MemoryStream();
                workbook.SaveAs(ms);
                ms.Position = 0;

                excelEngine.Dispose();

                return File(ms, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Import-HTML-Table.xlsx");
            }
        }
    }
}