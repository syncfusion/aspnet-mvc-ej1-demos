using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCSampleBrowser
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("wcf/{resource}.svc/{*pathInfo}");
            routes.IgnoreRoute("wcf/{resource}.svc");

           
            routes.MapRoute(
                name: "SourceCodeTabNoAction",
                url: "SourceCodeTab",
                defaults: new { controller = "SourceCodeTab", action = "Index" },
                 namespaces: new[] { "MVCSampleBrowser.Controllers" }
            );
            routes.MapRoute(
                 name: "NoAction",
                 url: "{controller}",
                 defaults: new { action = "Default", id = UrlParameter.Optional },
                  namespaces: new[] { "MVCSampleBrowser.Controllers" }
             );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Introduction", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "MVCSampleBrowser.Controllers" }
            );
        }
    }
}