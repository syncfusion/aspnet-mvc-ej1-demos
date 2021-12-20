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
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class TreeViewController : Controller
    {
        //
        // GET: /TreeViewIcon/
        List<loadondemand> local = new List<loadondemand>();
        public ActionResult Icon()
        {
            local.Add(new loadondemand { id = 1, name = "Mail", hasChild = true, spriteCss = "mailicon sprite-root", expanded = true });
            local.Add(new loadondemand { id = 2, pid = 1, name = "Inbox", spriteCss = "mailicon sprite-inbox", hasChild = true });
            local.Add(new loadondemand { id = 3, pid = 2, name = "Development", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 4, pid = 2, name = "Supports", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 5, pid = 2, name = "HR Team", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 6, pid = 1, name = "Drafts", spriteCss = "mailicon sprite-drafts", hasChild = true });
            local.Add(new loadondemand { id = 7, pid = 6, name = "Support template", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 8, pid = 6, name = "Personal", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 9, pid = 1, name = "Sent items", spriteCss = "mailicon sprite-sentitems", hasChild = true });
            local.Add(new loadondemand { id = 10, pid = 9, name = "Support", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 11, pid = 1, name = "Deleted", spriteCss = "mailicon sprite-deleted", hasChild = true });
            local.Add(new loadondemand { id = 12, pid = 1, name = "Junk mail", spriteCss = "mailicon sprite-junk", hasChild = true });
            local.Add(new loadondemand { id = 13, pid = 1, name = "Personal", spriteCss = "mailicon sprite-folders", hasChild = true });
            local.Add(new loadondemand { id = 14, pid = 13, name = "HR Team", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 15, pid = 13, name = "My Works", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 16, pid = 13, name = "Login Details", spriteCss = "mailicon sprite-folder" });

            local.Add(new loadondemand { id = 17, name = "Calendar", spriteCss = "mailicon sprite-calendar", hasChild = true });
            local.Add(new loadondemand { id = 18, pid = 17, name = "My Calendar", spriteCss = "mailicon sprite-calendar" });
            local.Add(new loadondemand { id = 19, pid = 17, name = "Team", spriteCss = "mailicon sprite-calendar" });
            local.Add(new loadondemand { id = 20, pid = 17, name = "Others", spriteCss = "mailicon sprite-calendar" });

            local.Add(new loadondemand { id = 21, name = "Notes", spriteCss = "mailicon sprite-notes", hasChild = true });
            local.Add(new loadondemand { id = 22, pid = 21, name = "My Reference", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 23, pid = 21, name = "Team Meeting", spriteCss = "mailicon sprite-folder" });
            local.Add(new loadondemand { id = 24, pid = 21, name = "Others", spriteCss = "mailicon sprite-folder" });

            local.Add(new loadondemand { id = 25, name = "Contacts", spriteCss = "mailicon sprite-contacts", hasChild = true });
            local.Add(new loadondemand { id = 26, pid = 25, name = "Suggested ", spriteCss = "mailicon sprite-contacts" });
            local.Add(new loadondemand { id = 27, pid = 25, name = "My Team", spriteCss = "mailicon sprite-contacts" });
            local.Add(new loadondemand { id = 28, pid = 25, name = "Others", spriteCss = "mailicon sprite-contacts" });         
            ViewBag.datasource = local;
            return View();
        }

    }
}
