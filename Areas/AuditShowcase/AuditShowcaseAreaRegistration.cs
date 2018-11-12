using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.AuditShowcase
{
    public class AuditShowcaseAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AuditShowcase";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AuditShowcase_default",
                "AuditShowcase/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "MVCSampleBrowser.Areas.AuditShowcase.Controllers" }
            );
        }
    }
}
