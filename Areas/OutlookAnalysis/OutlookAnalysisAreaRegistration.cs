#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.OutlookAnalysis
{
    public class OutlookAnalysisAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "OutlookAnalysis";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "OutlookAnalysis_default",
                "OutlookAnalysis/{controller}/{action}/{id}",
                new {controller = "Outlook", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "MVCSampleBrowser.Areas.OutlookAnalysis.Controllers" }
            );
        }
    }
}
