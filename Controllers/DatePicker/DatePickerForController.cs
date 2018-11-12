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
   
    public partial class DatePickerController : Controller
    {
       
        public ActionResult Datepickerfor()
        {
            DatePickerProperties datemodel = new DatePickerProperties();

            datemodel.DateFormat = "MM/dd/yyyy";
            ViewData["date"] = datemodel;
            return View(new datepicker());

        }
        [HttpPost]
        public ActionResult DatePickerFor(datepicker model)
        {
            DatePickerProperties datemodel = new DatePickerProperties();
            datemodel.DateFormat = "MM/dd/yyyy";
            ViewData["date"] = datemodel;
            return View(model);
        }

    }
    
}
