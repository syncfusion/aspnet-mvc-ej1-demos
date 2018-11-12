using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.Projecttracker
{
    public class ProjecttrackerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Projecttracker";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Projecttracker_default",
                "Projecttracker/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
