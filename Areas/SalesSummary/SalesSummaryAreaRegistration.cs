using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.SalesSummary
{
    public class SalesSummaryAreaRegistration :AreaRegistration
    {
        public override string AreaName
        {
            get 
            { 
                return "SalesSummary"; 
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
             context.MapRoute(
                "SalesSummary_default",
                "SalesSummary/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}