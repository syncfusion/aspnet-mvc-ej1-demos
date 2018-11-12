using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.ReportBuilder
{
    public class ReportBuilderAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ReportBuilder";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ReportBuilder_default",
                "ReportBuilder/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
