using System.Reflection;

namespace StretchCeilings.Helpers
{
    public static class LogHelper
    {
        public static log4net.ILog GetLogger()
        {
            return log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        }
    }
}
