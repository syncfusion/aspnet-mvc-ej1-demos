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
using System.ComponentModel;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {

        public  ActionResult CollectionObjects(string Saveoption, string button)
        {
            ViewBag.exportButtonState = "disabled=\"disabled\"";
            //Check FileName
            string fileName = "ExportData.xlsx";
            
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
                Dictionary<string, string> mappingProperties = new Dictionary<string, string>();
                mappingProperties.Add("Brand", "BrandName");
                mappingProperties.Add("Vehicle Type", "VehicleType.VehicleName");
                mappingProperties.Add("Model", "VehicleType.Model.ModelName");

                List<Brand> CLRObjects = sheet.ExportData<Brand>(4, 1, 141, 3, mappingProperties);
                int temp = 1;
                foreach (Brand brand in CLRObjects)
                {
                    brand.ID = temp;
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
                sheet.ImportData((IList<Brand>)value, 4, 1, true);
                //sheet.Range["E4"].Text = "";

                #region Define Styles
                IStyle pageHeader = workbook.Styles.Add("PageHeaderStyle");
                IStyle tableHeader = workbook.Styles.Add("TableHeaderStyle");

                pageHeader.Font.FontName = "Calibri";
                pageHeader.Font.Size = 16;
                pageHeader.Font.Bold = true;
                pageHeader.Color = Color.FromArgb(0, 146, 208, 80);
                pageHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                pageHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;

                tableHeader.Font.Bold = true;
                tableHeader.Font.FontName = "Calibri";
                tableHeader.Color = Color.FromArgb(0, 146, 208, 80);

                #endregion

                #region Apply Styles
                // Apply style for header
                sheet["A1:C2"].Merge();
                sheet["A1"].Text = "Automobile Brands in the US";
                sheet["A1"].CellStyle = pageHeader;

                sheet["A4:C4"].CellStyle = tableHeader;

                sheet["A1:C1"].CellStyle.Font.Bold = true;
                sheet.UsedRange.AutofitColumns();

                #endregion

                try
                {
                    //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
                    //an existing spreadsheet and then saving the result to a new workbook.

                    if (Saveoption == "Xlsx")
                        return excelEngine.SaveAsActionResult(workbook, "CollectionObjects.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    else
                        return excelEngine.SaveAsActionResult(workbook, "CollectionObjects.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
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
        public ActionResult Update(Brand value)
        {
            object salesList = SessionExport.GetDataFromSession<object>(Session, "Export");
            foreach(Brand brand in (salesList as IList<Brand>))
            {
                if(brand.ID == (value as Brand).ID)
                {
                    brand.BrandName = (value as Brand).BrandName;
                    brand.VehicleType.VehicleName = (value as Brand).VehicleType.VehicleName;
                    brand.VehicleType.Model.ModelName = (value as Brand).VehicleType.Model.ModelName;
                }
            }
            SessionExport.SetDataToSession<Brand>(Session, "Export", salesList);
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
                m_salesPerson = value;
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

    [Serializable]
    public class Brand
    {
        private int m_Id;
        [Bindable(false)]
        public int ID
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        private string m_brandName;
        [DisplayNameAttribute("Brand")]
        public string BrandName
        {
            get { return m_brandName; }
            set { m_brandName = value; }
        }

        private VehicleType m_vehicleType;
        public VehicleType VehicleType
        {
            get { return m_vehicleType; }
            set { m_vehicleType = value; }
        }

        public Brand(string brandName)
        {
            m_brandName = brandName;
        }
        public Brand()
        {

        }
    }

    public class VehicleType
    {
        private string m_vehicleName;
        [DisplayNameAttribute("Vehicle Type")]
        public string VehicleName
        {
            get { return m_vehicleName; }
            set { m_vehicleName = value; }
        }

        private Model m_model;
        public Model Model
        {
            get { return m_model; }
            set { m_model = value; }
        }

        public VehicleType(string vehicle)
        {
            m_vehicleName = vehicle;
        }
        public VehicleType()
        {

        }
    }

    public class Model
    {
        private string m_modelName;
        [DisplayNameAttribute("Model")]
        public string ModelName
        {
            get { return m_modelName; }
            set { m_modelName = value; }
        }

        public Model(string name)
        {
            m_modelName = name;
        }
        public Model()
        {

        }
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
