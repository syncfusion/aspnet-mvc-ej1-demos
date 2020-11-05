#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using MVCSampleBrowser.Models;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /TimeOptions/

        public ActionResult TimeOptions()
        {
            var dataSource = GanttTimeOptionsData.GetDataSource();
            ViewBag.datasource = dataSource;
            return View();
        }
        public class GanttTimeOptionsData
        {
            #region Create DataSource for Gantt control
            public static List<TimeOptionsData> GetDataSource()
            {
            List<TimeOptionsData> list = new List<TimeOptionsData>();
            list.Add(new TimeOptionsData()
            {
                TaskID = 1,
                TaskName = "Parent Task 1",
                StartDate = "02/23/2017",
                duration = 7,
                Progress = "40",
                Children = (new List<TimeOptionsData>()
                    {
                        new TimeOptionsData()
                        {
                            TaskID = 2,
                            TaskName = "Child Task 1",
                            StartDate = "02/23/2017 08:00:00 AM",
                            duration = 7,
                            Progress = "40",
                        },
                        new TimeOptionsData()
                        {
                            TaskID = 3,
                            TaskName = "Child Task 2",
                            StartDate = "02/23/2017 08:00:00 AM",
                            duration = 7,
                            Progress = "40"
                        },
                        new TimeOptionsData()
                        {
                            TaskID = 4,
                            TaskName = "Child Task 3",
                            StartDate = "02/23/2017 08:00:00 AM",
                            duration = 7,
                            Progress = "40"
                        }
                    })

            });

            list.Add(new TimeOptionsData()
            {
                TaskID = 5,
                TaskName = "Parent Task 2",
                StartDate = "02/24/2017",
                duration = 7,
                Progress = "40",
                Children = (new List<TimeOptionsData>()
                    {
                        new TimeOptionsData()
                        {
                            TaskID = 6,
                            TaskName = "Child Task 1",
                            StartDate = "02/23/2017 10:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                        new TimeOptionsData()
                        {
                            TaskID = 7,
                            TaskName = "Child Task 2",
                            StartDate = "02/23/2017 10:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                        new TimeOptionsData()
                        {
                            TaskID = 8,
                            TaskName = "Child Task 3",
                            StartDate = "02/23/2017 10:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                         new TimeOptionsData()
                        {
                            TaskID = 9,
                            TaskName = "Child Task 4",
                            StartDate = "02/23/2017 10:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        }
                    })

            });
            list.Add(new TimeOptionsData()
            {
                TaskID = 10,
                TaskName = "Parent Task 3",
                StartDate = "02/25/2017",
                duration = 7,
                Progress = "40",
                Children = (new List<TimeOptionsData>()
                    {
                        new TimeOptionsData()
                        {
                            TaskID = 11,
                            TaskName = "Child Task 1",
                            StartDate = "02/24/2017 12:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                        new TimeOptionsData()
                        {
                            TaskID = 12,
                            TaskName = "Child Task 2",
                            StartDate = "02/24/2017 12:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                        new TimeOptionsData()
                        {
                            TaskID = 13,
                            TaskName = "Child Task 3",
                            StartDate = "02/24/2017 12:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                         new TimeOptionsData()
                        {
                            TaskID = 14,
                            TaskName = "Child Task 4",
                            StartDate = "02/24/2017 12:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        },
                         new TimeOptionsData()
                        {
                            TaskID = 15,
                            TaskName = "Child Task 5",
                            StartDate = "02/24/2017 12:00:00 PM",
                            duration = 7,
                            Progress = "40",
                        }
                    })

            });
            return list;
        }
            #endregion
        }

        #region TimeOptionsData Creation
        public class TimeOptionsData
        {
            public string StartDate { get; set; }
            public int duration { get; set; }
            public int TaskID { get; set; }
            public string TaskName { get; set; }
            public string Progress { get; set; }
            public List<TimeOptionsData> Children { get; set; }
        }
        #endregion

    }
}
