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

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridPagingAPI/
        public ActionResult TreeGridPagingAPI()
        {
            var DataSource = GetTreeGridPagingAPIData();
            ViewBag.datasource = DataSource;
            return View();
        }

        private List<PagingAPIData> GetTreeGridPagingAPIData()
        {
            List<PagingAPIData> PagingAPIDataCollection = new List<PagingAPIData>();
            
            var x = 0;
            var c = "";
            for (var i = 1; i < 10; i++)
            {
                PagingAPIData Record1 = null;
                Record1 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Planning" + " " + (c),
                    StartDate = "02/03/2017",
                    EndDate = "02/07/2017",
                    Progress = 100,
                    Duration = 5,
                    Priority = "Normal",
                    Approved = false,
                    Children = new List<PagingAPIData>(),
                };

                PagingAPIData Child1 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Plan timeline" + " " + (c),
                    StartDate = "02/03/2017",
                    EndDate = "02/07/2017",
                    Progress = 100,
                    Duration = 5,
                    Priority = "Normal",
                    Approved = false,
                };

                PagingAPIData Child2 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Plan budget" + " " + (c),
                    StartDate = "02/03/2017",
                    EndDate = "02/07/2017",
                    Duration = 5,
                    Progress = 100,
                    Approved = true
                };

                PagingAPIData Child3 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Allocate resources" + " " + (c),
                    StartDate = "02/03/2017",
                    EndDate = "02/07/2017",
                    Duration = 5,
                    Progress = 100,
                    Priority = "Critical",
                    Approved = false
                };

                PagingAPIData Child4 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Planning complete" + " " + (c),
                    StartDate = "02/07/2017",
                    EndDate = "02/07/2017",
                    Duration = 0,
                    Progress = 0,
                    Priority = "Low",
                    Approved = true
                };

                Record1.Children.Add(Child1);
                Record1.Children.Add(Child2);
                Record1.Children.Add(Child3);
                Record1.Children.Add(Child4);

                PagingAPIData Record2 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Design" + " " + (c),
                    StartDate = "02/10/2017",
                    EndDate = "02/14/2017",
                    Progress = 86,
                    Duration = 3,
                    Priority = "High",
                    Approved = false,
                    Children = new List<PagingAPIData>(),
                };

                PagingAPIData Child5 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Software Specification" + " " + (c),
                    StartDate = "02/10/2017",
                    EndDate = "02/12/2017",
                    Duration = 3,
                    Progress = 60,
                    Priority = "Normal",
                    Approved = false
                };

                PagingAPIData Child6 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Develop prototype" + " " + (c),
                    StartDate = "02/10/2017",
                    EndDate = "02/12/2017",
                    Duration = 3,
                    Progress = 100,
                    Priority = "Critical",
                    Approved = false
                };

                PagingAPIData Child7 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Get approval from customer" + " " + (c),
                    StartDate = "02/13/2017",
                    EndDate = "02/14/2017",
                    Duration = 2,
                    Progress = 100,
                    Approved = true
                };

                PagingAPIData Child8 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Design complete" + " " + (c),
                    StartDate = "02/14/2017",
                    EndDate = "02/14/2017",
                    Duration = 0,
                    Progress = 0,
                    Priority = "Normal",
                    Approved = true
                };

                Record2.Children.Add(Child5);
                Record2.Children.Add(Child6);
                Record2.Children.Add(Child7);
                Record2.Children.Add(Child8);
                PagingAPIData Record3 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Implementation Phase" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/17/2017",
                    Priority = "Normal",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingAPIData>(),
                };

                PagingAPIData Record4 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Phase I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "High",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingAPIData>(),
                };
                PagingAPIData Record7 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Implementation Module I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "Normal",
                    Duration = 11,
                    Approved = false,
                    Children = new List<PagingAPIData>(),
                };
                PagingAPIData Child9 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Development Task I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/19/2017",
                    Duration = 3,
                    Progress = 50,
                    Priority = "High",
                    Approved = false
                };
                PagingAPIData Child10 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Development Task II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/19/2017",
                    Duration = 3,
                    Progress = 50,
                    Priority = "Low",
                    Approved = true
                };
                PagingAPIData Child11 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Testing" + " " + (c),
                    StartDate = "02/20/2017",
                    EndDate = "02/21/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Normal",
                    Approved = true
                };
                PagingAPIData Child12 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Bug fix" + " " + (c),
                    StartDate = "02/24/2017",
                    EndDate = "02/25/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Critical",
                    Approved = false
                };
                PagingAPIData Child13 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Customer review meeting" + " " + (c),
                    StartDate = "02/26/2017",
                    EndDate = "02/27/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "High",
                    Approved = false
                };
                PagingAPIData Child14 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Phase I complete" + " " + (c),
                    StartDate = "02/27/2017",
                    EndDate = "02/27/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Low",
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
                PagingAPIData Record5 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Phase II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/28/2017",
                    Children = new List<PagingAPIData>(),
                    Priority = "High",
                    Approved = false,
                    Duration = 12,
                };
                PagingAPIData Record8 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Implementation Module II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/28/2017",
                    Priority = "Critical",
                    Approved = false,
                    Duration = 12,
                    Children = new List<PagingAPIData>(),
                };
                PagingAPIData Child15 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Development Task I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/20/2017",
                    Duration = 4,
                    Progress = 50,
                    Priority = "Normal",
                    Approved = true,
                };
                PagingAPIData Child16 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Development Task II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/20/2017",
                    Duration = 4,
                    Progress = 50,
                    Priority = "Critical",
                    Approved = true,
                };
                PagingAPIData Child17 = new PagingAPIData()
                {
                    TaskId = 25,
                    TaskName = "Testing" + " " + (c),
                    StartDate = "02/21/2017",
                    EndDate = "02/24/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "High",
                    Approved = false,
                };
                PagingAPIData Child18 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Bug fix" + " " + (c),
                    StartDate = "02/25/2017",
                    EndDate = "02/26/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Low",
                    Approved = false,
                };
                PagingAPIData Child19 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Customer review meeting" + " " + (c),
                    StartDate = "02/27/2017",
                    EndDate = "02/28/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Critical",
                    Approved = true,
                };
                PagingAPIData Child20 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Phase II complete" + " " + (c),
                    StartDate = "02/28/2017",
                    EndDate = "02/28/2017",
                    Duration = 2,
                    Priority = "Normal",
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
                PagingAPIData Record6 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Phase III" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "Normal",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingAPIData>(),
                };
                PagingAPIData Record9 = new PagingAPIData()
                {
                    TaskId = 22,
                    TaskName = "Implementation Module III" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "High",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingAPIData>(),
                };
                PagingAPIData Child21 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Development Task I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/19/2017",
                    Duration = 3,
                    Progress = 50,
                    Priority = "Low",
                    Approved = true,
                };
                PagingAPIData Child22 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Development Task II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/19/2017",
                    Duration = 3,
                    Progress = 50,
                    Priority = "Normal",
                    Approved = false,
                };
                PagingAPIData Child23 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Testing" + " " + (c),
                    StartDate = "02/20/2017",
                    EndDate = "02/21/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Critical",
                    Approved = true,

                };
                PagingAPIData Child24 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Bug fix" + " " + (c),
                    StartDate = "02/24/2017",
                    EndDate = "02/25/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "High",
                    Approved = false,
                };
                PagingAPIData Child25 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Customer review meeting" + " " + (c),
                    StartDate = "02/26/2017",
                    EndDate = "02/27/2017",
                    Duration = 2,
                    Progress = 0,
                    Priority = "Normal",
                    Approved = true,
                };
                PagingAPIData Child26 = new PagingAPIData()
                {
                    TaskId = ++x,
                    TaskName = "Phase III complete" + " " + (c),
                    StartDate = "02/27/2017",
                    EndDate = "02/27/2017",
                    Duration = 2,
                    Priority = "Critical",
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
                PagingAPIDataCollection.Add(Record1);
                PagingAPIDataCollection.Add(Record2);
                PagingAPIDataCollection.Add(Record3);
                c = i.ToString();
            }
            return PagingAPIDataCollection;
        }


        public class PagingAPIData
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

            public List<PagingAPIData> Children
            {
                get;
                set;
            }

            public int ParentId
            {
                get;
                set;
            }

        }
    }
}