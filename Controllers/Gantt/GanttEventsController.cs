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
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttEvents/

        public ActionResult GanttEvents()
        {
            var DataSource = GanttEventsData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }



        public class GanttEventsData
        {

            public static List<EventsData> GetData()
            {
                List<EventsData> list = new List<EventsData>();
                list.Add(new EventsData()
                {
                    Id = 1,
                    Name = "Parent Task 1",
                    StartDate = "02/27/2017",
                    Duration = 5,
                    PercentDone = 40,
                    Children = (new List<EventsData>()
                    {
                        new EventsData()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new EventsData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new EventsData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40,
                        }
                    })

                });

                list.Add(new EventsData()
                {
                    Id = 5,
                    Name = "Parent Task 2",
                    StartDate = "03/06/2017",
                    Duration = 5,
                    PercentDone = 40,
                    Children = (new List<EventsData>()
                    {
                        new EventsData()
                        {
                            Id = 6,
                            Name = "Child Task 1",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new EventsData()
                        {
                            Id = 7,
                            Name = "Child Task 2",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new EventsData()
                        {
                            Id = 8,
                            Name = "Child Task 3",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new EventsData()
                        {
                            Id = 9,
                            Name = "Child Task 4",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                         new EventsData()
                        {
                            Id = 10,
                            Name = "Child Task 5",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        }
                    })
                });
                return list;
            }
        }

        public class EventsData
        {
            public string StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<EventsData> Children { get; set; }
            public string Predescessor { get; set; }

        }
    }
}
