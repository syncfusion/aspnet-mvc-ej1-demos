#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using MVCSampleBrowser.Models;
using MVCSampleBrowser.Areas.AirlineReservation.Models;
using Syncfusion.PMML;

namespace MVCSampleBrowser.Areas.AuditShowcase.Controllers
{
    public class HomeController : Controller
    {
        // GET: AuditShowcase/AuditShowcase
        public ActionResult Index()
        {
            ViewBag.Age = "20";
            ViewBag.Income = "20000";
            ViewBag.Employment = "Private";
            ViewBag.Education = "College";
            ViewBag.Marital = "Married";
            ViewBag.Occupation = "Cleaner";
            ViewBag.Sex = "Female";
            ViewBag.Accounts = "Canada";
            ViewBag.Deduction = "10000";
            ViewBag.Hours = "12";
            return View();
        }

        [HttpPost]
        public PartialViewResult Index(int Age, string Income, string Deduction, int Hours, string Accounts, string Employment, string Education, string Sex, string Marital, string Occupation)
        {

            PMMLEvaluator evaluator = new PMMLEvaluatorFactory().
                GetPMMLEvaluatorInstance(Server.MapPath("~/App_Data/Audit.pmml"));

            var audit = new
            {
                Age = Age,
                Employment = Employment,
                Education = Education,
                Marital = Marital,
                Occupation = Occupation,
                Income = Income,
                Sex = Sex,
                Deductions = Deduction,
                Hours = Hours,
                Accounts = Accounts,
            };


            PredictedResult predictedResult = evaluator.GetResult(audit, null);

            var Adjusted = (predictedResult.PredictedValue != null) ? predictedResult.PredictedValue.ToString() : "-";
            
            if (Adjusted == "0")
            {
                ViewBag.Adjusted = Url.Content("~/Content/images/thumb_yes.png");
                ViewBag.Result = "YES!";
                ViewBag.Text = "Your audit risk is low.";
            }
            else
            {
                ViewBag.Adjusted = Url.Content("~/Content/images/thumb_no.png");
                ViewBag.Result = "NO!";
                ViewBag.Text = "Your audit risk is high.";
            }

            return PartialView("AuditResult");
        }
    }
}