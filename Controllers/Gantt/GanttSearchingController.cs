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
        // GET: /GanttSearching/

        public ActionResult GanttSearching()
        {
            var DataSource = GanttSearchData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }


        public class GanttSearchData
        {

            public static List<SearchData> GetData()
            {
                List<SearchData> list = new List<SearchData>();
                list.Add(new SearchData()
                {
                    Id = 1,
                    Name = "Parent Task 1",
                    StartDate = "02/27/2017",
                    Duration = 5,
                    PercentDone = 40,
                    Children = (new List<SearchData>()
                    {
                        new SearchData()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new SearchData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new SearchData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/27/2017",
                            Duration = 5,
                            PercentDone = 40,
                        }
                    })

                });

                list.Add(new SearchData()
                {
                    Id = 5,
                    Name = "Parent Task 2",
                    StartDate = "03/06/2017",
                    Duration = 5,
                    PercentDone = 40,

                    Children = (new List<SearchData>()
                    {
                        new SearchData()
                        {
                            Id = 6,
                            Name = "Child Task 1",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new SearchData()
                        {
                            Id = 7,
                            Name = "Child Task 2",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new SearchData()
                        {
                            Id = 8,
                            Name = "Child Task 3",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new SearchData()
                        {
                            Id = 9,
                            Name = "Child Task 4",
                            StartDate = "03/06/2017",
                            Duration = 5,
                            PercentDone = 40,
                        }
                    })

                });
                list.Add(new SearchData()
                {
                    Id = 10,
                    Name = "Parent Task 3",
                    StartDate = "03/13/2017",
                    Duration = 5,
                    PercentDone = 40,

                    Children = (new List<SearchData>()
                    {
                        new SearchData()
                        {

                            Id = 11,
                            Name = "Child Task 1",
                            StartDate = "03/13/2017",
                            Duration = 4,
                            PercentDone = 40
                        },
                        new SearchData()
                        {
                            Id = 12,
                            Name = "Child Task 2",
                            StartDate = "03/13/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new SearchData()
                        {
                            Id = 13,
                            Name = "Child Task 3",
                            StartDate = "03/13/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new SearchData()
                        {
                            Id = 14,
                            Name = "Child Task 4",
                            StartDate = "03/13/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                        new SearchData()
                        {
                            Id = 15,
                            Name = "Child Task 5",
                            StartDate = "03/13/2017",
                            Duration = 4,
                            PercentDone = 40,
                        },
                    })

                });


                return list;
            }
        }

        public class SearchData
        {
            public string StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<SearchData> Children { get; set; }
            public string Predescessor { get; set; }

        }
    }
}
