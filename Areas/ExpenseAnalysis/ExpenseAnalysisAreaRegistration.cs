using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.ExpenseAnalysis
{
    public class ExpenseAnalysisAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ExpenseAnalysis";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ExpenseAnalysis_default",
                "ExpenseAnalysis/{controller}/{action}/{id}",
                new {controller = "expense", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "MVCSampleBrowser.Areas.ExpenseAnalysis.Controllers" }
            );
        }
    }
}
