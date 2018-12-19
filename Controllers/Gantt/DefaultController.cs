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
using MVCSampleBrowser.Models;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Default()
        {
            var DataSource = GanttDefaultData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }


        public class GanttDefaultData
        {

            public static List<DefaultData> GetData()
            {
                List<DefaultData> list = new List<DefaultData>();
                list.Add(new DefaultData()
                {
                    Id = 1,
                    Name = "Parent Task 1",
                    StartDate = "02/27/2017",
                    EndDate = "03/03/2017",
                    Duration = 5,
                    PercentDone = 40,
                    Children = (new List<DefaultData>()
                    {
                        new DefaultData()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/27/2017",
                            EndDate="03/03/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new DefaultData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/27/2017",
                            EndDate="03/03/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predescessor = "2"
                        },
                        new DefaultData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/27/2017",
                            EndDate="03/03/2017",
                            Duration = 5,
                            PercentDone = 40,
                            Predescessor = "3SS"
                        }
                    })

                });

                list.Add(new DefaultData()
                {
                    Id = 5,
                    Name = "Parent Task 2",
                    StartDate = "03/06/2017",
                    EndDate = "03/10/2017",
                    Duration = 5,
                    PercentDone = 40,
                    Children = (new List<DefaultData>()
                    {
                        new DefaultData()
                        {
                            Id = 6,
                            Name = "Child Task 1",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new DefaultData()
                        {
                            Id = 7,
                            Name = "Child Task 2",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new DefaultData()
                        {
                            Id = 8,
                            Name = "Child Task 3",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new DefaultData()
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
                list.Add(new DefaultData()
                {
                    Id = 10,
                    Name = "Parent Task 3",
                    StartDate = "03/13/2017",
                    EndDate = "03/17/2017",
                    Duration = 5,
                    PercentDone = 40,

                    Children = (new List<DefaultData>()
                    {
                        new DefaultData()
                        {

                            Id = 11,
                            Name = "Child Task 1",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Duration = 4,
                            PercentDone = 40
                        },
                        new DefaultData()
                        {
                            Id = 12,
                            Name = "Child Task 2",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new DefaultData()
                        {
                            Id = 13,
                            Name = "Child Task 3",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new DefaultData()
                        {
                            Id = 14,
                            Name = "Child Task 4",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new DefaultData()
                        {
                            Id = 15,
                            Name = "Child Task 5",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Duration = 4,
                            PercentDone = 40,
                        }
                    })

                });


                return list;
            }
        }

        public class DefaultData
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<DefaultData> Children { get; set; }
            public string Predescessor { get; set; }

        }
    }
}
