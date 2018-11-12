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
        // GET: /Captcha/
        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }    }
}
