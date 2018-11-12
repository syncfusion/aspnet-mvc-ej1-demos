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
