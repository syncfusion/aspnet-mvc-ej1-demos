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

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /BaseLine/

        public ActionResult BaseLine()
        {
            var DataSource = BaseLineGanttData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }

        public class BaseLineGanttData
        {

            public static List<BaseLineData> GetData()
            {
                List<BaseLineData> list = new List<BaseLineData>();
                list.Add(new BaseLineData()
                {
                    Id = 1,
                    Name = "Task 1",
                    StartDate = "10/25/2017",
                    BaselineStartDate = "10/25/2017",
                    BaselineEndDate = "10/30/2017",
                    Duration = 10,
                    PercentDone = 70,

                    Children = (new List<BaseLineData>()
                    {
                        new BaseLineData()
                        {
                            Id = 2,
                            Name = "Child task 1",
                            StartDate = "10/25/2017",
                            BaselineStartDate = "10/25/2017",
                            BaselineEndDate = "10/27/2017",
                            Duration = 4,
                            PercentDone = 80,
                        },
                        new BaseLineData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "10/26/2017",
                            BaselineStartDate = "10/26/2017",
                            BaselineEndDate = "10/30/2017",
                            Duration = 5,
                            PercentDone = 65,
                            Predecessor = "2",
                        },
                        new BaseLineData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "10/27/2017",
                            BaselineStartDate = "10/26/2017",
                            BaselineEndDate = "10/30/2017",
                            Duration = 6,
                            PercentDone = 77,

                            Children = (new List<BaseLineData>()
                            {
                                new BaseLineData()
                                {
                                    Id = 5,
                                    Name = "Grand child task 1",
                                    StartDate = "10/30/2017",
                                    BaselineStartDate = "10/29/2017",
                                    BaselineEndDate = "11/3/2017",
                                    Duration = 5,
                                    PercentDone = 60
                                },
                                new BaseLineData()
                                {
                                    Id = 6,
                                    Name = "Grand child task 2",
                                    StartDate = "10/31/2017",
                                    BaselineStartDate = "10/31/2017",
                                    BaselineEndDate = "11/02/2017",
                                    Duration = 6,
                                    PercentDone = 77,
                                    Predecessor = "5"
                                },
                                new BaseLineData()
                                {
                                    PercentDone = 70,
                                    Id = 7,
                                    Name = "Grand child task 3",
                                    StartDate = "10/27/2017",
                                    BaselineStartDate = "10/27/2017",
                                    BaselineEndDate = "10/27/2017",
                                    Predecessor = "6"
                                }
                            })

                        }
                    })
                });



                return list;
            }
        }

        public class BaseLineData
        {
            public string StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<BaseLineData> Children { get; set; }
            public string Predescessor { get; set; }
            public string BaselineStartDate { get; set; }
            public string BaselineEndDate { get; set; }
            public string Predecessor { get; set; }
        }
    }
}
