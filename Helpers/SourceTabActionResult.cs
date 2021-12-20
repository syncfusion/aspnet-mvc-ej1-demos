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
using System.Text;
using System.Web.Mvc;

namespace MVCSampleBrowser.Helpers
{
    public class SourceTabActionResult : ActionResult
    {
        private string FileName
        {
            get;
            set;
        }
        private bool SeperateWindow { get; set; }
        public SourceTabActionResult(string fileName, string seperateWindow)
        {
            this.FileName = fileName;
            this.SeperateWindow = seperateWindow=="true";
        }

        public override void ExecuteResult(ControllerContext context)
        {
            ProductXmlDataEngine xmlEngine = new ProductXmlDataEngine();
            TabType tabType = xmlEngine.GetTabType(this.FileName);

            string content = xmlEngine.GetTabContent(tabType, this.FileName);
            context.HttpContext.Response.Output.Write(content);
        }

    }
}
