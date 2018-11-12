using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /ImportExport/

        public ActionResult ImportExport()
        {
            var dataSource = new OrderItemsDataContext().GetAllRecords().Take(10).ToList();
            ViewBag.DataSource = dataSource;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Import(ImportRequest importRequest)
        {
            return importRequest.SpreadsheetActions();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void ExcelExport(string sheetModel, string sheetData, string fileName, string password)
        {
            if (String.IsNullOrEmpty(password))
                Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLSX, ExcelVersion.Excel2013);
            else
                Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLSX, ExcelVersion.Excel2013, password);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void CsvExport(string sheetModel, string sheetData, string fileName)
        {
            Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.CSV);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void PdfExport(string sheetModel, string sheetData, string fileName)
        {
            Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.PDF);
        }
    }
}
