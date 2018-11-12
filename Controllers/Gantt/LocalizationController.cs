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
        // GET: /Localization/

        public ActionResult Localization()
        {
            var DataSource = GanttLocalizationData.GetData();
            ViewBag.datasource = DataSource;
            return View();
            
        }

        public class GanttLocalizationData
        {

            public static List<LocalizationData> GetData()
            {
                List<LocalizationData> list = new List<LocalizationData>();
                list.Add(new LocalizationData()
                {
                    Id = 1,
                    Name = "Task 1",
                    StartDate = new System.DateTime(2017,10,18),
                    Duration = 10,
                    PercentDone = 70,
                    Children = (new List<LocalizationData>()
                    {
                        new LocalizationData()
                        {
                            Id = 2,
                            Name = "Child task 1",
                            StartDate = new System.DateTime(2017,10,18),
                            Duration = 4,
                            PercentDone = 80
                        },
                        new LocalizationData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = new System.DateTime(2017,10,19),
                            Duration = 5,
                            PercentDone = 65,
                            Predescessor = "2"
                        },
                        new LocalizationData()
                        {
                            Id = 4,
                            Name = "Child task 3",
                            StartDate = new System.DateTime(2017,10,23),
                            Duration = 6,
                            PercentDone = 77,
                            Children = (new List<LocalizationData>()
                            {
                                new LocalizationData()
                                {
                                    Id = 5,
                                    Name = "Grand child task 1",
                                    StartDate = new System.DateTime(2017,10,23),
                                    Duration = 3,
                                    PercentDone = 60,
                                    Predescessor = "2"
                                },
                                new LocalizationData()
                                {
                                    Id = 6,
                                    Name = "Grand child task 2",
                                    StartDate = new System.DateTime(2017,10,24),
                                    Duration = 2,
                                    PercentDone = 77,
                                    Predescessor = "5"

                                },
                                new LocalizationData()
                                {
                                    Id = 7,
                                    Name = "Grand child task 3",
                                    StartDate = new System.DateTime(2017,10,25),
                                    Duration = 0,
                                    PercentDone = 0,
                                    Predescessor = "6"
                                }
                            })
                        }
                    })

                });




                return list;
            }
        }

        public class LocalizationData
        {
            public object StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<LocalizationData> Children { get; set; }
            public string Predescessor { get; set; }

        }
         
    }
}
