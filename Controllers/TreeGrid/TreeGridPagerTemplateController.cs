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
        // GET: /TreeGridPagerTemplate/
        public ActionResult TreeGridPagerTemplate()
        {
            var DataSource = GetTreeGridPagerTemplateData();
            ViewBag.datasource = DataSource;
            return View();
        }

        private List<PagingTemplateData> GetTreeGridPagerTemplateData()
        {
            List<PagingTemplateData> PagingTemplateDataCollection = new List<PagingTemplateData>();
            
            var x = 0;
            var c = "";
            for (var i = 1; i < 10; i++)
            {
                PagingTemplateData Record1 = null;
                Record1 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Planning" + " " + (c),
                    StartDate = "02/03/2017",
                    EndDate = "02/07/2017",
                    Progress = 100,
                    Duration = 5,
                    Priority = "Normal",
                    Approved = false,
                    Children = new List<PagingTemplateData>(),
                };

                PagingTemplateData Child1 = new PagingTemplateData()
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

                PagingTemplateData Child2 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Plan budget" + " " + (c),
                    StartDate = "02/03/2017",
                    EndDate = "02/07/2017",
                    Duration = 5,
                    Progress = 100,
                    Approved = true
                };

                PagingTemplateData Child3 = new PagingTemplateData()
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

                PagingTemplateData Child4 = new PagingTemplateData()
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

                PagingTemplateData Record2 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Design" + " " + (c),
                    StartDate = "02/10/2017",
                    EndDate = "02/14/2017",
                    Progress = 86,
                    Duration = 3,
                    Priority = "High",
                    Approved = false,
                    Children = new List<PagingTemplateData>(),
                };

                PagingTemplateData Child5 = new PagingTemplateData()
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

                PagingTemplateData Child6 = new PagingTemplateData()
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

                PagingTemplateData Child7 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Get approval from customer" + " " + (c),
                    StartDate = "02/13/2017",
                    EndDate = "02/14/2017",
                    Duration = 2,
                    Progress = 100,
                    Approved = true
                };

                PagingTemplateData Child8 = new PagingTemplateData()
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
                PagingTemplateData Record3 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Implementation Phase" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/17/2017",
                    Priority = "Normal",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingTemplateData>(),
                };

                PagingTemplateData Record4 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Phase I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "High",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingTemplateData>(),
                };
                PagingTemplateData Record7 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Implementation Module I" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "Normal",
                    Duration = 11,
                    Approved = false,
                    Children = new List<PagingTemplateData>(),
                };
                PagingTemplateData Child9 = new PagingTemplateData()
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
                PagingTemplateData Child10 = new PagingTemplateData()
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
                PagingTemplateData Child11 = new PagingTemplateData()
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
                PagingTemplateData Child12 = new PagingTemplateData()
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
                PagingTemplateData Child13 = new PagingTemplateData()
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
                PagingTemplateData Child14 = new PagingTemplateData()
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
                PagingTemplateData Record5 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Phase II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/28/2017",
                    Children = new List<PagingTemplateData>(),
                    Priority = "High",
                    Approved = false,
                    Duration = 12,
                };
                PagingTemplateData Record8 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Implementation Module II" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/28/2017",
                    Priority = "Critical",
                    Approved = false,
                    Duration = 12,
                    Children = new List<PagingTemplateData>(),
                };
                PagingTemplateData Child15 = new PagingTemplateData()
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
                PagingTemplateData Child16 = new PagingTemplateData()
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
                PagingTemplateData Child17 = new PagingTemplateData()
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
                PagingTemplateData Child18 = new PagingTemplateData()
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
                PagingTemplateData Child19 = new PagingTemplateData()
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
                PagingTemplateData Child20 = new PagingTemplateData()
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
                PagingTemplateData Record6 = new PagingTemplateData()
                {
                    TaskId = ++x,
                    TaskName = "Phase III" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "Normal",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingTemplateData>(),
                };
                PagingTemplateData Record9 = new PagingTemplateData()
                {
                    TaskId = 22,
                    TaskName = "Implementation Module III" + " " + (c),
                    StartDate = "02/17/2017",
                    EndDate = "02/27/2017",
                    Priority = "High",
                    Approved = false,
                    Duration = 11,
                    Children = new List<PagingTemplateData>(),
                };
                PagingTemplateData Child21 = new PagingTemplateData()
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
                PagingTemplateData Child22 = new PagingTemplateData()
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
                PagingTemplateData Child23 = new PagingTemplateData()
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
                PagingTemplateData Child24 = new PagingTemplateData()
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
                PagingTemplateData Child25 = new PagingTemplateData()
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
                PagingTemplateData Child26 = new PagingTemplateData()
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
                PagingTemplateDataCollection.Add(Record1);
                PagingTemplateDataCollection.Add(Record2);
                PagingTemplateDataCollection.Add(Record3);
                c = i.ToString();
            }
            return PagingTemplateDataCollection;
        }


        public class PagingTemplateData
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

            public List<PagingTemplateData> Children
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