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

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttWorkingTimeRange/
        public ActionResult GanttWorkingTimeRange()
        {
            ViewBag.DataSource = GetDataSource();
            return View();
        }
        public static List<GanttWorkingTimeRangeData> GetDataSource()
        {
            List<GanttWorkingTimeRangeData> list = new List<GanttWorkingTimeRangeData>();
            list.Add(new GanttWorkingTimeRangeData()
            {
                TaskID = 1,
                TaskName = "Parent Task 1",
                StartDate = "02/20/2017 12:00 AM",
                Duration = "1",
                Progress = 40,
                Children = (new List<GanttWorkingTimeRangeData>()
                    {
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 2,
                            TaskName = "Child Task 1",
                            StartDate = "02/20/2017 12:00 AM",
                            Duration = "1",
                            Progress = 40
                        },
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 3,
                            TaskName = "Child Task 2",
                            StartDate = "02/20/2017 12:00 AM",
                            Duration = "1",
                            Progress = 40,
                        },
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 4,
                            TaskName = "Child Task 3",
                            StartDate = "02/20/2017 12:00 AM",
                            Duration = "1",
                            Progress = 40
                        }
                    })

            });

            list.Add(new GanttWorkingTimeRangeData()
            {
                TaskID = 5,
                TaskName = "Parent Task 2",
                StartDate = "02/20/2017 10:00 AM",
                Duration = "1",
                Progress = 40,
                Children = (new List<GanttWorkingTimeRangeData>()
                    {
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 6,
                            TaskName = "Child Task 1",
                            StartDate = "02/20/2017 10:00 AM",
                            Duration = "1",
                            Progress = 40
                        },
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 7,
                            TaskName = "Child Task 2",
                            StartDate = "02/20/2017 10:00 AM",
                            Duration = "1",
                            Progress = 40,
                        },
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 8,
                            TaskName = "Child Task 3",
                            StartDate = "02/20/2017 10:00 AM",
                            Duration = "1",
                            Progress = 40,
                        },
                        new GanttWorkingTimeRangeData()
                        {
                            TaskID = 9,
                            TaskName = "Child Task 4",
                            StartDate = "02/20/2017 10:00 AM",
                            Duration = "1",
                            Progress = 40,
                        }
                    })

            });
            return list;
        }

        public class GanttWorkingTimeRangeData
        {
            public string StartDate { get; set; }
            public int TaskID { get; set; }
            public string TaskName { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public List<GanttWorkingTimeRangeData> Children { get; set; }
        }
	}
}