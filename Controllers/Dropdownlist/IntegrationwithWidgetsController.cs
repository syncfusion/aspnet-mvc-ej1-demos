using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class DropdownlistController : Controller
    {
        //
        // GET: /IntegrationwithWidgets/
        List<TreeDropDown> employ = new List<TreeDropDown>();
        public ActionResult IntegrationwithWidgets()
        {
            employ.Add(new TreeDropDown { id = 1, name = "Mail", hasChild = true, expanded = true });
            employ.Add(new TreeDropDown { id = 2, pid = 1, name = "Inbox",hasChild = true });
            employ.Add(new TreeDropDown { id = 3, pid = 2, name = "Development" });
            employ.Add(new TreeDropDown { id = 4, pid = 2, name = "Supports" });
            employ.Add(new TreeDropDown { id = 5, pid = 2, name = "HR Team" });
            employ.Add(new TreeDropDown { id = 6, pid = 1, name = "Drafts", hasChild = true });
            employ.Add(new TreeDropDown { id = 7, pid = 6, name = "Support temploylate"});
            employ.Add(new TreeDropDown { id = 9, pid = 1, name = "Sent items", hasChild = true });
            employ.Add(new TreeDropDown { id = 10, pid = 9, name = "Support"});
            employ.Add(new TreeDropDown { id = 11, pid = 1, name = "Deleted", hasChild = true });
            employ.Add(new TreeDropDown { id = 12, pid = 1, name = "Junk mail", hasChild = true });
            employ.Add(new TreeDropDown { id = 13, pid = 1, name = "Personal", hasChild = true });

            employ.Add(new TreeDropDown { id = 15, pid = 13, name = "My Works" });
            employ.Add(new TreeDropDown { id = 16, pid = 13, name = "Login Details" });

            employ.Add(new TreeDropDown { id = 17, name = "Calendar", hasChild = true });
            employ.Add(new TreeDropDown { id = 18, pid = 17, name = "My Calendar"});
            employ.Add(new TreeDropDown { id = 19, pid = 17, name = "Team" });
            employ.Add(new TreeDropDown { id = 20, pid = 17, name = "Others" });

            employ.Add(new TreeDropDown { id = 21, name = "Notes", hasChild = true });
            employ.Add(new TreeDropDown { id = 22, pid = 21, name = "My Reference"});
            employ.Add(new TreeDropDown { id = 23, pid = 21, name = "Team Meeting" });
            employ.Add(new TreeDropDown { id = 24, pid = 21, name = "Others" });

            employ.Add(new TreeDropDown { id = 25, name = "Contacts", hasChild = true });
            employ.Add(new TreeDropDown { id = 26, pid = 25, name = "Suggested " });
            employ.Add(new TreeDropDown { id = 27, pid = 25, name = "My Team"});
            employ.Add(new TreeDropDown { id = 28, pid = 25, name = "Others"});
            ViewBag.datasource = employ;
            return View();
        }

    }
}
