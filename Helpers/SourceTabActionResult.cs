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
