using MVCSampleBrowser.Areas.SpreadsheetTemplate.Models;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.SpreadsheetTemplate.Controllers
{
    public class SampleController : Controller
    {
        //
        // GET: /SpreadsheetTemplate/Sample/

        public ActionResult spreadsheettemplate()
        {
            var DataSource = GetLoanDetails().ToList();
            var SampleData = GetpaymentDetails().ToList();
            ViewBag.Datasource = DataSource;
            ViewBag.SampleData = SampleData;
            return View();
        }

        public IEnumerable<object> GetLoanDetails()
        {
            List<ItemDetail> lItems = new List<ItemDetail>();
            lItems.Add(new ItemDetail() { DATE = "1/2/2013", ITEM = "January payment", AMOUNT = 321, CHECK = 1055, REMARKS = "Good" });
            lItems.Add(new ItemDetail() { DATE = "2/2/2013", ITEM = "February payment", AMOUNT = 451, CHECK = 1062, REMARKS = "Average" });
            return lItems;
        }

        public IEnumerable<object> GetpaymentDetails()
        {

            List<paymentDetail> sampleData = new List<paymentDetail>();
            sampleData.Add(new paymentDetail() { DATE = "1/5/2013", ITEM = "Oil change", COST = 45, ODOM = 10567, REMARKS = "Average" });
            sampleData.Add(new paymentDetail() { DATE = "1/18/2013", ITEM = "Service", COST = 91, ODOM = 11420, REMARKS = "Bad" });
            sampleData.Add(new paymentDetail() { DATE = "3/1/2013", ITEM = "Alignment", COST = 88, ODOM = 12889, REMARKS = "Good" });
            return sampleData;
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
