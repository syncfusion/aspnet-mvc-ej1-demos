#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.PMML;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace MVCSampleBrowser.Controllers
{
    public partial class PredictiveAnalyticsController : Controller
    {
       
        // GET: NeuralNetworksImports
        public ActionResult NeuralNetworksImports()
        {
            Sample sample = new Sample();
            sample.ModelName = "Neural Networks";
            sample.Name = "Imports";
            sample.SamplePath = "\\" + sample.ModelName + "\\" + sample.Name;
            sample.SkipCount = 0;
            Session["sample"] = sample;
            LoadNeuralNetworksImportsSample(sample, null);
            return View();
        }

        [WebMethod(EnableSession = true)]
        public ActionResult GetImportsData(DataManager dm)
        {
            LoadNeuralNetworksImportsSample((Sample)Session["sample"], dm);
            DataResult data = new DataResult();
            List<Dictionary<string, object>> rows = (List<Dictionary<string, object>>)ViewBag.output;
            DataOperations dop = new DataOperations();

            data.result = dop.Execute(rows, dm);
            data.count = rows.Count;

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Method to load Samples
        /// </summary>
        /// <param name="sample">Sample values</param>
        public void LoadNeuralNetworksImportsSample(Sample sample, DataManager dataManager)
        {
            ImportsNeural.Program imports = new ImportsNeural.Program();

            var path = sample.GetParentDirectoryPath(Server.MapPath("~"));
            string samplePath = string.Format("{0}{1}\\{2}", path, sample.SamplePath, "Model\\");
            string outputPath = samplePath + "PredictedOutput.html";
            string pmmlPath = string.Format("{0}{1}.pmml", samplePath, sample.Name);
            string rScriptPath = string.Format("{0}{1}.R", samplePath, sample.Name);

            string inputPath = samplePath + "Imports.csv";
            Table inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
            Table selectedPageInputTable = sample.PagingMethod(inputTable, dataManager, dataManager != null ? dataManager.Skip : 0);
            Table outputTable = imports.PredictResult(selectedPageInputTable, pmmlPath);

            ViewBag.output = sample.serializeTable(inputTable, outputTable, dataManager != null ? dataManager.Skip : 0);

            Dictionary<string, List<string>> columnCollection = sample.GetColumnNames(inputTable, outputTable);

            ViewBag.InputColumns = columnCollection["inputColumns"];
            ViewBag.OutputColumns = columnCollection["outputColumns"];
            ViewBag.InputNumericColumns = columnCollection["inputNumericColumns"];
            ViewBag.OutputNumericColumns = columnCollection["outputNumericColumns"];

            if (System.IO.File.Exists(rScriptPath))
                ViewBag.RScript = System.IO.File.ReadAllText(rScriptPath);

            ViewBag.PMML = System.IO.File.ReadAllText(pmmlPath);
        }
    }
}
