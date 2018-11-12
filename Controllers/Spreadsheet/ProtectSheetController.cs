using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /ProtectSheet/

        public ActionResult ProtectSheet()
        {
            ViewBag.DataSource = GetProtectDataSource();
            return View();
        }


        public Array GetProtectDataSource()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/ProtectSheet.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
        

    }
}
