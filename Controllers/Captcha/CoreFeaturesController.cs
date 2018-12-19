#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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


namespace MVCSampleBrowser.Controllers.Captcha
{
    public partial class CaptchaController : Controller
    {
        private Dictionary<string, HatchStyle> hatchList;

        // GET: /Core Features/
        [HttpGet]
        public ActionResult CoreFeatures()
        {
            LoadValues();
            return View();
        }
        [HttpPost]
        public ActionResult SuccessMessage()
        {
            return View();
        }
        private int GetIndex( Dictionary<string, HatchStyle> sample,string value)
        {
            int state = 0;
            foreach (var temp in sample.Values)
            {                
                if (temp.ToString() == value)
                    break;
                state = state + 1;
            }
            return state;
        }
        private void LoadValues()
        {
            hatchList = new Dictionary<string, HatchStyle>();
            hatchList.Add("BackwardDiagonal", HatchStyle.BackwardDiagonal);
            hatchList.Add("DarkDownwardDiagonal", HatchStyle.DarkDownwardDiagonal);
            hatchList.Add("DarkHorizontal", HatchStyle.DarkHorizontal);
            hatchList.Add("DarkUpwardDiagonal", HatchStyle.DarkUpwardDiagonal);
            ViewBag.data = hatchList.Keys.ToList<string>();
        }
        [HttpPost]
        public ActionResult CoreFeatures(string styles, string charset1, string maxset)
        {
            LoadValues();
            if (string.IsNullOrEmpty(styles))
                ViewBag.hatch = hatchList["BackwardDiagonal"];
            else
            {
                ViewBag.hatch = hatchList[styles];
                ViewBag.selectedIndex = GetIndex(hatchList, styles);
            }
            if (string.IsNullOrEmpty(charset1))
                ViewBag.characterset = "ABCDEFGHIJ1234";
            else
                ViewBag.characterset = charset1;
            if (string.IsNullOrEmpty(maxset))
                ViewBag.maximumlength = "4";
            else
                ViewBag.maximumlength = maxset;
            return View();
        }
    }
}
