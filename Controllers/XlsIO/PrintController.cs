#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.ExcelChartToImageConverter;
using System.Drawing.Printing;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /ExcelToPDF/

        public ActionResult Print(string button, string Group1, string Group2)
        {
            if (button == null)
                return View();
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"ExcelTopdfwithChart.xlsx"), ExcelOpenType.Automatic);
                return excelEngine.SaveAsActionResult(workbook, "InputTempalte.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2013);
            }
            else
            {
                ExcelToPdfConverter converter = new ExcelToPdfConverter(ResolveApplicationDataPath("ExcelTopdfwithChart.xlsx"));
                converter.ChartToImageConverter = new ChartToImageConverter();
                //Set the image quality
                converter.ChartToImageConverter.ScalingMode = ScalingMode.Best;
                //Intialize the PdfDocument Class
                PdfDocument pdfDoc = new PdfDocument();

                //Intialize the ExcelToPdfConverterSettings class
                ExcelToPdfConverterSettings converterSettings = new ExcelToPdfConverterSettings();

                //Set the Layout Options for the output Pdf page.
                if (Group2 == "NoScaling")
                    converterSettings.LayoutOptions = LayoutOptions.NoScaling;
                else if (Group2 == "FitAllRowsOnOnePage")
                    converterSettings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
                else if (Group2 == "FitAllColumnsOnOnePage")
                    converterSettings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
                else
                    converterSettings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

                //Assign the output PdfDocument to the TemplateDocument property of ExcelToPdfConverterSettings 
                converterSettings.TemplateDocument = pdfDoc;
                converterSettings.DisplayGridLines = GridLinesDisplayStyle.Invisible;

                //Create new printerSettings instance.
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.FromPage = 1;
                printerSettings.ToPage = 3;
                printerSettings.Collate = true;
                printerSettings.Copies = 2;
                printerSettings.Duplex = Duplex.Simplex;

                if (Group1 == "DefaultPrint")
                    converter.Print();
                else if (Group1 == "PrintWithConverterSettings")
                    converter.Print(converterSettings);
                else if (Group1 == "PrintWithPrinterSettings")
                    converter.Print(printerSettings);
                else
                    converter.Print(printerSettings, converterSettings);

                return View();
            }
        }

    }
}
