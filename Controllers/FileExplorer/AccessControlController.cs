#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class FileExplorerController : Controller
    {
        // GET: AccessControl
        public ActionResult AccessControl(string selectRole)
        {
            if (selectRole == null)
                Session["Role"] = "Administrator";
            else
                Session["Role"] = selectRole;
            ViewBag.Role = Session["Role"];
            return View();
        }
        public ActionResult FileAccessDefault(FileExplorerParams args)
        {
            try
            {
                FileAccessOperations operation = new FileAccessOperations(GetRules());
                if (args.ActionType != "Paste" && args.ActionType != "GetDetails")
                {
                    FileExplorerOperations opeartion = new FileExplorerOperations();
                    var FilePath = opeartion.GetPhysicalPath(opeartion.ToAbsolute(args.Path));
                    if (!FilePath.ToLower().Contains("filecontent"))
                        throw new ArgumentException("'" + FilePath + "' is not accessible. Access is denied.");
                }
                switch (args.ActionType)
                {
                    case "Read":
                        return Json(operation.Read(args.Path, args.ExtensionsAllow));
                    //case "CreateFolder":
                    //    return Json(operation.CreateFolder(args.Path, args.Name));
                    //case "Paste":
                    //    return Json(operation.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles));
                    //case "Remove":
                    //    return Json(operation.Remove(args.Names, args.Path));
                    //case "Rename":
                    //    return Json(operation.Rename(args.Path, args.Name, args.NewName, args.CommonFiles));
                    case "GetDetails":
                        return Json(operation.GetDetails(args.Path, args.Names));
                    case "Download":
                        operation.Download(args.Path, args.Names);
                        break;
                    //case "Upload":
                    //    operation.Upload(args.FileUpload, args.Path);
                    //    break;
                    case "Search":
                        return Json(operation.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive));
                    //provide restriction to modify data in our online samples
                    default:
                        return new HttpStatusCodeResult(403, "Restricted to modify data in online demo.");
                        
                }
                return Json("");
            }
            catch (Exception e)
            {
                FileExplorerResponse Response = new FileExplorerResponse();
                Response.error = e.GetType().FullName + ", " + e.Message;
                return Json(Response);
            }
        }
        public FileAccessInfo GetRules()
        {
            FileAccessInfo rules = new FileAccessInfo();
            List<AccessRule> accessRules = new List<AccessRule> {
                // For Default User
                new AccessRule { Path = "*.*", Role = "Default User", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny },
                new AccessRule { Path = "*", Role = "Default User", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                new AccessRule { Path = "", Role = "Default User", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                // For Administrator
                new AccessRule { Path = "*.*", Role = "Administrator", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, Download = Permission.Allow },
                new AccessRule { Path = "*", Role = "Administrator", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
                new AccessRule { Path = "", Role = "Administrator", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
                // For Document Manager
                new AccessRule { Path = "*.*", Role = "Document Manager", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny },
                new AccessRule { Path = "Documents/*.*", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, Download = Permission.Allow },
                new AccessRule { Path = "*", Role = "Document Manager", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                new AccessRule { Path = "", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                new AccessRule { Path = "Documents", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
                new AccessRule { Path = "Documents/*", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
            };
            rules.Rules = accessRules;
            rules.Role = Session["Role"].ToString();
            rules.RootPath = "~/FileContent/";
            return rules;
        }
    }
}