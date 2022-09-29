#region Copyright Syncfusion Inc. 2001-2022.
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
using System.Web.Mvc;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /PivotTable/

        public ActionResult PivotTable(string button, string Filter, string RowFilter, string ColumnFilter, string MultiplePageFilter, string PageFilter)
        {
            if (button == null)
                return View();

            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            IWorkbook workbook = null;
            application.DefaultVersion = ExcelVersion.Excel2016;

            if (button == "Customize Pivot Table")
            {
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("PivotTable.xlsx"));

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[1];
                sheet.Activate();
                //Access the collection of Pivot Table in the worksheet.
                IPivotTables pivotTables = sheet.PivotTables;

                //Access the Single pivot table from the collection.
                IPivotTable pivotTable = pivotTables[0];

                //Access collection of pivot fields from the pivot table.
                IPivotFields fields = pivotTable.Fields;

                //Access a Pivot field from the collection.
                IPivotField field = fields[2];
                //Add the field to page axis
                field.Axis = PivotAxisTypes.Page;
                fields[1].Axis = PivotAxisTypes.None;
                fields[0].Axis = PivotAxisTypes.None;
                fields[3].Axis = PivotAxisTypes.Row;
                fields[4].Axis = PivotAxisTypes.Column;
                IPivotField dataField = fields[5];
                //Accessing the Calculated fields from the pivot table .
                IPivotCalculatedFields calculatedfields = pivotTable.CalculatedFields;

                if (RowFilter == "RowFilter")
                {
                    if (Filter == "LabelFilter")
                    {
                        pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.CaptionNotEqual, null, "Parent", null);
                    }
                    else if (Filter == "ValueFilter")
                    {
                        pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.ValueGreaterThan, dataField, "100", null);
                    }
                    else
                    {
                        pivotTable.Fields[3].Items[0].Visible = false;
                    }

                }
                if (ColumnFilter == "ColumnFilter")
                {
                    if (Filter == "LabelFilter")
                    {
                        pivotTable.Fields[4].PivotFilters.Add(PivotFilterType.CaptionNotEqual, null, "Binder", null);
                    }
                    else if (Filter == "ValueFilter")
                    {
                        pivotTable.Fields[4].PivotFilters.Add(PivotFilterType.ValueGreaterThan, dataField, "100", null);
                    }
                    else
                    {
                        pivotTable.Fields[4].Items[0].Visible = false;
                    }

                }
                //Adding Calculatd field to the pivot table.
                //  IPivotField calculatedField = calculatedfields.Add("Percent", "Units/3000*100");
                if (PageFilter == "PageFilter")
                {
                    //Create Pivot Filter object to apply filter to page Fields
                    IPivotFilter filterValue = pivotTable.Fields[2].PivotFilters.Add();
                    //Page Field would be filtered with value 'Binder'
                    filterValue.Value1 = "East";
                    //XlsIO layout the Pivot table like Microsoft Excel
                    if (Filter != "ValueFilter")
                        pivotTable.Layout();
                }
                else if (MultiplePageFilter == "MultiplePageFilter")
                {
                    pivotTable.Fields[2].Items[0].Visible = false;
                }
                sheet.Range[1, 1, 1, 14].ColumnWidth = 11;
                sheet.SetColumnWidth(1, 15.29);
                sheet.SetColumnWidth(2, 15.29);
                try
                {
                    return excelEngine.SaveAsActionResult(workbook, "PivotTable.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                catch (Exception)
                {
                }

            }
            else
            {

                workbook = application.Workbooks.Open(ResolveApplicationDataPath("PivotCodeDate.xlsx"));

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                //Access the sheet to draw pivot table.
                IWorksheet pivotSheet = workbook.Worksheets[1];
                pivotSheet.Activate();
                //Select the data to add in cache
                IPivotCache cache = workbook.PivotCaches.Add(sheet["A1:H50"]);

                //Insert the pivot table. 
                IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A1"], cache);
                pivotTable.Fields[4].Axis = PivotAxisTypes.Page;

                pivotTable.Fields[2].Axis = PivotAxisTypes.Row;
                pivotTable.Fields[6].Axis = PivotAxisTypes.Row;
                pivotTable.Fields[3].Axis = PivotAxisTypes.Column;

                IPivotField field = pivotSheet.PivotTables[0].Fields[5];
                pivotTable.DataFields.Add(field, "Sum of Units", PivotSubtotalTypes.Sum);
                #region Apply RowField Filter
                if (RowFilter == "RowFilter")
                {
                    if (Filter == "LabelFilter")
                    {
                        pivotTable.Fields[2].PivotFilters.Add(PivotFilterType.CaptionEqual, null, "East", null);
                    }
                    else if (Filter == "ValueFilter")
                    {
                        pivotTable.Fields[2].PivotFilters.Add(PivotFilterType.ValueEqual, field, "1341", null);
                    }
                    else
                    {
                        pivotTable.Fields[2].Items[0].Visible = false;
                        pivotTable.Fields[2].Items[1].Visible = false;
                    }
                }
                #endregion

                #region Column Field Filter
                if (ColumnFilter == "ColumnFilter")
                {
                    if (Filter == "LabelFilter")
                    {
                        pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.CaptionNotEqual, null, "Jones", null);
                    }
                    else if (Filter == "ValueFilter")
                    {
                        pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.ValueEqual, field, "398", null);
                    }
                    else
                    {
                        pivotTable.Fields[3].Items[0].Visible = false;
                        pivotTable.Fields[3].Items[1].Visible = false;
                    }
                }
                #endregion
                if (PageFilter == "PageFilter")
                {
                    //'Create Pivot Filter object to apply filter to page Fields
                    IPivotFilter filterValue = pivotTable.Fields[4].PivotFilters.Add();
                    //Page Field would be filtered with value 'Binder'
                    filterValue.Value1 = "Binder";
                    //XlsIO layout the Pivot table like Microsoft Excel
                    if (Filter != "ValueFilter")
                        pivotTable.Layout();
                }
                else
                {
                    pivotTable.Fields[4].Items[1].Visible = false;
                    pivotTable.Fields[4].Items[2].Visible = false;
                }
                //Apply built in style.
                pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium2;
                pivotSheet.Range[1, 1, 1, 14].ColumnWidth = 11;
                pivotSheet.SetColumnWidth(1, 15.29);
                pivotSheet.SetColumnWidth(2, 15.29);
                //Activate the pivot sheet.
                pivotSheet.Activate();

                try
                {
                    workbook.Version = ExcelVersion.Excel2016;
                    return excelEngine.SaveAsActionResult(workbook, "PivotTable.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                catch (Exception)
                {
                }
            }
            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            return View();
        }

    }
}
