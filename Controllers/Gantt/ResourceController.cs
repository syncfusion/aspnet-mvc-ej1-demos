#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
        // GET: /Resource/

        public ActionResult Resource()
        {
            var DataSource = ResourceDataSource.GetData();
            ViewBag.datasource = DataSource;
            var Resources = ResourceList.GetData();
            ViewBag.resources = Resources;
            return View();
        }


        public class ResourceList
        {
            public static List<ResourceListData> GetData()
            {
                List<ResourceListData> list=new List<ResourceListData>();

                list.Add(new ResourceListData() { Id = 1, Name = "Resource1" });
                list.Add(new ResourceListData() { Id = 2, Name = "Resource2" });
                list.Add(new ResourceListData() { Id = 3, Name = "Resource3" });
                list.Add(new ResourceListData() { Id = 4, Name = "Resource4" });
                list.Add(new ResourceListData() { Id = 5, Name = "Resource5" });
                list.Add(new ResourceListData() { Id = 6, Name = "Resource6" });
                list.Add(new ResourceListData() { Id = 7, Name = "Resource7" });
                return list;
            }
        }

        public class ResourceListData
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class ResourceDataSource
        {

            public static List<ResourceData> GetData()
            {
                List<ResourceData> list = new List<ResourceData>();
                list.Add(new ResourceData()
                {
                    Id = 1,
                    Name = "Task 1",
                    StartDate = "10/25/2017",
                    BaselineStartDate = "10/25/2017",
                    BaselineEndDate = "10/30/2017",
                    Duration = 10,
                    PercentDone = 70,
                    Resources =new List<int>(){1,2,4,5},

                    Children = (new List<ResourceData>()
                    {
                        new ResourceData()
                        {
                            Id = 2,
                            Name = "Child task 1",
                            StartDate = "10/25/2017",
                            BaselineStartDate = "10/25/2017",
                            BaselineEndDate = "10/30/2017",
                            Duration = 4,
                            PercentDone = 80,
                            Resources =new List<int>(){ 2,4},
                        },
                        new ResourceData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "10/26/2017",
                            BaselineStartDate = "10/26/2017",
                            BaselineEndDate = "10/30/2017",
                            Duration = 5,
                            PercentDone = 65,
                            Predecessor = "2",
                            Resources =new List<int>(){1},
                        },
                        new ResourceData()
                        {
                            Id = 4,
                            Name = "Child task 3",
                            StartDate = "10/27/2017",
                            BaselineStartDate = "10/28/2017",
                            BaselineEndDate = "10/30/2017",
                            Duration = 6,
                            PercentDone = 77,
                            Resources =new List<int>(){5},
                            Children = (new List<ResourceData>()
                            {
                                new ResourceData()
                                {
                                    Id = 5,
                                    Name = "Grand child task 1",
                                    StartDate = "10/30/2017",
                                    BaselineStartDate = "10/29/2017",
                                    BaselineEndDate = "11/3/2017",
                                    Duration = 5,
                                    PercentDone = 60,
                                    Resources =new List<int>(){1,3,7},
                                },
                                new ResourceData()
                                {
                                    Id = 6,
                                    Name = "Grand child task 2",
                                    StartDate = "10/31/2017",
                                    BaselineStartDate = "10/31/2017",
                                    BaselineEndDate = "11/02/2017",
                                    Duration = 6,
                                    PercentDone = 77,
                                    Predecessor = "5",
                                    Resources =new List<int>(){7},
                                },
                                new ResourceData()
                                {
                                    Id = 7,
                                    Name = "Grand child task 3",
                                    StartDate = new System.DateTime(2017, 10, 25),
                                    BaselineStartDate = "10/27/2017",
                                    BaselineEndDate = "10/27/2017",
                                    Duration = 0,
                                    PercentDone = 0,
                                    Predecessor = "6"

                                }
                            })
                        }
                    })

                });




                return list;
            }
        }

        public class ResourceData
        {
            public object StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<ResourceData> Children { get; set; }
            public string Predecessor { get; set; }
            public string BaselineStartDate { get; set; }
            public string BaselineEndDate { get; set; }
            public List<int> Resources { get; set; }

        }
    }
}
