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
using Syncfusion.JavaScript;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class FileExplorerController : Controller
    {
        // GET: CustomContextMenu
        public ActionResult CustomContextMenu()
        {
            return View();
        }
        public ActionResult FileActionContextMenu(FileExplorerParams args)
        {
            try
            {
                FileExplorerOperations opeartion = new FileExplorerOperations();
                if (args.ActionType != "Paste" && args.ActionType != "GetDetails")
                {
                    var FilePath = opeartion.GetPhysicalPath(opeartion.ToAbsolute(args.Path));
                    if (!FilePath.ToLower().Contains("fileexplorercontent"))
                        throw new ArgumentException("'" + FilePath + "' is not accessible. Access is denied.");
                }
                switch (args.ActionType)
                {
                    case "Read":
                        return Json(opeartion.Read(args.Path, args.ExtensionsAllow));
                    //case "CreateFolder":
                    //    return Json(opeartion.CreateFolder(args.Path, args.Name));
                    //case "Paste":
                    //    return Json(opeartion.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles));
                    //case "Remove":
                    //    return Json(opeartion.Remove(args.Names, args.Path));
                    //case "Rename":
                    //    return Json(opeartion.Rename(args.Path, args.Name, args.NewName, args.CommonFiles));
                    case "GetDetails":
                        return Json(opeartion.GetDetails(args.Path, args.Names));
                    case "Download":
                        opeartion.Download(args.Path, args.Names);
                        break;
                    //case "Upload":
                    //    opeartion.Upload(args.FileUpload, args.Path);
                    //    break;
                    case "Search":
                        return Json(opeartion.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive));
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
    }
}