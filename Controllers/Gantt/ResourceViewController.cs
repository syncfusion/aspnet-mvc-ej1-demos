#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
        public ActionResult ResourceView()
        {
            ViewBag.datasource = GetResourceGanttData();
            ViewBag.resources = new ResourceGanttResources().GetResources();
            ViewBag.groups = new ResourceGroupDetails().GetResourceGroups();
            return View();
        }

        public class ResourceGanttResources
        {
            public string ResourceName { get; set; }
            public int ResourceId { get; set; }
            public int TeamId { get; set; }
            public List<ResourceGanttResources> GetResources()
            {
                List<ResourceGanttResources> data = new List<ResourceGanttResources>(){
                    new ResourceGanttResources(){ ResourceId = 1, ResourceName = "Anne Dodsworth",TeamId=1 },
                    new ResourceGanttResources(){ ResourceId = 2, ResourceName = "David William", TeamId=1},
                    new ResourceGanttResources(){ ResourceId = 3, ResourceName = "Nancy Davolio", TeamId=2},
                    new ResourceGanttResources(){ ResourceId = 4, ResourceName = "Janet Leverling", TeamId=2},
                    new ResourceGanttResources(){ ResourceId = 5, ResourceName = "Romey Wilson", TeamId=2},
                    new ResourceGanttResources(){ ResourceId = 6, ResourceName = "Michael Suyama", TeamId=3}
                };
                return data;
            }
        }

        public class ResourceGroupDetails
        {
            public string TeamName { get; set; }
            public int TeamId { get; set; }
            public List<ResourceGroupDetails> GetResourceGroups()
            {
                List<ResourceGroupDetails> data = new List<ResourceGroupDetails>(){
                    new ResourceGroupDetails(){ TeamName="Planning Team", TeamId=1},
                    new ResourceGroupDetails(){ TeamName="Developement Team", TeamId=2},
                    new ResourceGroupDetails(){ TeamName="Testing Team", TeamId=3}
                };
                return data;
            }
        }

        public List<TaskDetails> GetResourceGanttData()
        {
            List<TaskDetails> data = new List<TaskDetails>() {
             new TaskDetails() { TaskID = 1, TaskName= "Plan timeline", StartDate= "02/06/2017", EndDate = "02/10/2017", Duration= 5, Progress= "50", ResourceID= new List<object>(){1}},
             new TaskDetails() { TaskID= 2, TaskName= "Plan budget", StartDate= "02/13/2017", EndDate= "02/17/2017", Duration= 5, Progress= "50", ResourceID= new List<object>(){1}},
             new TaskDetails() { TaskID= 3, TaskName= "Allocate resources", StartDate= "02/20/2017", EndDate= "02/24/2017", Duration= 5, Progress= "0", ResourceID= new List<object>(){1}},
             new TaskDetails() { TaskID= 4, TaskName= "Software Specification", StartDate= "02/10/2017", EndDate= "02/12/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){2} },
             new TaskDetails() { TaskID= 5, TaskName= "Develop prototype", StartDate= "02/10/2017", EndDate= "02/12/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){2}},
             new TaskDetails() { TaskID= 6, TaskName= "Get approval from customer", StartDate= "02/13/2017", EndDate= "02/14/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){2}},
             new TaskDetails() { TaskID= 7, TaskName= "Development Task 1", StartDate= "02/17/2017", EndDate= "02/21/2017", Duration= 5, Progress= "0", ResourceID= new List<object>(){3}},
             new TaskDetails() { TaskID= 8, TaskName= "Testing", StartDate= "02/20/2017", EndDate= "02/24/2017", Duration= 5, Progress= "0", ResourceID= new List<object>(){3}},
             new TaskDetails() { TaskID= 9, TaskName= "Bug fix", StartDate= "02/17/2017", EndDate= "03/02/2017", Duration= 5, Progress= "0", ResourceID= new List<object>(){3}},
             new TaskDetails() { TaskID= 10, TaskName= "Development Task 2", StartDate= "02/17/2017", EndDate= "02/21/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){4}},
             new TaskDetails() { TaskID= 11, TaskName= "Testing", StartDate= "02/20/2017", EndDate= "02/24/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){4}},
             new TaskDetails() { TaskID= 12, TaskName= "Bug fix", StartDate= "02/17/2017", EndDate= "03/02/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){4}},
             new TaskDetails() { TaskID= 13, TaskName= "Development Task 3", StartDate= "02/17/2017", EndDate= "02/21/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){5}},
             new TaskDetails() { TaskID= 14, TaskName= "Testing", StartDate= "02/20/2017", EndDate= "02/24/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){5}},
             new TaskDetails() { TaskID= 15, TaskName= "Bug fix", StartDate= "02/17/2017", EndDate= "03/02/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){5}},
             new TaskDetails() { TaskID= 16, TaskName= "Integration", StartDate= "02/27/2017", EndDate= "03/05/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){6} },
             new TaskDetails() { TaskID= 17, TaskName= "Final Testing", StartDate=  "03/02/2017", EndDate= "03/07/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){6}},
             new TaskDetails() { TaskID= 18, TaskName= "Final Delivery", StartDate= "03/09/2017", EndDate= "03/12/2017", Duration= 5, Progress= "0",ResourceID= new List<object>(){6}}
            };
            return data;
        }
    }
}