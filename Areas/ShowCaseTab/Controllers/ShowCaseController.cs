#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using System.Xml.Linq;
using MVCSampleBrowser.Helpers;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Areas.ShowCaseTab.Controllers
{

    public class ShowCaseController : Controller
    {
        //
        // GET: /ShowCaseTab/ShowCase/

        public ActionResult Index(string file,string areaname)
        {
            if (!String.IsNullOrEmpty(areaname))
                return View();
            return new SourceTabActionResult(file, "false");
        }

    }

    public static class ShowCaseCodeHelper
    {

        public static string RenderShowCaseCodeTab(this System.Web.Mvc.HtmlHelper helper, string controlid)
        {
            var areaName = HttpContext.Current.Request.QueryString["areaname"];
            ProductXmlDataEngine xmlEngine = new ProductXmlDataEngine();
            HtmlTag wrapperDiv = new HtmlTag("div").Id(controlid);
            UrlHelper urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            string sourcecodetabUrl = urlHelper.Action("Index", "ShowCase");

            wrapperDiv.Modify(w =>
            {
                HtmlTag UlElement = new HtmlTag("ul", el =>
                {
                    DirectoryInfo dir = new DirectoryInfo(helper.ViewContext.RequestContext.HttpContext.Request.PhysicalApplicationPath + "Areas");
                    FileInfo[] files = dir.GetFiles("SourceFiles.xml", SearchOption.AllDirectories);
                    IEnumerable<XElement> sourceCodes = null;
                    if (files.Length != 0 && files[0] != null)
                    {
                        XDocument doc = XDocument.Load(files[0].FullName);
                        XElement rootNode = doc.Element("Category");
                        sourceCodes =rootNode.Elements().Where(c => c.Attribute("url").Value.ToLower() == areaName).Elements();
                    }

                    if (sourceCodes != null)
                    {
                        sourceCodes.ForEach(c => el.Add(new HtmlTag("li", x => x.Add(new HtmlTag("a").Text(c.Attribute("displayname").Value).Attributes("href", sourcecodetabUrl + "?file=" + c.Attribute("url").Value)))));
                    }
                });
                w.Add(UlElement);
            });

            string scriptTag = "<script>$('#" + controlid + "').ejTab({enableTabScroll: false});</script>";

            return wrapperDiv.ToString() + scriptTag;
        }


    }

}
