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
using System.Xml.Linq;
using System.Web.Mvc;
using System.Web;
using System.IO;
using Manoli.Utils.CSharpFormat;
using System.Web.Hosting;
using System.Collections;

namespace MVCSampleBrowser.Helpers
{
    internal class ProductXmlDataEngine
    {
        public TabType GetTabType(string fileName)
        {

            if (fileName.EndsWith(".aspx") || fileName.EndsWith(".cshtml"))
                return TabType.View;
            else if (fileName.EndsWith(".ascx"))
                return TabType.PartialView;
            else if (fileName.EndsWith(".cs"))
                return TabType.CS;
            else if (fileName.EndsWith(".css"))
                return TabType.CSS;
            else if (fileName.EndsWith(".js"))
                return TabType.JavaScript;
            else if (fileName.EndsWith(".vb"))
                return TabType.VB;
            else if (fileName.EndsWith(".html"))
                return TabType.Description;
            else if (fileName.EndsWith(".json"))
                return TabType.Html;
            else
                return TabType.XML;

        }

        public string GetSourceTabUrl(HtmlHelper helper, TabType LoadType)
        {

            string filePath = "";
            string dynamicUrl = GetDynamicUrl();
            //   bool isRazorEngine = (bool)helper.ViewData["isRazorEngine"];
	    if (!(dynamicUrl.Contains("/")))
                dynamicUrl = dynamicUrl + "/";
            string[] StreamSplit = dynamicUrl.Split('/');
            string RazorPath = string.Empty;
            string RazorExten = ".cshtml";
            //if (isRazorEngine)
            //{
            //    RazorPath = "Areas\\Razor\\";
            //    RazorExten = ".cshtml";
            //}


            if (StreamSplit.Length >= 1)
            {

                if (LoadType == TabType.CS)
                {
                    filePath = "Controllers" + @"\" + StreamSplit[0] + @"\" + StreamSplit[1] + "Controller.cs";
                }
                else if (LoadType == TabType.View)
                {
		    if (StreamSplit[1] == "")
                    {

                        UrlHelper urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
                        var routeValueDictionary = urlHelper.RequestContext.RouteData.Values;
                        StreamSplit[1] = (string)routeValueDictionary["action"];
                    }
                    filePath = RazorPath + "Views" + @"\" + StreamSplit[0] + @"\" + StreamSplit[1] + RazorExten;
                }
                else if (LoadType == TabType.Description)
                {
                    filePath = RazorPath + "Views" + @"\" + StreamSplit[0] + @"\" + StreamSplit[1] + ".htm";
                }

            }

            return filePath;
        }

        private static string GetDynamicUrl()
        {
            HttpContext context = System.Web.HttpContext.Current;

            String DynamicUrl = string.Empty;
            if (context.Request.PhysicalPath.Length > context.Request.PhysicalApplicationPath.Length)
                DynamicUrl = context.Request.PhysicalPath.Remove(0, context.Request.PhysicalApplicationPath.Length).Replace("\\", "/").ToLower();


            return DynamicUrl.Replace("Razor", "razor").Replace("razor/", "");
        }

        public IEnumerable<XElement> GetSourceCodeOtherFiles(HtmlHelper helper)
        {
            HttpContext context = System.Web.HttpContext.Current;

            string dynamicUrl = GetDynamicUrl();
            //bool isRazorEngine = true;
            string[] StreamSplit = dynamicUrl.Split('/');
            string RazorPath = string.Empty;
            //if (isRazorEngine)
            //    RazorPath = "Areas/Razor/";
            DirectoryInfo dir = new DirectoryInfo(context.Request.PhysicalApplicationPath + RazorPath + "Views" + @"\" + StreamSplit[0]);
            FileInfo[] files = dir.GetFiles("OtherFiles.xml", SearchOption.AllDirectories);
            IEnumerable<XElement> sourceCodes = null;
            if (files.Length != 0 && files[0] != null)
            {
                XDocument doc = XDocument.Load(files[0].FullName);
                XElement rootNode = doc.Element("Category");
                sourceCodes = rootNode.Elements().Where(c => c.Attribute("url").Value.ToLower() == @"/" + dynamicUrl).Elements();
            }
            return sourceCodes;
        }

        public string GetTabContent(TabType LoadType, string Path)
        {
            TagBuilder tabContent = new TagBuilder("div");
            string Filestream = "";
            CSharpFormat csformat = new CSharpFormat();
            HtmlFormat format = new HtmlFormat();
            JavaScriptFormat jsformat = new JavaScriptFormat();
            VisualBasicFormat vbformat = new VisualBasicFormat();
            HttpContext context = System.Web.HttpContext.Current;

            switch (LoadType)
            {
                case TabType.Description:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + Path);
                    tabContent.InnerHtml = context.Server.HtmlDecode(Filestream);
                    break;
                case TabType.PartialView:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + @"\Views" + Path.Replace("/", "\\"));
                    tabContent.InnerHtml = format.FormatCode(Filestream).ToString();
                    break;
                case TabType.View:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + Path);
                    tabContent.InnerHtml = format.FormatCode(Filestream).ToString();
                    break;
                case TabType.VB:
                case TabType.CS:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + Path);
                    tabContent.InnerHtml = csformat.FormatCode(Filestream).ToString();
                    break;
                case TabType.CSS:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + Path);
                    tabContent.InnerHtml = format.FormatCode(Filestream).ToString();
                    break;
                case TabType.XML:
                    Filestream = ReadTabContent(@"/Models" + Path);
                    tabContent.InnerHtml = csformat.FormatCode(Filestream).ToString();
                    break;
                case TabType.JavaScript:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + @"\Scripts" + Path.Replace("/", "\\"));
                    tabContent.InnerHtml = jsformat.FormatCode(Filestream).ToString();
                    break;
                case TabType.Model:
                    Filestream = ReadTabContent(@"/Models" + Path).ToString();
                    tabContent.InnerHtml = csformat.FormatCode(Filestream).ToString();
                    break;
                case TabType.Html:
                    Filestream = ReadTabContent(context.Request.PhysicalApplicationPath + Path.Replace("/", "\\"));
                    tabContent.InnerHtml = jsformat.FormatCode(Filestream).ToString();
                    break;
                default:
                    break;
            }

            return tabContent.ToString();
        }

        public string ReadFileContent(string path)
        {
            string targetPath = VirtualPathUtility.IsAppRelative(path) ? VirtualPathUtility.ToAbsolute(path) : path;

            using (Stream file = VirtualPathProvider.OpenFile(targetPath))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    return reader.ReadToEnd();
                };
            };
        }

        public string ReadTabContent(string path)
        {
            string content = "";
            ReadFileStreams MyStream = new ReadFileStreams();
            List<string> Filestream = new List<string>();
            Filestream = MyStream.GetFileData(path);
            foreach (string m in (IEnumerable<string>)Filestream)
            {
                if (m != null)
                {
                    content += m.ToString();
                }
            }
            return content;
        }
    }
}
