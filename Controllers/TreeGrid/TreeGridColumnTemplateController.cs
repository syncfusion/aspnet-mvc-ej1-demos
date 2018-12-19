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
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridColumnTemplate/

        public ActionResult TreeGridColumnTemplate()
        {
            var data=this.GetColumnTemplateDataSource();
            ViewBag.datasource = data;
            return View();
        }


        private List<ColumnTemplate> GetColumnTemplateDataSource()
        {
            List<ColumnTemplate> TreeGridCollection = new List<ColumnTemplate>();
                       
            ColumnTemplate ParentRecord = null;

            ParentRecord = new ColumnTemplate()
            {
                Name = "Local Disk (C:)",
                DateModified = "06/26/2017",
                Type = "File Folder",
                DateCreated = "06/16/2017",
                Children = new List<ColumnTemplate>()
            };

            ColumnTemplate ParentRecord1 = new ColumnTemplate()
            {
                Name = "Users",
                DateModified = "06/26/2017",
                Type = "File Folder",
                DateCreated = "06/16/2017",
                Children = new List<ColumnTemplate>()
            };

            ColumnTemplate ParentRecord2 = new ColumnTemplate()
            {
                Name = "Documents",
                DateModified = "06/26/2017",
                Type = "File Folder",
                DateCreated = "06/16/2017",
                Children = new List<ColumnTemplate>()
            };

            ColumnTemplate ParentRecord3 = new ColumnTemplate()
            {
                Name = "My Web Sites",
                DateModified = "06/26/2017",
                Type = "File Folder",
                DateCreated = "06/16/2017",
                Children = new List<ColumnTemplate>()
            };
            ColumnTemplate ChildRecord1 = new ColumnTemplate()
            {
                Name = "Home.html",
                DateModified = "06/26/2017",
                Type = "HTML document",
                DateCreated = "06/16/2017",
            };
            ColumnTemplate ChildRecord2 = new ColumnTemplate()
            {
                Name = "Login.html",
                DateModified = "06/26/2017",
                Type = "HTML document",
                DateCreated = "06/16/2017",
            };
            ColumnTemplate ChildRecord3 = new ColumnTemplate()
            {
                Name = "Account.html",
                DateModified = "06/26/2017",
                Type = "HTML document",
                DateCreated = "06/16/2017",
            };

            ParentRecord3.Children.Add(ChildRecord1);
            ParentRecord3.Children.Add(ChildRecord2);
            ParentRecord3.Children.Add(ChildRecord3);

            ParentRecord2.Children.Add(ParentRecord3);
            ParentRecord1.Children.Add(ParentRecord2);
            ParentRecord.Children.Add(ParentRecord1);

            TreeGridCollection.Add(ParentRecord);
            return TreeGridCollection;
        }


        public class ColumnTemplate
        {
            public string Name
            {
                get;
                set;
            }

            public string DateModified
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }

            public string DateCreated
            {
                get;
                set;
            }

            public List<ColumnTemplate> Children
            {
                get;
                set;
            }

        }
    }
}
