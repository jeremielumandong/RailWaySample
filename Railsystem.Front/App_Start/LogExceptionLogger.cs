using System.Web.Http.ExceptionHandling;
using log4net;

namespace Railsystem.Front
{
    public class LogExceptionLogger : ExceptionLogger
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof (LogExceptionLogger));

        public override bool ShouldLog(ExceptionLoggerContext context)
        {
            return Logger.IsErrorEnabled;
        }

        public override void Log(ExceptionLoggerContext context)
        {
            Logger.Error("An error has occured.", context.Exception);
        }
    }
}