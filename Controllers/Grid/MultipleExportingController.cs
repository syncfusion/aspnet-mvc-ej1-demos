#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.DocIO.DLS;
using Syncfusion.JavaScript.Models;
using Syncfusion.Pdf;
using Syncfusion.XlsIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Syncfusion.EJ.Export;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /MultipleExporting/

        public ActionResult MultipleExporting()
        {
            var MasterData = new NorthwindDataContext().EmployeeViews.Take(5).ToList();
            ViewBag.dataSource1 = MasterData;
            var DetailData = new NorthwindDataContext().OrdersViews.Take(5).ToList();
            ViewBag.dataSource2 = DetailData;
            return View();
        }
        public void MultipleExportToExcel(string[] GridModel)
        {
            ExcelExport exp = new ExcelExport();
            var EmployeeData = new NorthwindDataContext().EmployeeViews.Take(5).ToList();
            var OrderData = new NorthwindDataContext().OrdersViews.Take(5).ToList();
            bool initial = true;
            IWorkbook book = null;
            foreach (string gridProperty in GridModel)
            {
                GridProperties gridProp = ConvertObject(gridProperty);
                if(initial)
                {
                    gridProp.Locale = "";
                    book = exp.Export(gridProp, EmployeeData, "Export.xlsx", ExcelVersion.Excel2010, true, true, "flat-saffron", true);
                    initial = false;
                }
                else
                {
                    exp.Export(gridProp, OrderData, "Export.xlsx", ExcelVersion.Excel2010, true, true, "flat-saffron",false, book, MultipleExportType.AppendToSheet, "Second Grid");
                }
            }
        }
        public void MultipleExportToWord(string[] GridModel)
        {
            WordExport exp = new WordExport();
            var EmployeeData = new NorthwindDataContext().EmployeeViews.Take(5).ToList();
            var OrderData = new NorthwindDataContext().OrdersViews.Take(5).ToList();
            IWordDocument document = null;
            bool initial = true; ;
            foreach (string gridProperty in GridModel)
            {
                GridProperties gridProp = ConvertObject(gridProperty);
                if (initial)
                {
                    gridProp.Locale = "";
                    document = exp.Export(gridProp, EmployeeData, "Export.docx", true, true, "flat-saffron", true);
                    initial = false;
                }
                else
                {
                    exp.Export(gridProp, OrderData, "Export.docx", true, true, "flat-saffron", false, document, "Second Grid");
                }
            }
        }
        public void MultipleExportToPdf(string[] GridModel)
        {
            PdfExport exp = new PdfExport();
            var EmployeeData = new NorthwindDataContext().EmployeeViews.Take(5).ToList();
            var OrderData = new NorthwindDataContext().OrdersViews.Take(5).ToList();
            PdfDocument document = null;
            bool initial = true;
            foreach (string gridProperty in GridModel)
            {
                GridProperties gridProp = ConvertObject(gridProperty);
                if (initial)
                {
                    gridProp.Locale = "";
                    document = exp.Export(gridProp, EmployeeData, "Export.pdf", true, true, "flat-saffron", true);
                    initial = false;
                }
                else
                {
                    exp.Export(gridProp, OrderData, "Export.pdf", true, true, "flat-saffron", false, document, "Second Grid");
                }
            }
        }

        private GridProperties ConvertObject(string gridProperty)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            IEnumerable div = (IEnumerable)serializer.Deserialize(gridProperty, typeof(IEnumerable));
            GridProperties gridProp = new GridProperties();
            foreach (KeyValuePair<string, object> ds in div)
            {
                var property = gridProp.GetType().GetProperty(ds.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
                if (property != null)
                {
                    Type type = property.PropertyType;
                    string serialize = serializer.Serialize(ds.Value);
                    object value = serializer.Deserialize(serialize, type);
                    property.SetValue(gridProp, value, null);
                }
            }
            return gridProp;
        }
    }
}
