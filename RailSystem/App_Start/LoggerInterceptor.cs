using System.Reflection;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using log4net;

namespace RailSystem
{
    public class LoggerInterceptor : ActionFilterAttribute
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var controllerName = actionContext.ControllerContext.ControllerDescriptor.ControllerName;
            var actionName = actionContext.ActionDescriptor.ActionName;
            Logger.Info(string.Format("Call to '{0}.{1}'", controllerName, actionName));
        }
    }
}