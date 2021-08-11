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
using Newtonsoft.Json;
using Syncfusion.EJ.PdfViewer;
using System.IO;
using System.Reflection;

namespace MVCSampleBrowser.Controllers
{
    public partial class PdfViewerController : Controller
    {
        //
        // GET: /PdfViewerDefault/

        public ActionResult Default()
        {
            return View();
        }
		        [HttpPost]
        public ActionResult Load(jsonObjects results)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            var jsonResult = JsonConverterstring(results);
			//load the multiple document from client side 
            if (jsonResult.ContainsKey("newFileName"))
            {
                var name = jsonResult["newFileName"];
                var pdfName = name.ToString() + ".pdf";
                helper.Load(Helper.GetFilePath("" + pdfName));
            }
            else
            {
			//Initially load the PDF document from the data folder.
                if (jsonResult.ContainsKey("isInitialLoading"))
                {
                    helper.Load(Helper.GetFilePath("FormFillingDocument.pdf"));
                }
            }
            return Content(JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult)));
        }
        public Dictionary<string, string> JsonConverterstring(jsonObjects results)
        {
            Dictionary<string, object> resultObjects = new Dictionary<string, object>();
            resultObjects = results.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(prop => prop.Name, prop => prop.GetValue(results, null));
            var emptyObjects = (from kv in resultObjects
                                where kv.Value != null
                                select kv).ToDictionary(kv => kv.Key, kv => kv.Value);
            Dictionary<string, string> jsonResult = emptyObjects.ToDictionary(k => k.Key, k => k.Value.ToString());
            return jsonResult;
        }
        public JsonResult Download(jsonObjects result)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            var jsonResult = JsonConverterstring(result);
            if (jsonResult.ContainsKey("savedFields"))
            {
                var values = jsonResult["savedFields"];
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(values);
                jsonResult = data;
            }
            return Json(helper.GetDocumentData(jsonResult));
        }
        public ActionResult FileUpload(jsonObjects result)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            var jsonResult = JsonConverterstring(result);
            if (jsonResult.ContainsKey("uploadedFile"))
            {
                var fileurl = jsonResult["uploadedFile"];
                byte[] byteArray = Convert.FromBase64String(fileurl);
                MemoryStream stream = new MemoryStream(byteArray);
                helper.Load(stream);
            }
            return Content(JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult)));
        }

    }
	    public class jsonObjects
    {
        public string viewerAction { get; set; }
        public string pageindex { get; set; }
        public string controlId { get; set; }
        public string isInitialLoading { get; set; }
        public string id { get; set; }
        public string isPageScrolled { get; set; }
        public string Download { get; set; }
        public string uploadedFile { get; set; }
        public string newFileName { get; set; }
        public string savedFields { get; set; }
        public string enableOfflineMode { get; set; }
    }
    public class Helper
    {
        public static string GetFilePath(string path)
        {
            string _dataPath = new System.IO.DirectoryInfo(HttpContext.Current.Request.PhysicalApplicationPath
                + "..\\..\\..\\Common\\Data\\PDF").FullName;
            _dataPath += @"\" + path;
            return _dataPath;
        }
    }
}
