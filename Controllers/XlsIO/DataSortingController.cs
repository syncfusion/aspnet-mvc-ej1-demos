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
using System.Drawing;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /DataSorting/

        public ActionResult DataSorting(string view, string SortData, string FirstColumn, string SecColumn, string SecondLevel, string ThirdColumn, string ThirdLevel, string SortBy, string Sortcolor, string colorSortBy, string cmbAlgorithm)
        {
            if (FirstColumn == null)
                return View();

            if (view == "View Input Template")
            {
                ExcelEngine excelEngine = new ExcelEngine();
                IWorkbook book = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath(@"SortingData.xlsx"), ExcelOpenType.Automatic);
                try
                {
                    return excelEngine.SaveAsActionResult(book, "InputTempalte.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.Open);
                }
                catch (Exception)
                {
                }

                book.Close();
                excelEngine.Dispose();
                return View();
            }

            if (SortData == "Sort Values")
            {
                int firstIndex, secIndex, thirdIndex;
                firstIndex = GetSelectedIndex(FirstColumn);
                secIndex = GetSelectedIndex(SecColumn);
                thirdIndex = GetSelectedIndex(ThirdColumn);
                bool secondLevel = (SecondLevel != null);
                bool thirdLevel = (ThirdLevel != null);
                OrderBy orderBy = (SortBy == "Ascending") ? OrderBy.Ascending : OrderBy.Descending;
                return SortValues(firstIndex,secIndex,thirdIndex,secondLevel,thirdLevel,orderBy);
            }
           
            return View();
        }
        #region Helper Methods
        private int GetSelectedIndex(string value)
        {
            switch (value)
            {
                case "ID": return 0;
                case "Name": return 1;
                case "Salary": return 3;
                default: return 0;
            }
        }
        private ActionResult SortColor(SortOn sortOn,int firstIndex,OrderBy orderBy)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            IWorkbook book = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath(@"SortingData.xlsx"), ExcelOpenType.Automatic);
            book.Version = ExcelVersion.Excel2016;
            IWorksheet sheet = book.Worksheets[1];
            IRange range = sheet["A2:C50"];

            IDataSort sorter = book.CreateDataSorter();
            sorter.SortRange = range;

            ISortField field = sorter.SortFields.Add(2, sortOn, orderBy);
            field.Color = Color.Red;
            field = sorter.SortFields.Add(2, sortOn, orderBy);
            field.Color = Color.Blue;
            sorter.Sort();
            book.Worksheets.Remove(0);
           
            try
            {
                return excelEngine.SaveAsActionResult(book, "Output.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.Open);
            }
            catch (Exception)
            {
            }

            book.Close();
            excelEngine.Dispose();
            return View();
        }
        private ActionResult SortValues(int firstIndex,int secIndex,int thirdIndex,bool secondLevel,bool thirdLevel,OrderBy orderBy)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            IWorkbook book = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath(@"SortingData.xlsx"), ExcelOpenType.Automatic);
            IWorksheet sheet = book.Worksheets[0];
            IRange range = sheet["A2:D51"];

            //Create the data sorter.
            IDataSort sorter = book.CreateDataSorter();
            //Specify the range to sort.
            sorter.SortRange = range;


            //Specify the sort field attributes (column index and sort order)
            ISortField field = sorter.SortFields.Add(firstIndex, SortOn.Values, orderBy);
            //sort the data based on the sort field attributes.

            if (secondLevel)
            {
                field = sorter.SortFields.Add(secIndex, SortOn.Values, orderBy);
            }

            if (thirdLevel)
            {
                field = sorter.SortFields.Add(thirdIndex, SortOn.Values, orderBy);
            }
            sorter.Algorithm = SortingAlgorithms.QuickSort;
            sorter.Sort();
            book.Worksheets.Remove(1);
            try
            {
                return excelEngine.SaveAsActionResult(book, "Output.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.Open);
            }
            catch (Exception)
            {
            }

            book.Close();
            excelEngine.Dispose();
            return View();
        }
     
        #endregion       

    }
}
