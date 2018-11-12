using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.ShowCaseTab
{
    public class ShowCaseTabAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ShowCaseTab";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ShowCaseTab_default",
                "ShowCaseTab/{controller}/{action}/{id}",
                new { controller = "ShowCase", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "MVCSampleBrowser.Areas.ShowCaseTab.Controllers" }
            );
        }
    }
}
