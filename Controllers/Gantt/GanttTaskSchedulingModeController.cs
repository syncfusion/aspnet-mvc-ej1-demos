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
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {               

        public ActionResult GanttTaskSchedulingMode()
        {
            var DataSource = GanttTaskSchedulingtData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }
        public class GanttTaskSchedulingtData
        {

            public static List<TaskSchdulingData> GetData()
            {
                List<TaskSchdulingData> list = new List<TaskSchdulingData>();
                list.Add(new TaskSchdulingData()
                {
                    Id = 1,
                    Name = "Parent Task 1",
                    StartDate = "02/27/2017",
                    EndDate = "03/02/2017",
                    Duration = 5,
                    PercentDone = 40,
                    IsManual = true,
                    Children = (new List<TaskSchdulingData>()
                    {
                        new TaskSchdulingData()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/27/2017",
                            EndDate = "03/02/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new TaskSchdulingData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/27/2017",
                            EndDate = "03/02/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predescessor = "2"
                        },
                        new TaskSchdulingData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/27/2017",
                            EndDate = "03/01/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predescessor = "3SS",
                            IsManual = true
                        }
                    })

                });

                list.Add(new TaskSchdulingData()
                {
                    Id = 5,
                    Name = "Parent Task 2",
                    StartDate = "03/05/2017",
                    EndDate = "03/09/2017",
                    Duration = 5,
                    PercentDone = 40,
                    IsManual = true,
                    Children = (new List<TaskSchdulingData>()
                    {
                        new TaskSchdulingData()
                        {
                            Id = 6,
                            Name = "Child Task 1",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new TaskSchdulingData()
                        {
                            Id = 7,
                            Name = "Child Task 2",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new TaskSchdulingData()
                        {
                            Id = 8,
                            Name = "Child Task 3",
                            StartDate = "02/28/2017",
                            EndDate = "03/04/2017",
                            Duration = 5,
                            PercentDone = 40,
                            IsManual = true,
                        },
                        new TaskSchdulingData()
                        {
                            Id = 9,
                            Name = "Child Task 4",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Duration = 5,
                            PercentDone = 40,
                        }
                    })

                });
                list.Add(new TaskSchdulingData()
                {
                    Id = 10,
                    Name = "Parent Task 3",
                    StartDate = "03/16/2017",
                    EndDate = "03/16/2017",
                    Duration = 5,
                    PercentDone = 40,

                    Children = (new List<TaskSchdulingData>()
                    {
                        new TaskSchdulingData()
                        {

                            Id = 11,
                            Name = "Child Task 1",
                            StartDate = "03/13/2017",
                            EndDate = "03/16/2017",
                            Duration = 4,
                            PercentDone = 40
                        },
                        new TaskSchdulingData()
                        {
                            Id = 12,
                            Name = "Child Task 2",
                            StartDate = "03/13/2017",
                            EndDate = "03/16/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new TaskSchdulingData()
                        {
                            Id = 13,
                            Name = "Child Task 3",
                            StartDate = "03/13/2017",
                            EndDate = "03/16/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new TaskSchdulingData()
                        {
                            Id = 14,
                            Name = "Child Task 4",
                            StartDate = "03/13/2017",
                            EndDate = "03/16/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new TaskSchdulingData()
                        {
                            Id = 15,
                            Name = "Child Task 5",
                            StartDate = "03/12/2017",
                            EndDate = "03/15/2017",
                            Duration = 4,
                            PercentDone = 40,
                            IsManual = true
                        }
                    })

                });


                return list;
            }
        }

        public class TaskSchdulingData
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public bool IsManual { get; set; }
            public List<TaskSchdulingData> Children { get; set; }
            public string Predescessor { get; set; }

        }
    }
        
}
