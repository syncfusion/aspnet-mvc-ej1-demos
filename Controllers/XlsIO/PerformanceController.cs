#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /Performance/
        private void Initialize()
        {            

        }
        public ActionResult Performance(string SaveOption, string Import, string rowCount, string colCount)
        {
            if (SaveOption == null)
                return View();

            int rows = Convert.ToInt32(rowCount);
            int columns = Convert.ToInt32(colCount);

            if (SaveOption == "Xls")
            {
                if (columns > 256)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Column count must be less than or equal to 256 for Excel 2003 format.');document.location='" + VirtualPathUtility.ToAbsolute("~/XlsIO/Performance") + "';</script>");
                    return View();
                }
                if (rows > 65536)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Row count must be less than or equal to 65,536 for Excel 2003 format.');document.location='" + VirtualPathUtility.ToAbsolute("~/XlsIO/Performance") + "';</script>");
                    return View();
                }
            }
            if (SaveOption == "Xlsx")
            {
                if (rows > 100001)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Row count must be less than or equal to 100,000.');document.location='" + VirtualPathUtility.ToAbsolute("~/XlsIO/Performance") + "';</script>");
                    return View();
                }
                if (columns > 151)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Column count must be less than or equal to 151.');document.location='" + VirtualPathUtility.ToAbsolute("~/XlsIO/Performance") + "';</script>");
                    return View();
                }
            }
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook;

                if (SaveOption == "Xlsx")
                    application.DefaultVersion = ExcelVersion.Excel2016;
                else
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
              
                workbook = application.Workbooks.Create(1);

                IWorksheet sheet = workbook.Worksheets[0];

                if (Import == "importonsave")
                {
                    workbook.Version = ExcelVersion.Excel2013;
                    DataTable dataTable = new DataTable();
                    for (int column = 1; column <= columns; column++)
                    {
                        dataTable.Columns.Add("Column: " + column.ToString(), typeof(int));
                    }
                    //Adding data into data table
                    for (int row = 1; row < rows; row++)
                    {
                        dataTable.Rows.Add();
                        for (int column = 1; column <= columns; column++)
                        {
                            dataTable.Rows[row - 1][column - 1] = row * column;
                        }
                    }
                    sheet.ImportDataTable(dataTable, 1, 1, true, true);
                }
                else
                {
                    IMigrantRange migrantRange = sheet.MigrantRange;

                    for (int column = 1; column <= columns; column++)
                    {
                        migrantRange.ResetRowColumn(1, column);
                        migrantRange.SetValue("Column: " + column.ToString());
                    }

                    //Writing Data using normal interface
                    for (int row = 2; row <= rows; row++)
                    {
                        //double columnSum = 0.0; 
                        for (int column = 1; column <= columns; column++)
                        {
                            //Writing number
                            migrantRange.ResetRowColumn(row, column);
                            migrantRange.SetValue(row * column);
                        }
                    }
                }
                try
                {
                    if (SaveOption == "Xls")
                        return excelEngine.SaveAsActionResult(workbook, "Performance.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                    else
                        return excelEngine.SaveAsActionResult(workbook, "Performance.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                catch (Exception)
                {
                }

                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
                return View();
            
        }
    }
}
