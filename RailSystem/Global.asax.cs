using System;
using System.Reflection;
using System.Web;
using System.Web.Http;
using log4net;

namespace RailSystem
{
    public class WebApiApplication : HttpApplication
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            WindsorConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalConfiguration.Configuration.Filters);

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