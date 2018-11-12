using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.HealthTracker
{
    public class HealthTrackerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "HealthTracker";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HealthTracker_default",
                "HealthTracker/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
