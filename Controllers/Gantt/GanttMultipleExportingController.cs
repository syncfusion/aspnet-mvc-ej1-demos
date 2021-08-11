#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript.Models;
using Syncfusion.Pdf;
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
using Syncfusion.Pdf.Graphics;
using System.Drawing;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttMultipleExporting/

        public ActionResult GanttMultipleExporting()
        {
            ViewBag.dataSource1 = this.GetPlanDataSource();
            ViewBag.dataSource2 = this.GetDesignDataSource();
            ViewBag.dataSource3 = this.GetImplementationDataSource();
            return View();
        }

        public void MultipleExportToExcel(string[] GanttModel)
        {
            ExcelExport exp = new ExcelExport();
            var PlanData = this.GetPlanDataSource();
            var DesignData = this.GetDesignDataSource();
            var ImplementationData = this.GetImplementationDataSource();
            IWorkbook document = null;
            int count = 1;
            foreach (string gridProperty in GanttModel)
            {
                GanttProperties gridProp = this.ConvertGanttObject(gridProperty);
                if (count == 1)
                {
                    document = exp.Export(gridProp, PlanData, new GanttExportSettings() { Theme = ExportTheme.FlatSaffron }, true, "Planning Phase");
                }
                else if(count == 2)
                {
                    exp.Export(gridProp, DesignData, new GanttExportSettings() { Theme = ExportTheme.FlatSaffron }, "Export", document, true, "Design Phase");
                }
                else
                {
                    exp.Export(gridProp, ImplementationData, new GanttExportSettings() { Theme = ExportTheme.FlatSaffron }, "Export.xlsx", document, false, "Implementation Phase");
                }
                count++;
            }
        }
        public void MultipleExportToPdf(string[] GanttModel)
        {
            PdfExport exp = new PdfExport();
            var PlanData = this.GetPlanDataSource();
            var DesignData = this.GetDesignDataSource();
            var ImplementationData = this.GetImplementationDataSource();
            PdfDocument document = null;
            GanttPdfExportSettings settings = new GanttPdfExportSettings();
            settings.Theme = GanttExportTheme.FlatSaffron;
            settings.Locale = Request.Form["locale"];
            //Create footer template
            RectangleF bounds = new RectangleF(0, 0, 762, 25);
            PdfSolidBrush brush = new PdfSolidBrush(new PdfColor(51, 51, 51));
            PdfPen pen = new PdfPen(new PdfColor(200, 200, 200));
            PdfFont font = new PdfTrueTypeFont(new Font("Segoe UI", 10), true);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            PdfPageTemplateElement footer = new PdfPageTemplateElement(bounds);
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);
            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0}", pageNumber);
            compositeField.StringFormat = format;
            compositeField.Bounds = footer.Bounds;
            footer.Graphics.DrawRectangle(pen, bounds);
            compositeField.Draw(footer.Graphics, new PointF(0, 0));
            PdfDocumentTemplate footerTemplate = new PdfDocumentTemplate();
            footerTemplate.Bottom = footer;
            settings.PdfDocumentTemplate = footerTemplate;
            int count = 1;
            foreach (string gridProperty in GanttModel)
            {
                GanttProperties gridProp = this.ConvertGanttObject(gridProperty);
                if (count == 1)
                {
                    document = exp.Export(gridProp, (IEnumerable)PlanData, settings, false);
                }
                else if (count == 2)
                {
                    document = exp.Export(gridProp, (IEnumerable)DesignData, settings, document, false);
                }
                else
                {
                    exp.Export(gridProp, (IEnumerable)ImplementationData, settings, "Gantt", document, true);
                }
                count++;
            }
        }
        private List<BusinessObject> GetPlanDataSource()
        {
            List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();

            BusinessObject Record1 = null;

            Record1 = new BusinessObject()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Progress = 100,
                Duration = 5,
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child1 = new BusinessObject()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = 100
            };

            BusinessObject Child2 = new BusinessObject()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = 100
            };

            BusinessObject Child3 = new BusinessObject()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = 100
            };

            BusinessObject Child4 = new BusinessObject()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                StartDate = "02/10/2017",
                EndDate = "02/10/2017",
                Duration = 0,
                Progress = 0
            };

            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            Record1.Children.Add(Child4);
            BusinessObjectCollection.Add(Record1);
            return BusinessObjectCollection;
        }

        private List<BusinessObject> GetDesignDataSource()
        {
            List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
            BusinessObject Record1 = new BusinessObject()
            {
                TaskId = 1,
                TaskName = "Design",
                StartDate = "02/10/2017",
                EndDate = "02/14/2017",
                Progress = 86,
                Duration = 3,
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child1 = new BusinessObject()
            {
                TaskId = 2,
                TaskName = "Software Specification",
                StartDate = "02/10/2017",
                EndDate = "02/12/2017",
                Duration = 3,
                Progress = 60
            };

            BusinessObject Child2 = new BusinessObject()
            {
                TaskId = 3,
                TaskName = "Develop prototype",
                StartDate = "02/10/2017",
                EndDate = "02/12/2017",
                Duration = 3,
                Progress = 100
            };

            BusinessObject Child3 = new BusinessObject()
            {
                TaskId = 4,
                TaskName = "Get approval from customer",
                StartDate = "02/13/2017",
                EndDate = "02/14/2017",
                Duration = 2,
                Progress = 100
            };

            BusinessObject Child4 = new BusinessObject()
            {
                TaskId = 5,
                TaskName = "Design complete",
                StartDate = "02/14/2017",
                EndDate = "02/14/2017",
                Duration = 0,
                Progress = 0
            };

            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            Record1.Children.Add(Child4);
            BusinessObjectCollection.Add(Record1);
            return BusinessObjectCollection;
        }

        private List<BusinessObject> GetImplementationDataSource()
        {
            List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
            BusinessObject Record1 = new BusinessObject()
            {
                TaskId = 1,
                TaskName = "Implementation Phase",
                StartDate = "02/17/2017",
                EndDate = "02/17/2017",
                Children = new List<BusinessObject>(),
            };

            BusinessObject Record2 = new BusinessObject()
            {
                TaskId = 2,
                TaskName = "Phase 1",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record5 = new BusinessObject()
            {
                TaskId = 3,
                TaskName = "Implementation Module 1",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child1 = new BusinessObject()
            {
                TaskId = 4,
                TaskName = "Development Task 1",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50
            };
            BusinessObject Child2 = new BusinessObject()
            {
                TaskId = 5,
                TaskName = "Development Task 2",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50
            };
            BusinessObject Child3 = new BusinessObject()
            {
                TaskId = 6,
                TaskName = "Testing",
                StartDate = "02/20/2017",
                EndDate = "02/21/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child4 = new BusinessObject()
            {
                TaskId = 7,
                TaskName = "Bug fix",
                StartDate = "02/24/2017",
                EndDate = "02/25/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child5 = new BusinessObject()
            {
                TaskId = 8,
                TaskName = "Customer review meeting",
                StartDate = "02/26/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child6 = new BusinessObject()
            {
                TaskId = 9,
                TaskName = "Phase 1 complete",
                StartDate = "02/27/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Progress = 0
            };
            Record5.Children.Add(Child1);
            Record5.Children.Add(Child2);
            Record5.Children.Add(Child3);
            Record5.Children.Add(Child4);
            Record5.Children.Add(Child5);
            Record5.Children.Add(Child6);
            Record2.Children.Add(Record5);
            Record1.Children.Add(Record2);
            BusinessObject Record3 = new BusinessObject()
            {
                TaskId = 10,
                TaskName = "Phase 2",
                StartDate = "02/17/2017",
                EndDate = "02/28/2017",
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record6 = new BusinessObject()
            {
                TaskId = 11,
                TaskName = "Implementation Module 2",
                StartDate = "02/17/2017",
                EndDate = "02/28/2017",
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child7 = new BusinessObject()
            {
                TaskId = 12,
                TaskName = "Development Task 1",
                StartDate = "02/17/2017",
                EndDate = "02/20/2017",
                Duration = 4,
                Progress = 50
            };
            BusinessObject Child8 = new BusinessObject()
            {
                TaskId = 13,
                TaskName = "Development Task 2",
                StartDate = "02/17/2017",
                EndDate = "02/20/2017",
                Duration = 4,
                Progress = 50
            };
            BusinessObject Child9 = new BusinessObject()
            {
                TaskId = 14,
                TaskName = "Testing",
                StartDate = "02/21/2017",
                EndDate = "02/24/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child10 = new BusinessObject()
            {
                TaskId = 15,
                TaskName = "Bug fix",
                StartDate = "02/25/2017",
                EndDate = "02/26/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child11 = new BusinessObject()
            {
                TaskId = 16,
                TaskName = "Customer review meeting",
                StartDate = "02/27/2017",
                EndDate = "02/28/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child12 = new BusinessObject()
            {
                TaskId = 17,
                TaskName = "Phase 1 complete",
                StartDate = "02/28/2017",
                EndDate = "02/28/2017",
                Duration = 2,
            };
            Record6.Children.Add(Child7);
            Record6.Children.Add(Child8);
            Record6.Children.Add(Child9);
            Record6.Children.Add(Child10);
            Record6.Children.Add(Child11);
            Record6.Children.Add(Child12);
            Record3.Children.Add(Record6);
            Record1.Children.Add(Record3);
            BusinessObject Record4 = new BusinessObject()
            {
                TaskId = 18,
                TaskName = "Phase 3",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record7 = new BusinessObject()
            {
                TaskId = 19,
                TaskName = "Implementation Module 3",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child13 = new BusinessObject()
            {
                TaskId = 20,
                TaskName = "Development Task 1",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50
            };
            BusinessObject Child14 = new BusinessObject()
            {
                TaskId = 21,
                TaskName = "Development Task 2",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50
            };
            BusinessObject Child15 = new BusinessObject()
            {
                TaskId = 22,
                TaskName = "Testing",
                StartDate = "02/20/2017",
                EndDate = "02/21/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child16 = new BusinessObject()
            {
                TaskId = 23,
                TaskName = "Bug fix",
                StartDate = "02/24/2017",
                EndDate = "02/25/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child17 = new BusinessObject()
            {
                TaskId = 24,
                TaskName = "Customer review meeting",
                StartDate = "02/26/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Progress = 0
            };
            BusinessObject Child18 = new BusinessObject()
            {
                TaskId = 25,
                TaskName = "Phase 1 complete",
                StartDate = "02/27/2017",
                EndDate = "02/27/2017",
                Duration = 2,
            };
            Record7.Children.Add(Child13);
            Record7.Children.Add(Child14);
            Record7.Children.Add(Child15);
            Record7.Children.Add(Child16);
            Record7.Children.Add(Child17);
            Record7.Children.Add(Child18);
            Record4.Children.Add(Record7);
            Record1.Children.Add(Record4);
            BusinessObjectCollection.Add(Record1);

            return BusinessObjectCollection;
        }
        private GanttProperties ConvertGridObject(string gridProperty)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            IEnumerable div = (IEnumerable)serializer.Deserialize(gridProperty, typeof(IEnumerable));
            GanttProperties gridProp = new GanttProperties();
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
