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

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridColumnFiltering/

        public ActionResult TreeGridColumnFiltering()
        {
            ViewBag.datasource = this.GetDefaultData();
            StageDetails stages = new StageDetails();
            ViewBag.dropData = stages.GetStageCollection();
            StateDetails state = new StateDetails();
            ViewBag.stateData = state.GetStateCollection();
            return View();
        }
        
    }
    public class Stage
    {
        public int id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
    public class StageDetails
    {
        public List<Stage> GetStageCollection()
        {
            List<Stage> stageCollection = new List<Stage>();

            stageCollection.Add(new Stage() { id = 1, text = "Low", value = "Low" });
            stageCollection.Add(new Stage() { id = 2, text = "Normal", value = "Normal" });
            stageCollection.Add(new Stage() { id = 3, text = "High", value = "High" });
            stageCollection.Add(new Stage() { id = 4, text = "Critical", value = "Critical" });
            return stageCollection;
        }
    }
    public class State
    {
        public int id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
    public class StateDetails
    {
        public List<State> GetStateCollection()
        {
            List<State> stateCollection = new List<State>();

            stateCollection.Add(new State() { id = 1, text = "Yes", value = "true" });
            stateCollection.Add(new State() { id = 2, text = "No", value = "false" });           
            return stateCollection;
        }
    }
}
