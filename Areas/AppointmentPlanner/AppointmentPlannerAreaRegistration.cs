using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.AppointmentPlanner
{
    public class AppointmentPlannerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AppointmentPlanner";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AppointmentPlanner_default",
                "AppointmentPlanner/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
