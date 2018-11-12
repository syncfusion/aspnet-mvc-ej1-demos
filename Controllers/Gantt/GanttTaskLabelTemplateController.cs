using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        // GET: GanttTaskLabelTemplate
        public ActionResult GanttTaskLabelTemplate()
        {
            var DataSource = GetTaskLabelData();
            ViewBag.datasource = DataSource;
            var DataSource1 = TaskLabelData.GetTaskLabelResourceData();
            ViewBag.datasource1 = DataSource1;
            return View();
        }
        public class TaskLabelDetails
        {
            public int TaskID { get; set; }
            public string TaskName { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int Duration { get; set; }
            public string Progress { get; set; }
            public List<TaskLabelDetails> SubTasks { get; set; }
            public List<object> ResourceID { get; set; }
            public string Predecessors { get; set; }
        }
        public List<TaskLabelDetails> GetTaskLabelData()
        {
            List<TaskLabelDetails> tasks = new List<TaskLabelDetails>();

            tasks.Add(new TaskLabelDetails()
            {
                TaskID = 1,
                TaskName = "Project Schedule",
                StartDate = "02/06/2017",
                EndDate = "03/10/2017"
            });

            tasks[0].SubTasks = new List<TaskLabelDetails>();

            tasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 2,
                TaskName = "Planning",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017"
            });

            tasks[0].SubTasks[0].SubTasks = new List<TaskLabelDetails>();


            tasks[0].SubTasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 3,
                TaskName = "Plan timeline",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "100",
                ResourceID = new List<object>() { 1, 3 }
            });
            tasks[0].SubTasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 4,
                TaskName = "Plan budget",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "100",
                ResourceID = new List<object>() { 5 }
            });
            tasks[0].SubTasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 5,
                TaskName = "Allocate TaskLabelResources",
                StartDate = "02/06/2017",
                EndDate = "02/10/2017",
                Duration = 5,
                Progress = "100",
                ResourceID = new List<object>() { 6, 2 }
            });
            tasks[0].SubTasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 6,
                TaskName = "Planning complete",
                StartDate = "02/10/2017",
                EndDate = "02/10/2017",
                Duration = 0,
                Predecessors = "3FS,4FS,5FS",
                ResourceID = new List<object>() { 1 }
            });

            tasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 7,
                TaskName = "Design",
                StartDate = "02/13/2017",
                EndDate = "02/17/2017"
            });

            tasks[0].SubTasks[1].SubTasks = new List<TaskLabelDetails>();

            tasks[0].SubTasks[1].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 8,
                TaskName = "Software Specification",
                StartDate = "02/13/2017",
                EndDate = "02/15/2017",
                Duration = 3,
                Progress = "60",
                Predecessors = "6FS",
                ResourceID = new List<object>() { 2, 5 }
            });
            tasks[0].SubTasks[1].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 9,
                TaskName = "Develop prototype",
                StartDate = "02/13/2017",
                EndDate = "02/15/2017",
                Duration = 3,
                Progress = "100",
                Predecessors = "6FS",
                ResourceID = new List<object>() { 3, 2 }
            });
            tasks[0].SubTasks[1].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 10,
                TaskName = "Get approval from customer",
                StartDate = "02/16/2017",
                EndDate = "02/17/2017",
                Duration = 2,
                Progress = "100",
                Predecessors = "9FS",
                ResourceID = new List<object>() { 1 }
            });
            tasks[0].SubTasks[1].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 11,
                TaskName = "Design complete",
                StartDate = "02/17/2017",
                EndDate = "02/17/2017",
                Duration = 0,
                Predecessors = "10FS",
                ResourceID = new List<object>() { 2 }
            });


            tasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 12,
                TaskName = "Implementation",
                StartDate = "02/20/2017",
                EndDate = "03/02/2017"
            });

            tasks[0].SubTasks[2].SubTasks = new List<TaskLabelDetails>();

            tasks[0].SubTasks[2].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 13,
                TaskName = "Development Task 1",
                StartDate = "02/20/2017",
                EndDate = "02/22/2017",
                Duration = 3,
                Progress = "50",
                Predecessors = "11FS",
                ResourceID = new List<object>() { 3, 5 }
            });

            tasks[0].SubTasks[2].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 14,
                TaskName = "Development Task 2",
                StartDate = "02/20/2017",
                EndDate = "02/22/2017",
                Duration = 3,
                Progress = "50",
                Predecessors = "11FS",
                ResourceID = new List<object>() { 3 }
            });


            tasks[0].SubTasks[2].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 15,
                TaskName = "Testing",
                StartDate = "02/23/2017",
                EndDate = "02/24/2017",
                Duration = 2,
                Progress = "0",
                Predecessors = "13FS,14FS",
                ResourceID = new List<object>() { 4, 1 }
            });
            tasks[0].SubTasks[2].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 16,
                TaskName = "Bug fix",
                StartDate = "02/27/2017",
                EndDate = "02/28/2017",
                Duration = 2,
                Progress = "0",
                Predecessors = "15FS",
                ResourceID = new List<object>() { 3 }
            });
            tasks[0].SubTasks[2].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 17,
                TaskName = "Customer review meeting",
                StartDate = "02/28/2017",
                EndDate = "03/02/2017",
                Duration = 2,
                Progress = "0",
                Predecessors = "16FS",
                ResourceID = new List<object>() { 1 }
            });
            tasks[0].SubTasks[2].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 18,
                TaskName = "Implemenation complete",
                StartDate = "03/02/2017",
                EndDate = "03/02/2017",
                Duration = 0,
                Predecessors = "17FS",
                ResourceID = new List<object>() { 2, 5 }
            });

            tasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 19,
                TaskName = "Integration",
                StartDate = "03/06/2017",
                EndDate = "03/08/2017",
                Duration = 2,
                Progress = "0",
                Predecessors = "18FS",
                ResourceID = new List<object>() { 3 }
            });
            tasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 20,
                TaskName = "Final Testing",
                StartDate = "03/09/2017",
                EndDate = "03/10/2017",
                Duration = 2,
                Progress = "0",
                Predecessors = "19FS",
                ResourceID = new List<object>() { 4 }
            });
            tasks[0].SubTasks.Add(new TaskLabelDetails()
            {
                TaskID = 21,
                TaskName = "Final Delivery",
                StartDate = "03/10/2017",
                EndDate = "03/10/2017",
                Duration = 0,
                Predecessors = "20FS",
                ResourceID = new List<object>() { 1 }
            });

            return tasks;

        }


        public class TaskLabelData
        {
            public class TaskLabelResources
            {
                public int ResourceID { get; set; }
                public string ResourceName { get; set; }
            }

            public static List<TaskLabelResources> GetTaskLabelResourceData()
            {
                List<TaskLabelResources> resourceDetails = new List<TaskLabelResources>();

                resourceDetails.Add(new TaskLabelResources() { ResourceID = 1, ResourceName = "Robert King" });
                resourceDetails.Add(new TaskLabelResources() { ResourceID = 2, ResourceName = "Anne Dodsworth" });
                resourceDetails.Add(new TaskLabelResources() { ResourceID = 3, ResourceName = "David William" });
                resourceDetails.Add(new TaskLabelResources() { ResourceID = 4, ResourceName = "Nancy Davolio" });
                resourceDetails.Add(new TaskLabelResources() { ResourceID = 5, ResourceName = "Janet Leverling" });
                resourceDetails.Add(new TaskLabelResources() { ResourceID = 6, ResourceName = "Romey Wilson" });

                return resourceDetails;
            }

        }
    }
}