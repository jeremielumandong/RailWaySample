using System;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;

namespace Railsystem.Front
{
    public class WebApiApplication : HttpApplication
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            WindsorConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalConfiguration.Configuration.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Logger.Info("Web api is ready.");
        }

        protected void Application_End()
        {
            Logger.Info("Web api is going down.");

            LogManager.Shutdown();
            WindsorConfig.Dispose();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Logger.Error("An uncaught exception occurred.", this.Server.GetLastError());
        }
    }
}