using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.SpreadsheetTemplate
{
    public class SpreadsheetTemplateAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SpreadsheetTemplate";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SpreadsheetTemplate_default",
                "SpreadsheetTemplate/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
