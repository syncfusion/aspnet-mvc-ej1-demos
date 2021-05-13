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

namespace MVCSampleBrowser.Error
{
    public class ErrorHandlerController : Controller
    {
        public ActionResult CommonError(string ErrorMsg, string StackTrace)
        {
            ViewBag.Msg = ErrorMsg;
            ViewBag.Trace = StackTrace;
            return View();
        }
        public ActionResult PageError(string ExUrl)
        {
            ViewBag.Msg = ExUrl;     
            return View();
        }
        public ActionResult DatabaseError(string ErrorMsg, string StackTrace)
        {
            ViewBag.Msg = ErrorMsg;
            ViewBag.Trace = StackTrace;
            return View();
        }
    }
}
