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
    public partial class TimePickerController : Controller
    {        
        public ActionResult TimePickerFor()
        {         
            return View(new timepicker());
        }
        [HttpPost]
        public ActionResult TimePickerFor(timepicker model)
        {           
            return View(model);
        }

    }
   
}
