#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /LoadOnDemand/

        public ActionResult LoadOnDemand()
        {
            System.Web.HttpContext.Current.Session["Appointments"] = null;
            return View();
        }
        public ActionResult GetRecords(string CurrentView, DateTime CurrentDate, string CurrentAction)
        {
            var data = AppointmentRepository.FilterAppointment(CurrentDate, CurrentAction, CurrentView);
            BatchDataResult result = new BatchDataResult();
            result.result = data;
            result.count =AppointmentRepository.GetAllRecords().ToList().Count > 0 ? AppointmentRepository.GetAllRecords().ToList().Max(p => p.Id):1;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public class BatchDataResult
        {
            public IEnumerable result { get; set; }
            public int count { get; set; }
        }
        public ActionResult CrudResult(ResultParams param)
        {
            DefaultSchedule result = new DefaultSchedule();
            if (param.action == "insert" || (param.action == "batch" && param.added != null))
            {
                var value = param.action == "insert" ? param.value : param.added[0];
                result = AppointmentRepository.Insert(value);
            }
            if ((param.action == "batch" && param.deleted != null) || param.action == "remove")
            {
                if (param.action == "remove")
                    result = AppointmentRepository.Remove(Convert.ToInt32(param.key));
                else
                {
                    foreach (var dele in param.deleted)
                        result = AppointmentRepository.Remove(Convert.ToInt32(dele.Id));
                }
            }
            if ((param.action == "batch" && param.changed != null) || param.action == "update")
            {
                var value = param.action == "update" ? param.value : param.changed[0];
                result = AppointmentRepository.Update(value);
            }
            return Json(result, JsonRequestBehavior.AllowGet);

        }

    }
}
