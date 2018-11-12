using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.WeatherAnalysis
{
    public class WeatherAnalysisAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "WeatherAnalysis";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "WeatherAnalysis_default",
                "WeatherAnalysis/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
