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
using System.Drawing;

namespace MVCSampleBrowser.Controllers
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /Bar/

        public ActionResult EmbeddedChart(string button, string SaveOption)
        {
            if (button == null)
                return View();

            //Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
            //Open workbook with Data
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("EmbeddedChart.xlsx"));

             if (SaveOption == "Xls")
                workbook.Version = ExcelVersion.Excel97to2003;           
            else
                workbook.Version = ExcelVersion.Excel2016;

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];
            sheet.Name = "Sample";

            // Adding a New chart to the Existing Worksheet   
            IChartShape chart = workbook.Worksheets[0].Charts.Add();


            chart.DataRange = sheet.Range["A3:C15"];
            chart.ChartTitle = "Crescent City, CA";
            chart.IsSeriesInRows = false;

            chart.PrimaryValueAxis.Title = "Precipitation,in.";
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90;
            chart.PrimaryValueAxis.MaximumValue = 14.0;
            chart.PrimaryValueAxis.NumberFormat = "0.0";

            chart.PrimaryCategoryAxis.Title = "Month";

            IChartSerie serieOne = chart.Series[0];

            //set the Chart Type
            chart.ChartType = ExcelChartType.Column_Clustered_3D;

            //set the Backwall fill option
            chart.BackWall.Fill.FillType = ExcelFillType.Gradient;

            //set the Texture Type
            chart.BackWall.Fill.GradientColorType = ExcelGradientColor.TwoColor;
            chart.BackWall.Fill.GradientStyle = ExcelGradientStyle.Diagonl_Down;
            chart.BackWall.Fill.ForeColor = Color.WhiteSmoke;
            chart.BackWall.Fill.BackColor = Color.LightBlue;

            //set the Border Linecolor 
            chart.BackWall.Border.LineColor = Color.Wheat;

            //set the Picture Type     
            chart.BackWall.PictureUnit = ExcelChartPictureType.stretch;

            //set the Backwall thickness
            chart.BackWall.Thickness = 10;

            //set the sidewall fill option
            chart.SideWall.Fill.FillType = ExcelFillType.SolidColor;

            //set the sidewall foreground and backcolor
            chart.SideWall.Fill.BackColor = Color.White;
            chart.SideWall.Fill.ForeColor = Color.White;

            //set the side wall Border color
            chart.SideWall.Border.LineColor = Color.Beige;

            //set floor fill option
            chart.Floor.Fill.FillType = ExcelFillType.Pattern;

            //set the floor pattern Type
            chart.Floor.Fill.Pattern = ExcelGradientPattern.Pat_Divot;

            //Set the floor fore and Back ground color
            chart.Floor.Fill.ForeColor = Color.Blue;
            chart.Floor.Fill.BackColor = Color.White;

            //set the floor thickness
            chart.Floor.Thickness = 3;

            IChartSerie serieTwo = chart.Series[1];
            //Show value as data labels
            serieOne.DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            serieTwo.DataPoints.DefaultDataPoint.DataLabels.IsValue = true;

            //Embedded Chart Position
            chart.TopRow = 2;
            chart.BottomRow = 30;
            chart.LeftColumn = 5;
            chart.RightColumn = 18;
            serieTwo.Name = "Temperature,deg.F";

            // Legend setting
            chart.Legend.Position = ExcelLegendPosition.Right;
            chart.Legend.IsVerticalLegend = false;
            try
            {
                //Saving the workbook to disk.
                if (SaveOption == "Xls")
                    return excelEngine.SaveAsActionResult(workbook, "EmbeddedChart.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                else
                    return excelEngine.SaveAsActionResult(workbook, "EmbeddedChart.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            catch (Exception)
            {
            }

            workbook.Close();
            excelEngine.Dispose();
            return View();
        }

    }
}
