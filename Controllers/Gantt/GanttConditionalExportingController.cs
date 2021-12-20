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
using Syncfusion.Pdf.Graphics;


namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
       

        public ActionResult GanttConditionalExporting()
        {
            ViewBag.datasource = GetExportDataSource();
            return View();
        }

        GanttProperties.GanttEJExportEventHandler queryCellDelegate = new GanttProperties.GanttEJExportEventHandler(GanttPdfQueryCell);
        GanttProperties.GanttEJExportEventHandler queryTaskbarDelegate = new GanttProperties.GanttEJExportEventHandler(GanttQueryTaskbar);
        GanttProperties.GanttEJExportEventHandler queryExcelCellDelegate = new GanttProperties.GanttEJExportEventHandler(GanttExcelQueryCell);

        public void ConditionalExcel(string GanttModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = GetExportDataSource();
            GanttProperties obj = ConvertToGanttObject(GanttModel);
            obj.ServerExcelQueryCellInfo = queryExcelCellDelegate;
            exp.Export(obj, DataSource, "GanttExport.xlsx", ExcelVersion.Excel2010, new GanttExportSettings() { Theme = ExportTheme.FlatSaffron });
        }

        public void ConditionalPdf(string GanttModel)
        {
            ConditionalPdfExport(GanttModel);
        }
        public void ConditionalPdfExport(string GanttModel)
        {
            PdfExport exp = new PdfExport();
            var DataSource = GetExportDataSource();
            GanttProperties obj = ConvertToGanttObject(GanttModel);
            obj.ServerPdfQueryCellInfo = queryCellDelegate;
            obj.ServerPdfQueryTaskbarInfo = queryTaskbarDelegate;
            GanttPdfExportSettings settings = new GanttPdfExportSettings();
            settings.Theme = GanttExportTheme.FlatSaffron;
            settings.Locale = Request.Form["locale"];
            settings.IsFitToWidth = true;
            exp.Export(obj, DataSource, settings, "Gantt");
        }
        private GanttProperties ConvertToGanttObject(string gridProperty)
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
        public static void GanttQueryTaskbar(object model, object args)
        {
            var record = (GanttRecord)((Dictionary<string, object>)args)["Data"];
            var taskbar = (PdfGanttTaskbar)((Dictionary<string, object>)args)["Taskbar"];
            if (!record.IsParentRow)
            {
                if (record.Progress > 80)
                {
                    taskbar.ProgressColor = new PdfColor(108, 52, 131);
                    taskbar.TaskBorderColor = taskbar.TaskColor = new PdfColor(165, 105, 189);
                }
                else if (record.Progress < 20)
                {
                    taskbar.ProgressColor = new PdfColor(205, 92, 92);
                    taskbar.TaskBorderColor = taskbar.TaskColor = new PdfColor(240, 128, 128);
                }
            }
        }

        public static void GanttPdfQueryCell(object model, object args)
        {
            var record = (GanttRecord)((Dictionary<string, object>)args)["Data"];
            var cell = (PdfTreeGridCell)((Dictionary<string, object>)args)["Cell"];
            var column = (GanttColumn)((Dictionary<string, object>)args)["Column"];
            var ganttModel = (GanttProperties)model;

            if (column.MappingName == ganttModel.ProgressMapping && !record.IsParentRow)
            {
                if (record.Progress > 80)
                {
                    PdfBrush color = new PdfSolidBrush(new PdfColor(165, 105, 189));
                    cell.Style.BackgroundBrush = color;
                }
                else if (record.Progress < 20)
                {
                    PdfBrush color = new PdfSolidBrush(new PdfColor(240, 128, 128));
                    cell.Style.BackgroundBrush = color;
                }

            }
        }

        public static void GanttExcelQueryCell(object model, object args)
        {
            var record = (GanttRecordDetails)((Dictionary<string, object>)args)["Data"];
            var cell = (IRange)((Dictionary<string, object>)args)["Cell"];
            var column = (GanttColumn)((Dictionary<string, object>)args)["Column"];
            var ganttModel = (GanttProperties)model;

            if (column.MappingName == ganttModel.ProgressMapping && !record.IsParentRow)
            {
                if (float.Parse(cell.Value) > 80)
                    cell.CellStyle.Color = ColorConversion.GetColor(new PdfColor(165, 105, 189));
                else if (float.Parse(cell.Value) < 20)
                    cell.CellStyle.Color = ColorConversion.GetColor(new PdfColor(240, 128, 128));
            }

        }

        public List<TaskDetails> GetExportDataSource()
        {
            List<TaskDetails> tasks = new List<TaskDetails>();
            tasks.Add(new TaskDetails()
            {
                TaskID = 1,
                TaskName = "Planning",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "75",
            });

            tasks[0].SubTasks = new List<TaskDetails>();


            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 2,
                TaskName = "Plan timeline",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "95",
            });
            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 3,
                TaskName = "Plan budget",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "95",
            });
            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 4,
                TaskName = "Allocate resources",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "90",
            });
            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 5,
                TaskName = "Planning complete",
                StartDate = "02/10/2017",
                EndDate = "02/10/2017",
                Duration = 1,
                Progress = "15",
            });

            tasks.Add(new TaskDetails()
            {
                TaskID = 6,
                TaskName = "Design",
                StartDate = "02/13/2017",
                EndDate = "02/16/2017",
                Duration = 3,
                Progress = "65",
            });

            tasks[1].SubTasks = new List<TaskDetails>();

            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 7,
                TaskName = "Software Specification",
                StartDate = "02/13/2017",
                EndDate = "02/15/2017",
                Duration = 3,
                Progress = "60",
            });
            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 8,
                TaskName = "Develop prototype",
                StartDate = "02/13/2017",
                EndDate = "02/15/2017",
                Duration = 3,
                Progress = "90",
            });
            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 9,
                TaskName = "Get approval from customer",
                StartDate = "02/16/2017",
                EndDate = "02/17/2017",
                Duration = 2,
                Progress = "85",
            });
            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 10,
                TaskName = "Design Documentation",
                StartDate = "02/16/2017",
                EndDate = "02/17/2017",
                Duration = 2,
                Progress = "85",
            });
            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 11,
                TaskName = "Design complete",
                StartDate = "02/17/2017",
                EndDate = "02/17/2017",
                Duration = 1,
                Progress = "15",
            });


            tasks.Add(new TaskDetails()
            {
                TaskID = 12,
                TaskName = "Implementation Phase",
                StartDate = "02/20/2017",
                EndDate = "03/02/2017",
                Duration = 11,
                Progress = "27",
            });

            tasks[2].SubTasks = new List<TaskDetails>();

            tasks[2].SubTasks.Add(new TaskDetails()
            {
                TaskID = 13,
                TaskName = "Phase 1",
                StartDate = "02/20/2017",
                EndDate = "03/02/2017",
                Duration = 11,
                Progress = "26",
            });

            tasks[2].SubTasks[0].SubTasks = new List<TaskDetails>();

            tasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 14,
                TaskName = "Implementation Module 1",
                StartDate = "02/20/2017",
                EndDate = "03/02/2017",
                Duration = 11,
                Progress = "26",
            });

            tasks[2].SubTasks[0].SubTasks[0].SubTasks = new List<TaskDetails>();


            tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 15,
                TaskName = "Development Task 1",
                StartDate = "02/20/2017",
                EndDate = "02/22/2017",
                Duration = 3,
                Progress = "50",
            });
            tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 16,
                TaskName = "Development Task 2",
                StartDate = "02/20/2017",
                EndDate = "02/22/2017",
                Duration = 3,
                Progress = "50",
            });
            tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 17,
                TaskName = "Testing",
                StartDate = "02/20/2017",
                EndDate = "02/21/2017",
                Duration = 2,
                Progress = "15",
            });
            tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 18,
                TaskName = "Bug fix",
                StartDate = "02/24/2017",
                EndDate = "02/25/2017",
                Duration = 2,
                Progress = "15",
            });
            tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 19,
                TaskName = "Customer review meeting",
                StartDate = "02/26/2017",
                EndDate = "03/02/2017",
                Progress = "15",
                Duration = 2
            });
            tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 20,
                TaskName = "Phase 1 complete",
                StartDate = "03/02/2017",
                EndDate = "03/03/2017",
                Progress = "15",
                Duration = 1
            });

            tasks[2].SubTasks.Add(new TaskDetails()
            {
                TaskID = 21,
                TaskName = "Phase 2",
                StartDate = "02/20/2017",
                EndDate = "02/28/2017",
                Progress = "29",
                Duration = 12
            });

            tasks[2].SubTasks[1].SubTasks = new List<TaskDetails>();

            tasks[2].SubTasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 22,
                TaskName = "Implementation Module 2",
                StartDate = "02/20/2017",
                EndDate = "03/03/2017",
                Duration = 12,
                Progress = "29",
            });

            tasks[2].SubTasks[1].SubTasks[0].SubTasks = new List<TaskDetails>();

            tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 23,
                TaskName = "Development Task 1",
                StartDate = "02/20/2017",
                EndDate = "02/20/2017",
                Progress = "50",
                Duration = 4
            });
            tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 24,
                TaskName = "Development Task 2",
                StartDate = "02/20/2017",
                EndDate = "02/20/2017",
                Progress = "50",
                Duration = 4
            });
            tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 25,
                TaskName = "Testing",
                StartDate = "02/21/2017",
                EndDate = "02/24/2017",
                Progress = "15",
                Duration = 2
            });
            tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 26,
                TaskName = "Bug fix",
                StartDate = "02/25/2017",
                EndDate = "02/26/2017",
                Progress = "15",
                Duration = 2
            });
            tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 27,
                TaskName = "Customer review meeting",
                StartDate = "03/02/2017",
                Progress = "15",
                EndDate = "02/28/2017",
                Duration = 2
            });
            tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 28,
                TaskName = "Phase 2 complete",
                StartDate = "02/28/2017",
                Progress = "15",
                EndDate = "02/28/2017",
                Duration = 1
            });

            tasks[2].SubTasks.Add(new TaskDetails()
            {
                TaskID = 29,
                TaskName = "Phase 3",
                StartDate = "02/20/2017",
                EndDate = "03/02/2017",
                Progress = "26",
                Duration = 11
            });
            tasks[2].SubTasks[2].SubTasks = new List<TaskDetails>();

            tasks[2].SubTasks[2].SubTasks.Add(new TaskDetails()
            {
                TaskID = 30,
                TaskName = "Implementation Module 3",
                StartDate = "02/20/2017",
                EndDate = "03/02/2017",
                Progress = "26",
                Duration = 11
            });

            tasks[2].SubTasks[2].SubTasks[0].SubTasks = new List<TaskDetails>();

            tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 31,
                TaskName = "Development Task 1",
                StartDate = "02/20/2017",
                EndDate = "02/22/2017",
                Progress = "50",
                Duration = 3
            });
            tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 32,
                TaskName = "Development Task 2",
                StartDate = "02/20/2017",
                EndDate = "02/22/2017",
                Progress = "50",
                Duration = 3
            });
            tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 33,
                TaskName = "Testing",
                StartDate = "02/23/2017",
                EndDate = "02/24/2017",
                Progress = "15",
                Duration = 2
            });
            tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 34,
                TaskName = "Bug fix",
                StartDate = "02/27/2017",
                EndDate = "02/28/2017",
                Progress = "15",
                Duration = 2
            });
            tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 35,
                TaskName = "Customer review meeting",
                StartDate = "03/01/2017",
                EndDate = "03/02/2017",
                Progress = "15",
                Duration = 2
            });
            tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 36,
                TaskName = "Phase 3 complete",
                StartDate = "03/02/2017",
                Progress = "15",
                EndDate = "03/02/2017",
                Duration = 1,
            });
            return tasks;
        }
    }
}
