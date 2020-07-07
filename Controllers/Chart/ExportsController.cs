#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.JavaScript.DataVisualization.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Drawing.Imaging;
using System.IO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.Drawing;
using System.Xml;

namespace MVCSampleBrowser.Controllers
{
    public partial class ChartController : Controller
    {
        //
        // GET: /Exports/

        public ActionResult Exports()
        {
            return View();
        }

        public void ExportChart(string Data, string ChartModel)
        {
            // declaration
            ChartProperties obj = ConvertChartObject(ChartModel);
            string type = obj.ExportSettings.Type.ToString().ToLower();
            string fileName = obj.ExportSettings.FileName;
            string orientation = obj.ExportSettings.Orientation.ToString();

            if (type == "svg")      // for svg export
            {
                StringWriter oStringWriter = new StringWriter();
                string data = HttpUtility.HtmlDecode(Data);
                data = HttpUtility.UrlDecode(Data);
                data = System.Uri.UnescapeDataString(Data);
                oStringWriter.WriteLine(System.Uri.UnescapeDataString(Data));
                Response.ContentType = "text/plain";
                Response.AddHeader("Content-Disposition", String.Format("attachment;filename={0}", (obj.ExportSettings.FileName + ".svg")));
                Response.Clear();
                using (StreamWriter writer = new StreamWriter(Response.OutputStream))
                {
                    data = oStringWriter.ToString();
                    writer.Write(oStringWriter.ToString());
                }
                Response.End();
            }

            else if (type == "xlsx")       // to export chart as excel
            {
                List<ExportChartData> chartData = new List<ExportChartData>();
                chartData.Add(new ExportChartData("John", 10));
                chartData.Add(new ExportChartData("Jake", 12));
                chartData.Add(new ExportChartData("Peter", 18));
                chartData.Add(new ExportChartData("James", 11));
                chartData.Add(new ExportChartData("Mary", 9.7));

                ExcelExport exp = new ExcelExport();
                exp.Export(obj, (IEnumerable)chartData, fileName + ".xlsx", ExcelVersion.Excel2010, null, null);
            }

            else
            {
                Data = Data.Remove(0, Data.IndexOf(',') + 1);
                MemoryStream stream = new MemoryStream(Convert.FromBase64String(Data));

                if (type == "docx")        // to export as word document
                {
                    WordDocument document = new WordDocument();
                    IWSection section = document.AddSection();
                    IWParagraph paragraph = section.AddParagraph();

                    //Set orientation based on chart width
                    Image img = Image.FromStream(stream);
                    if (obj.ExportSettings.Orientation.ToString() == "Landscape" || section.PageSetup.ClientWidth < img.Width)
                        section.PageSetup.Orientation = PageOrientation.Landscape;
                    else
                        section.PageSetup.Orientation = PageOrientation.Portrait;
                    img.Dispose();

                    paragraph.AppendPicture(Image.FromStream(stream));
                    document.Save(fileName + ".doc", Syncfusion.DocIO.FormatType.Doc, HttpContext.ApplicationInstance.Response, Syncfusion.DocIO.HttpContentDisposition.Attachment);
                }
                else if (type == "pdf")      // to export as PDF
                {
                    PdfDocument pdfDoc = new PdfDocument();
                    pdfDoc.Pages.Add();

                    //Set chart width as pdf page width
                    Image img = Image.FromStream(stream);
                    pdfDoc.Pages[0].Section.PageSettings.Width = img.Width;
                    img.Dispose();

                    if (obj.ExportSettings.Orientation.ToString() == "Landscape")
                        pdfDoc.Pages[0].Section.PageSettings.Orientation = PdfPageOrientation.Landscape;
                    else
                        pdfDoc.Pages[0].Section.PageSettings.Orientation = PdfPageOrientation.Portrait;
                    pdfDoc.Pages[0].Graphics.DrawImage(PdfImage.FromStream(stream), new PointF(10, 30));
                    pdfDoc.Save(obj.ExportSettings.FileName + ".pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                    pdfDoc.Close();
                }
                else                        // to export as image
                {
                    stream.WriteTo(Response.OutputStream);
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", String.Format("attachment;filename={0}", fileName + "." + type));
                    Response.Flush();
                    stream.Close();
                    stream.Dispose();
                }
            }
        }
      
        private ChartProperties ConvertChartObject(string ChartModel)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            IEnumerable div = (IEnumerable)serializer.Deserialize(ChartModel, typeof(IEnumerable));
            ChartProperties chartProp = new ChartProperties();
            foreach (KeyValuePair<string, object> ds in div)
            {
                var property = chartProp.GetType().GetProperty(ds.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
                if (property != null)
                {
                    Type type = property.PropertyType;
                    string serialize = serializer.Serialize(ds.Value);
                    object value = serializer.Deserialize(serialize, type);
                   property.SetValue(chartProp, value, null);
                }
            }
            return chartProp;
        }

    }
    public class ExportChartData
    {
        public ExportChartData(string xval, double yvalue1)
        {
            this.Xvalue = xval;
            this.YValue1 = yvalue1;
        }
        public string Xvalue
        {
            get;
            set;
        }
        public double YValue1
        {
            get;
            set;
        }
    }
}
