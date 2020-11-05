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

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Default()
        {
            var data = this.GetDefaultData();
            ViewBag.datasource = data;
            return View();
        }



        private List<BusinessObject> GetDefaultData()
        {
            List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();

            BusinessObject Record1 = null;

            Record1 = new BusinessObject()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = "02/03/2017",
                EndDate = "02/07/2017",
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child1 = new BusinessObject()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = "02/03/2017",
                EndDate = "02/07/2017",
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
            };

            BusinessObject Child2 = new BusinessObject()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = "02/03/2017",
                EndDate = "02/07/2017",
                Duration = 5,
                Progress = 100,
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
            };

            BusinessObject Child3 = new BusinessObject()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = "02/03/2017",
                EndDate = "02/07/2017",
                Duration = 5,
                Progress = 100,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Approved = false
            };

            BusinessObject Child4 = new BusinessObject()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                StartDate = "02/07/2017",
                EndDate = "02/07/2017",
                Duration = 0,
                Progress = 0,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 07),
                FilterEndDate = new DateTime(2017, 02, 07),
                Approved = true
            };

            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            Record1.Children.Add(Child4);

            BusinessObject Record2 = new BusinessObject()
            {
                TaskId = 6,
                TaskName = "Design",
                StartDate = "02/10/2017",
                EndDate = "02/14/2017",
                Progress = 86,
                Duration = 3,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 14),
                Approved = false,
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child5 = new BusinessObject()
            {
                TaskId = 7,
                TaskName = "Software Specification",
                StartDate = "02/10/2017",
                EndDate = "02/12/2017",
                Duration = 3,
                Progress = 60,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Approved = false
            };

            BusinessObject Child6 = new BusinessObject()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                StartDate = "02/10/2017",
                EndDate = "02/12/2017",
                Duration = 3,
                Progress = 100,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Approved = false
            };

            BusinessObject Child7 = new BusinessObject()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                StartDate = "02/13/2017",
                EndDate = "02/14/2017",
                Duration = 2,
                Progress = 100,
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 13),
                FilterEndDate = new DateTime(2017, 02, 14),
            };

            BusinessObject Child8 = new BusinessObject()
            {
                TaskId = 10,
                TaskName = "Design complete",
                StartDate = "02/14/2017",
                EndDate = "02/14/2017",
                Duration = 0,
                Progress = 0,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 14),
                FilterEndDate = new DateTime(2017, 02, 14),
                Approved = true
            };

            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            Record2.Children.Add(Child8);
            BusinessObject Record3 = new BusinessObject()
            {
                TaskId = 12,
                TaskName = "Implementation Phase",
                StartDate = "02/17/2017",
                EndDate = "02/17/2017",
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 17),
                Children = new List<BusinessObject>(),
            };

            BusinessObject Record4 = new BusinessObject()
            {
                TaskId = 13,
                TaskName = "Phase 1",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Priority = "High",
                Approved = false,
                Duration = 11,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record7 = new BusinessObject()
            {
                TaskId = 14,
                TaskName = "Implementation Module 1",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Priority = "Normal",
                Duration = 11,
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child9 = new BusinessObject()
            {
                TaskId = 15,
                TaskName = "Development Task 1",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
                Approved = false
            };
            BusinessObject Child10 = new BusinessObject()
            {
                TaskId = 10,
                TaskName = "Development Task 2",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
                Approved = true
            };
            BusinessObject Child11 = new BusinessObject()
            {
                TaskId = 17,
                TaskName = "Testing",
                StartDate = "02/20/2017",
                EndDate = "02/21/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 20),
                FilterEndDate = new DateTime(2017, 02, 21),
                Approved = true
            };
            BusinessObject Child12 = new BusinessObject()
            {
                TaskId = 18,
                TaskName = "Bug fix",
                StartDate = "02/24/2017",
                EndDate = "02/25/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 24),
                FilterEndDate = new DateTime(2017, 02, 25),
                Approved = false
            };
            BusinessObject Child13 = new BusinessObject()
            {
                TaskId = 19,
                TaskName = "Customer review meeting",
                StartDate = "02/26/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Progress = 0,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 26),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = false
            };
            BusinessObject Child14 = new BusinessObject()
            {
                TaskId = 20,
                TaskName = "Phase 1 complete",
                StartDate = "02/27/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = true
            };
            Record7.Children.Add(Child9);
            Record7.Children.Add(Child10);
            Record7.Children.Add(Child11);
            Record7.Children.Add(Child12);
            Record7.Children.Add(Child13);
            Record7.Children.Add(Child14);
            Record4.Children.Add(Record7);
            Record3.Children.Add(Record4);
            BusinessObject Record5 = new BusinessObject()
            {
                TaskId = 21,
                TaskName = "Phase 2",
                StartDate = "02/17/2017",
                EndDate = "02/28/2017",
                Children = new List<BusinessObject>(),
                Priority = "High",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 28),
                Duration = 12,
            };
            BusinessObject Record8 = new BusinessObject()
            {
                TaskId = 22,
                TaskName = "Implementation Module 2",
                StartDate = "02/17/2017",
                EndDate = "02/28/2017",
                Priority = "Critical",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 28),
                Duration = 12,
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child15 = new BusinessObject()
            {
                TaskId = 23,
                TaskName = "Development Task 1",
                StartDate = "02/17/2017",
                EndDate = "02/20/2017",
                Duration = 4,
                Progress = 50,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 20),
                Approved = true,
            };
            BusinessObject Child16 = new BusinessObject()
            {
                TaskId = 24,
                TaskName = "Development Task 2",
                StartDate = "02/17/2017",
                EndDate = "02/20/2017",
                Duration = 4,
                Progress = 50,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 20),
                Approved = true,
            };
            BusinessObject Child17 = new BusinessObject()
            {
                TaskId = 25,
                TaskName = "Testing",
                StartDate = "02/21/2017",
                EndDate = "02/24/2017",
                Duration = 2,
                Progress = 0,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 21),
                FilterEndDate = new DateTime(2017, 02, 24),
                Approved = false,
            };
            BusinessObject Child18 = new BusinessObject()
            {
                TaskId = 26,
                TaskName = "Bug fix",
                StartDate = "02/25/2017",
                EndDate = "02/26/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Low",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 25),
                FilterEndDate = new DateTime(2017, 02, 26),
            };
            BusinessObject Child19 = new BusinessObject()
            {
                TaskId = 27,
                TaskName = "Customer review meeting",
                StartDate = "02/27/2017",
                EndDate = "02/28/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 28),
                Approved = true,
            };
            BusinessObject Child20 = new BusinessObject()
            {
                TaskId = 28,
                TaskName = "Phase 2 complete",
                StartDate = "02/28/2017",
                EndDate = "02/28/2017",
                Duration = 2,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 28),
                FilterEndDate = new DateTime(2017, 02, 28),
                Approved = false,
            };
            Record8.Children.Add(Child15);
            Record8.Children.Add(Child16);
            Record8.Children.Add(Child17);
            Record8.Children.Add(Child18);
            Record8.Children.Add(Child19);
            Record8.Children.Add(Child20);
            Record5.Children.Add(Record8);
            Record3.Children.Add(Record5);
            BusinessObject Record6 = new BusinessObject()
            {
                TaskId = 29,
                TaskName = "Phase 3",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Duration = 11,
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record9 = new BusinessObject()
            {
                TaskId = 22,
                TaskName = "Implementation Module 3",
                StartDate = "02/17/2017",
                EndDate = "02/27/2017",
                Priority = "High",
                Approved = false,
                Duration = 11,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child21 = new BusinessObject()
            {
                TaskId = 31,
                TaskName = "Development Task 1",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
            };
            BusinessObject Child22 = new BusinessObject()
            {
                TaskId = 32,
                TaskName = "Development Task 2",
                StartDate = "02/17/2017",
                EndDate = "02/19/2017",
                Duration = 3,
                Progress = 50,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
            };
            BusinessObject Child23 = new BusinessObject()
            {
                TaskId = 33,
                TaskName = "Testing",
                StartDate = "02/20/2017",
                EndDate = "02/21/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 20),
                FilterEndDate = new DateTime(2017, 02, 21),
                Approved = true,

            };
            BusinessObject Child24 = new BusinessObject()
            {
                TaskId = 34,
                TaskName = "Bug fix",
                StartDate = "02/24/2017",
                EndDate = "02/25/2017",
                Duration = 2,
                Progress = 0,
                Priority = "High",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 24),
                FilterEndDate = new DateTime(2017, 02, 25),
            };
            BusinessObject Child25 = new BusinessObject()
            {
                TaskId = 35,
                TaskName = "Customer review meeting",
                StartDate = "02/26/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Progress = 0,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 26),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = true,
            };
            BusinessObject Child26 = new BusinessObject()
            {
                TaskId = 36,
                TaskName = "Phase 3 complete",
                StartDate = "02/27/2017",
                EndDate = "02/27/2017",
                Duration = 2,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = false,
            };
            Record9.Children.Add(Child21);
            Record9.Children.Add(Child22);
            Record9.Children.Add(Child23);
            Record9.Children.Add(Child24);
            Record9.Children.Add(Child25);
            Record9.Children.Add(Child26);
            Record6.Children.Add(Record9);
            Record3.Children.Add(Record6);
            BusinessObjectCollection.Add(Record1);
            BusinessObjectCollection.Add(Record2);
            BusinessObjectCollection.Add(Record3);

            return BusinessObjectCollection;
        }


        public class BusinessObject
        {
            public int TaskId
            {
                get;
                set;
            }

            public string TaskName
            {
                get;
                set;
            }

            public string StartDate
            {
                get;
                set;
            }

            public string EndDate
            {
                get;
                set;
            }

            public int Duration
            {
                get;
                set;
            }

            public int Progress
            {
                get;
                set;
            }
            public string Priority
            {
                get;
                set;
            }
            public bool Approved
            {
                get;
                set;
            }

            public DateTime FilterStartDate
            {
                get;
                set;
            }
            public DateTime FilterEndDate
            { 
                get;
                set; 
            }

            public List<BusinessObject> Children
            {
                get;
                set;
            }

            public int? ParentId
            {
                get;
                set;
            }

        }
    }
}
