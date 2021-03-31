#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /ExportingGrid/

        public ActionResult HierarchyGridExport()
        {
            ViewBag.parentData = new NorthwindDataContext().EmployeeViews.ToList();
            ViewBag.childData = new NorthwindDataContext().OrdersViews.Take(100).ToList();
            return View();
        }
        private GridProperties ConvertGridModelObject(string gridProperty)
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
                    object value = null;
                    string serialize = serializer.Serialize(ds.Value);
                    if (ds.Key == "childGrid")
                        value = ConvertGridModelObject(serialize);
                    else
                        value = serializer.Deserialize(serialize, type);
                    property.SetValue(gridProp, value, null);
                }
            }
            return gridProp;
        }
        public void ExportHierarchyToExcel(string GridModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = new NorthwindDataContext().EmployeeViews.ToList();
            GridProperties obj = ConvertGridObject(GridModel);
            obj.ChildGrid.DataSource = new NorthwindDataContext().OrdersViews.Take(100).ToList();
            GridExcelExport expo = new GridExcelExport();
            expo.IncludeChildGrid = true;
            exp.Export(obj, DataSource, expo);
        }
        public void ExportHierarchyToWord(string GridModel)
        {
            WordExport exp = new WordExport();
            var DataSource = new NorthwindDataContext().EmployeeViews.ToList();
            GridProperties obj = ConvertGridObject(GridModel);
            obj.ChildGrid.DataSource = new NorthwindDataContext().OrdersViews.Take(100).ToList();
            GridWordExport expo = new GridWordExport();
            expo.IncludeChildGrid = true;
            exp.Export(obj, DataSource, expo);
        }
        public void ExportHierarchyToPdf(string GridModel)
        {
            PdfExport exp = new PdfExport();
            var DataSource = new NorthwindDataContext().EmployeeViews.ToList();
            GridProperties obj = ConvertGridObject(GridModel);
            obj.ChildGrid.DataSource = new NorthwindDataContext().OrdersViews.Take(100).ToList();
            GridPdfExport expo = new GridPdfExport();
            expo.IncludeChildGrid = true;
            expo.Unicode = true;
            exp.Export(obj, DataSource, expo);
        }
    }
}
