#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridVirtualization/

        public ActionResult TreeGridVirtualization()
        {
            var DataSource = TreeGridDataSource.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }

        public class TreeGridDataSource
        {

            public static List<VirtualizationData> GetData()
            {
                List<VirtualizationData> list = new List<VirtualizationData>();
                var x = 0;
                for (var i = 0; i < 1250; i++)
                {
                    list.Add(new VirtualizationData()
                    {
                        Id = ++x,
                        Name = "Task" + (i + 1),
                        PercentDone = 50,
                        StartDate = "01/17/2017",
                        Duration = 5,

                        Children = (new List<VirtualizationData>()
                        {
                            new VirtualizationData()
                            {
                                Id = ++x,
                                Name = "Child Task 1",
                                PercentDone = 50,
                                StartDate = "01/17/2017",
                                Duration = 5
                            },
                            new VirtualizationData()
                            {
                                Id = ++x,
                                Name = "Child Task 2",
                                PercentDone = 50,
                                StartDate = "01/17/2017",
                                Duration = 5,
                            },
                            new VirtualizationData()
                            {
                                Id = ++x,
                                Name = "Child Task 3",
                                PercentDone = 50,
                                StartDate = "01/17/2017",
                                Duration = 5,
                            }
                        })

                    });

                }


                return list;
            }
        }

        public class VirtualizationData
        {
            public string StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<VirtualizationData> Children { get; set; }
        }

    }
}
