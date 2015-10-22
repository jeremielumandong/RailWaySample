using System.Web.Http.Filters;

namespace RailSystem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            filters.Add(new LoggerInterceptor());
        }
    }
}