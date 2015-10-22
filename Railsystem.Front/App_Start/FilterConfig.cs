using System.Web.Http.Filters;

namespace Railsystem.Front
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            filters.Add(new LoggerInterceptor());
        }
    }
}