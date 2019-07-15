#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using Syncfusion.XlsIO;
using System.Data;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {

        public  ActionResult CLRObjects(string Saveoption, string button)
        {
            ViewBag.exportButtonState = "disabled=\"disabled\"";
            //Check FileName
            string fileName = "ExportSales.xlsx";
            
            ///SaveOption Null
            if (Saveoption == null)
                return View();
            ///Button Null
            if (button == null)
                return View();

            //Start Business Object Functions
            if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(fileName));
                return excelEngine.SaveAsActionResult(workbook, fileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
            }
            else if (button == "Import From Excel")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(fileName));
                IWorksheet sheet = workbook.Worksheets[0];
                //Export Bussiness Objects
                List<Sales> CLRObjects = sheet.ExportData<Sales>(1, 1, 41, 4);
                int temp = 1;
                foreach (Sales sale in CLRObjects)
                {
                    sale.ID = temp;
                    temp++;
                }
                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
                //Set the grid value to the Session
                SessionExport.SetDataToSession<Sales>(Session, "Export", CLRObjects);
                //Add the data to Grid
                var DataSource = CLRObjects;
                ViewBag.datasource = DataSource;
                ViewBag.exportButtonState = "";
                return View();
                //return new CustomResult(HttpContext.ApplicationInstance.Response);
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;

                if (Saveoption == "Xls")
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
                else
                    application.DefaultVersion = ExcelVersion.Excel2016;

                //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
                //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
                IWorkbook workbook;
                workbook = excelEngine.Excel.Workbooks.Create(1);
                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                object value = SessionExport.GetDataFromSession<object>(Session,"Export");
                
                //Import Bussiness Object to worksheet
                sheet.ImportData((IList<Sales>)value, 5, 1, false);
                sheet.Range["E4"].Text = "";
                #region Define Styles
                IStyle pageHeader = workbook.Styles.Add("PageHeaderStyle");
                IStyle tableHeader = workbook.Styles.Add("TableHeaderStyle");

                pageHeader.Font.RGBColor = Color.FromArgb(0, 83, 141, 213);
                pageHeader.Font.FontName = "Calibri";
                pageHeader.Font.Size = 18;
                pageHeader.Font.Bold = true;
                pageHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                pageHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;

                tableHeader.Font.Color = ExcelKnownColors.White;
                tableHeader.Font.Bold = true;
                tableHeader.Font.Size = 11;
                tableHeader.Font.FontName = "Calibri";
                tableHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                tableHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;
                tableHeader.Color = Color.FromArgb(0, 118, 147, 60);
                tableHeader.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                tableHeader.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                tableHeader.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                tableHeader.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                #endregion

                #region Apply Styles
                // Apply style for header
                sheet["A1:E1"].Merge();
                sheet["A1"].Text = "Yearly Sales Report";
                sheet["A1"].CellStyle = pageHeader;
                sheet["A2:E2"].Merge();
                sheet["A2"].Text = "Namewise Sales Comparison Report";
                sheet["A2"].CellStyle = pageHeader;
                sheet["A2"].CellStyle.Font.Bold = false;
                sheet["A2"].CellStyle.Font.Size = 16;
                sheet["A3:A4"].Merge();
                sheet["B3:B4"].Merge();
                sheet["E3:E4"].Merge();
                sheet["C3:D3"].Merge();
                sheet["C3"].Text = "Sales";
                sheet["A3:E4"].CellStyle = tableHeader;
                sheet["A3"].Text = "S.ID";
                sheet["B3"].Text = "Sales Person";
                sheet["C4"].Text = "January - June";
                sheet["D4"].Text = "July - December";
                sheet["E3"].Text = "Change(%)";
                sheet.UsedRange.AutofitColumns();
                sheet.Columns[0].ColumnWidth = 10;
                sheet.Columns[1].ColumnWidth = 24;
                sheet.Columns[2].ColumnWidth = 21;
                sheet.Columns[3].ColumnWidth = 21;
                sheet.Columns[4].ColumnWidth = 16;
                #endregion
                
                try
                {
                    //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
                    //an existing spreadsheet and then saving the result to a new workbook.

                    if (Saveoption == "Xlsx")
                        return excelEngine.SaveAsActionResult(workbook, "CLRObjects.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    else
                        return excelEngine.SaveAsActionResult(workbook, "CLRObjects.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                }
                catch (Exception)
                {
                }

                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
            }
            return View();
        }
        public ActionResult Update(Sales value)
        {
            object salesList = SessionExport.GetDataFromSession<object>(Session, "Export");
            foreach(Sales sale in (salesList as IList<Sales>))
            {
                if(sale.ID == (value as Sales).ID)
                {
                    sale.SalesJanJune = (value as Sales).SalesJanJune;
                    sale.SalesJulyDec = (value as Sales).SalesJulyDec;
                    sale.SalesPerson = (value as Sales).SalesPerson;
                    sale.Change = (value as Sales).Change;
                }
            }
            SessionExport.SetDataToSession<Sales>(Session, "Export", salesList);
            return Json(value, JsonRequestBehavior.AllowGet);
        }
    }
    public static class SessionExport
    {
        #region Session Methods
        //Get Method
        public static T GetDataFromSession<T>(this HttpSessionStateBase session, string key)
        {
            return (T)session[key];
        }
        //Set Method
        public static void SetDataToSession<T>(this HttpSessionStateBase session, string key, object value)
        {
            session[key] = value;
        }
        #endregion
    }
    #region Helper Class
    [Serializable]
    public class Sales
    {
        #region Members
        private int m_Id;
        private string m_salesPerson;
        private int m_salesJanJune;
        private int m_salesJulyDec;
        private int m_change;
        #endregion

        #region Prperties
        public int ID
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
            }
        }
        public string SalesPerson
        {
            get
            {
                return m_salesPerson;
            }
            set
            {
                m_salesPerson = value ;
            }
        }

        public int SalesJanJune
        {
            get
            {
                return m_salesJanJune;
            }
            set
            {
                m_salesJanJune = value;
            }
        }
        public int SalesJulyDec
        {
            get
            {
                return m_salesJulyDec;
            }
            set
            {
                m_salesJulyDec = value;
            }

        }
        public int Change
        {
            get
            {
                return m_change;
            }
            set
            {
                m_change = value;
            }

        }
        #endregion
    }

    public class CustomResult : ActionResult
    {
        public HttpResponse Response { get; set; }
        public CustomResult(HttpResponse response)
        {
            Response = response;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            Response.End();
        }
    }
    #endregion
}
