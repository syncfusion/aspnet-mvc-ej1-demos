using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class TabController : Controller
    {
        public ActionResult TabWizard()
        {
            ViewBag.ACData = new PlacesData().GetLocation().ToList();
            ViewBag.TrainData = new TrainsList().GetTrainDetails().ToList();
            ViewBag.PassGender = new GenDropDown().GetGenList().ToList();
            ViewBag.PassBerth = new BerthDropDown().GetBerthList().ToList();
            return View();
        }
       
    }
}