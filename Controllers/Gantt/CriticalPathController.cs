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
        // GET: CriticalPath
        public ActionResult CriticalPath()
        {
            var DataSource = GetCriticalPathData();
            ViewBag.datasource = DataSource;
            return View();
        }
        public class TaskCriticalPathDetails
        {
            public int CriticalTaskID { get; set; }
            public string CriticalTaskName { get; set; }
            public string CriticalStartDate { get; set; }
            public string CriticalEndDate { get; set; }
            public int CriticalDuration { get; set; }
            public string CriticalProgress { get; set; }
            public List<TaskCriticalPathDetails> CriticalSubTasks { get; set; }
            public string CriticalPredecessors { get; set; }
        }
        public List<TaskCriticalPathDetails> GetCriticalPathData()
        {
            List<TaskCriticalPathDetails> tasks = new List<TaskCriticalPathDetails>();

            tasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 1,
                CriticalTaskName = "Project Schedule",
                CriticalStartDate = "02/06/2017",
                CriticalEndDate = "03/10/2017"
            });

            tasks[0].CriticalSubTasks = new List<TaskCriticalPathDetails>();

            tasks[0].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 2,
                CriticalTaskName = "Planning",
                CriticalStartDate = "02/06/2017",
                CriticalEndDate = "02/10/2017"
            });

            tasks[0].CriticalSubTasks[0].CriticalSubTasks = new List<TaskCriticalPathDetails>();


            tasks[0].CriticalSubTasks[0].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 3,
                CriticalTaskName = "Plan timeline",
                CriticalStartDate = "02/06/2017",
                CriticalEndDate = "02/10/2017",
                CriticalDuration = 5,
                CriticalProgress = "80",
            });
            tasks[0].CriticalSubTasks[0].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 4,
                CriticalTaskName = "Plan budget",
                CriticalStartDate = "02/06/2017",
                CriticalEndDate = "02/10/2017",
                CriticalDuration = 5,
                CriticalProgress = "70",
                CriticalPredecessors = "3FS",
            });
            tasks[0].CriticalSubTasks[0].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 5,
                CriticalTaskName = "Allocate TaskLabelResources",
                CriticalStartDate = "02/06/2017",
                CriticalEndDate = "02/10/2017",
                CriticalDuration = 5,
                CriticalProgress = "80",
                CriticalPredecessors = "4SS",
            });
            tasks[0].CriticalSubTasks[0].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 6,
                CriticalTaskName = "Planning complete",
                CriticalStartDate = "02/10/2017",
                CriticalEndDate = "02/10/2017",
                CriticalDuration = 0,
                CriticalPredecessors = "4FS",
            });

            tasks[0].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 7,
                CriticalTaskName = "Design",
                CriticalStartDate = "02/13/2017",
                CriticalEndDate = "02/17/2017"
            });

            tasks[0].CriticalSubTasks[1].CriticalSubTasks = new List<TaskCriticalPathDetails>();

            tasks[0].CriticalSubTasks[1].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 8,
                CriticalTaskName = "Software Specification",
                CriticalStartDate = "02/13/2017",
                CriticalEndDate = "02/15/2017",
                CriticalDuration = 3,
                CriticalProgress = "60",
                CriticalPredecessors = "6FS",
            });
            tasks[0].CriticalSubTasks[1].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 9,
                CriticalTaskName = "Develop prototype",
                CriticalStartDate = "02/13/2017",
                CriticalEndDate = "02/15/2017",
                CriticalDuration = 3,
                CriticalProgress = "40",
                CriticalPredecessors = "6FS",
            });
            tasks[0].CriticalSubTasks[1].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 10,
                CriticalTaskName = "Get approval from customer",
                CriticalStartDate = "02/16/2017",
                CriticalEndDate = "02/21/2017",
                CriticalDuration = 5,
                CriticalProgress = "50",
                CriticalPredecessors = "9FS",
            });
            tasks[0].CriticalSubTasks[1].CriticalSubTasks.Add(new TaskCriticalPathDetails()
            {
                CriticalTaskID = 11,
                CriticalTaskName = "Design complete",
                CriticalStartDate = "02/21/2017",
                CriticalEndDate = "02/24/2017",
                CriticalDuration = 3,
                CriticalPredecessors = "10FS",
            });

            return tasks;

        }
        }
    }