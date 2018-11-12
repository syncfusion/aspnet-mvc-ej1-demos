using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.DiagramBuilder
{
    public class DigramBuilderAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "DiagramBuilder";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "DiagramBuilder_default",
                "DiagramBuilder/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "MVCSampleBrowser.Areas.DiagramBuilder.Controllers" }
            );
        }
    }
}
