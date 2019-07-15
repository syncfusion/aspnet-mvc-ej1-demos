#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Collections;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Helpers
{
    public static class SampleBrowserHelper
    {
        public static string RenderSourceCodeTab(this System.Web.Mvc.HtmlHelper helper, string controlid)
        {
            ProductXmlDataEngine xmlEngine = new ProductXmlDataEngine();
            HtmlTag wrapperDiv = new HtmlTag("div").Id(controlid);
            UrlHelper urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            string sourcecodetabUrl = urlHelper.Action("Index", "SourceCodeTab");

            wrapperDiv.Modify(w =>
            {
                HtmlTag UlElement = new HtmlTag("ul", el =>
                {
                    el.Add(new HtmlTag("li", x =>
                    {
                        string filePath = xmlEngine.GetSourceTabUrl(helper, TabType.View);
                        x.Add("a").Text("View").Attributes().Add("href", sourcecodetabUrl + "?file=" + filePath);
                    }));
                    el.Add(new HtmlTag("li", x =>
                    {
                        string filePath = xmlEngine.GetSourceTabUrl(helper, TabType.CS);

                        x.Add("a").Text("Controller").Attributes().Add("href", sourcecodetabUrl + "?file=" + filePath);
                    }));
                    IEnumerable<XElement> otherFiles = xmlEngine.GetSourceCodeOtherFiles(helper);
                    if (otherFiles != null)
                    {
                        otherFiles.ForEach(c =>
                        {
                            el.Add(new HtmlTag("li", x =>
                            {
                                x.Add(new HtmlTag("a").Text(c.Attribute("displayname").Value).Attributes("href", sourcecodetabUrl + "?file=" + c.Attribute("url").Value));
                            }));
                        });
                    }
                });
                w.Add(UlElement);
            });

            string scriptTag = "<script>$('#" + controlid + "').ejTab({enableTabScroll: false});</script>";

            return wrapperDiv.ToString() + scriptTag;
        }
    }
}
