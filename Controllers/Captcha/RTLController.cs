using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.Captcha
{
    public partial class CaptchaController : Controller
    {
        
        [HttpGet]
        public ActionResult RTL()
        {
            return View();
        }

    }
}
