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
using Syncfusion.JavaScript.Models;


namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttWBS/

        public ActionResult GanttWBS()
        {
            var DataSource = GanttData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }
        public class GanttData
        {

            public static List<WBSData> GetData()
            {
                List<WBSData> list = new List<WBSData>();
                list.Add(new WBSData()
                {
                    Id = 1,
                    Name = "Parent Task 1",
                    StartDate = "02/27/2017",
                    Duration = 5,
                    PercentDone = 40,
                    Children = (new List<WBSData>()
                    {
                        new WBSData()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new WBSData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new WBSData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new WBSData()
                        {
                            Id = 5,
                            Name = "Child Task 4",
                            StartDate = "02/23/2014",
                            Duration = 0,
                            PercentDone = 40,
                            Predecessor = "3FS,4FS"
                        }
                    })

                });

                list.Add(new WBSData()
                {
                    Id = 6,
                    Name = "Parent Task 2",
                    StartDate = "03/06/2017",
                    Duration = 5,
                    PercentDone = 40,

                    Children = (new List<WBSData>()
                    {
                        new WBSData()
                        {
                            Id = 7,
                            Name = "Child Task 1",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new WBSData()
                        {
                            Id = 8,
                            Name = "Child Task 2",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predecessor = "7FS"
                        },
                        new WBSData()
                        {
                            Id = 9,
                            Name = "Child Task 3",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predecessor = "8FS"
                        },
                        new WBSData()
                        {
                            Id = 10,
                            Name = "Child Task 4",
                            StartDate = "03/06/2017",
                            PercentDone = 40,
                            Predecessor = "9FS"
                        }
                    })

                });
                list.Add(new WBSData()
                {
                    Id = 11,
                    Name = "Parent Task 3",
                    StartDate = "03/13/2017",
                    Duration = 5,
                    PercentDone = 40,

                    Children = (new List<WBSData>()
                    {
                        new WBSData()
                        {

                            Id = 12,
                            Name = "Child Task 1",
                            StartDate = "03/13/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new WBSData()
                        {
                            Id = 13,
                            Name = "Child Task 2",
                            StartDate = "03/13/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new WBSData()
                        {
                            Id = 14,
                            Name = "Child Task 3",
                            StartDate = "03/13/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predecessor = "12FS,13FS"
                        },
                          new WBSData()
                        {
                            Id = 15,
                            Name = "Child Task 4",
                            StartDate = "03/13/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predecessor = "14FS"
                        },
                          new WBSData()
                        {
                            Id = 16,
                            Name = "Child Task 5",
                            StartDate = "03/13/2017",
                            Duration = 0,
                            PercentDone = 40,
                            Predecessor = "15FS"
                        }
                    })

                });
                return list;
            }
            public class WBSData
            {
                public string StartDate { get; set; }
                public int Id { get; set; }
                public string Name { get; set; }
                public int Duration { get; set; }
                public int PercentDone { get; set; }
                public List<WBSData> Children { get; set; }
                public string Predecessor { get; set; }

            }
        }       
    }
}
