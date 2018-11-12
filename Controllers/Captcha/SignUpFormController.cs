using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers.Captcha
{
    public partial class CaptchaController : Controller
    {
        //
        // GET: /SignUp/        
        [HttpGet]
        public ActionResult SignUpForm()
        {
            ViewBag.status = false;
            ViewBag.NameStatus = true;
            ViewBag.PasswordStatus = true;
            return View();
        }

        [HttpPost]
        public ActionResult SignUpForm(FormCollection Values)
        {
            if (!string.IsNullOrEmpty(Values["username"].ToString()) && (Values["username"].ToString().Length > 3))
                ViewBag.NameStatus = true;
            else
                ViewBag.NameStatus = false;
            if  ((!string.IsNullOrEmpty(Values["password"].ToString())) && (Values["password"].ToString().Length > 3) && (Values["password"].ToString().Equals(Values["repassword"].ToString())))
               ViewBag.PasswordStatus = true;
            else
                ViewBag.PasswordStatus = false;        
            if((bool)ViewBag.NameStatus && (bool)ViewBag.PasswordStatus)
                ViewBag.status=true;
            else
                ViewBag.status=false;
            return View();
        }

        public ActionResult Refresh(CaptchaParams one)
        {
            return one.CaptchaActions();
        }
    }
}
