#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        // GET: ResourceView
        public ActionResult HistogramView()
        {
            ViewBag.datasource = GetHistogramData();
            ViewBag.histoData = GetHistogramData();
            ViewBag.resources = ResourceHistogramData.GetResourceData();
            ViewBag.historesources = ResourceHistogramData.GetResourceData();
            return View();
        }               

        public List<TaskDetails> GetHistogramData()
        {
            List<TaskDetails> tasks = new List<TaskDetails>();

            tasks.Add(new TaskDetails()
            {
                TaskID = 1,
                TaskName = "Plan timeline",
                StartDate = "10/23/2017",
                Duration = 4,
                Progress = "70"
            });

            tasks[0].SubTasks = new List<TaskDetails>();

            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 2,
                TaskName = "Plan budget",
                StartDate = "10/23/2017",
                Duration = 4,
                Progress = "80",
                ResourceID = new List<object>() { 1, 4}
            });            
            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 3,
                TaskName = "Allocate resource",
                StartDate = "10/24/2017",                
                Duration = 5,
                Progress = "65",
                ResourceID = new List<object>() { 3, 1 }
            });
            tasks[0].SubTasks.Add(new TaskDetails()
            {
                TaskID = 4,
                TaskName = "Software Specification",
                StartDate = "10/24/2017",                
                Duration = 5,
                Progress = "65",
                ResourceID = new List<object>() { 5, 4 }
            });
           

            tasks.Add(new TaskDetails()
            {
                TaskID = 5,
                TaskName = "Design",
                StartDate = "10/25/2017",
                Duration = 6,
            });

            tasks[1].SubTasks = new List<TaskDetails>();

            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 6,
                TaskName = "Get approval",
                StartDate = "10/28/2017",                
                Duration = 5,
                Progress = "60",                
                ResourceID = new List<object>() { 2 , 5 }
            });
            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 7,
                TaskName = "Testing",
                StartDate = "10/29/2017",                
                Duration = 6,
                Progress = "77",                
                ResourceID = new List<object>() { 6 , 7 }
            });
            tasks[1].SubTasks.Add(new TaskDetails()
            {
                TaskID = 8,
                TaskName = "Final Delivery",
                StartDate = "10/29/2017",
                Duration = 0,
                Progress = "77",
                ResourceID = new List<object>() { 3 }
            });
            return tasks;

        }


        public class ResourceHistogramData
        {
            public class Resources
            {
                public int ResourceID { get; set; }
                public string ResourceName { get; set; }
            }

            public static List<Resources> GetResourceData()
            {
                List<Resources> resourceDetails = new List<Resources>();

                resourceDetails.Add(new Resources() { ResourceID = 1, ResourceName = "Robert King" });
                resourceDetails.Add(new Resources() { ResourceID = 2, ResourceName = "Anne Dodsworth" });
                resourceDetails.Add(new Resources() { ResourceID = 3, ResourceName = "David william" });
                resourceDetails.Add(new Resources() { ResourceID = 4, ResourceName = "Nancy Davolio" });
                resourceDetails.Add(new Resources() { ResourceID = 5, ResourceName = "Janet Leverling" });
                resourceDetails.Add(new Resources() { ResourceID = 6, ResourceName = "Romey Wilson" });

                return resourceDetails;
            }

        }
    }
}