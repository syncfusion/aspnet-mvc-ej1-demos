#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using MVCSampleBrowser.Error;
using System.Data.Common;
using System.IO;
using System.Text;
using Syncfusion.Licensing;

namespace MVCSampleBrowser
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapHubs();
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string License = File.ReadAllText(Server.MapPath("SyncfusionLicense.txt"), Encoding.UTF8);
            SyncfusionLicenseProvider.RegisterLicense(License);
            //AuthConfig.RegisterAuth();

            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            RouteData routeData = new RouteData();
            routeData.Values.Add("ErrorMsg", exception.Message);
            routeData.Values.Add("StackTrace", exception.StackTrace);
            routeData.Values.Add("Controller", "ErrorHandler");
            if (exception is DbException)
            {
                routeData.Values.Add("Action", "DatabaseError");
            }
            else if (exception is HttpException)
            {
                routeData.Values.Add("ExUrl", HttpContext.Current.Request.Url);
                if ((exception as HttpException).GetHttpCode() == 404)
                    routeData.Values.Add("Action", "PageError");
                else
                    routeData.Values.Add("Action", "CommonError");
            }
            else
                routeData.Values.Add("Action", "CommonError");
            Response.Clear();
            Server.ClearError();
            try
            {
                IController exceptionControl = new ErrorHandlerController();
                exceptionControl.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
            }
            catch (Exception)
            {

            }
        }
    }
}