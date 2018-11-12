using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Models;
using System.Globalization;
using Syncfusion.JavaScript;
using MVCSampleBrowser.Models;


namespace MVCSampleBrowser.Controllers
{   
    public partial class DateTimePickerController : Controller
    {       
        public ActionResult Datetimepickerfor()
        {
            DateTimePickerProperties dtp = new DateTimePickerProperties();
            dtp.DateTimeFormat = "d/M/yyyy h:mm tt";
            ViewData["datetime"] = dtp;
            return View(new datetimepicker());

        }
        [HttpPost]
        public ActionResult Datetimepickerfor(datetimepicker model)
        {
            DateTimePickerProperties dtp = new DateTimePickerProperties();
            dtp.DateTimeFormat = "d/M/yyyy h:mm tt";
            ViewData["datetime"] = dtp;
            return View(model);

        }

    }   
}
