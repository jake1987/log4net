using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4netDemo.Common
{
    public class LogHelper
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger("WebApp.Logging");

        public static void Error(string Content)
        {
            log.Error(Content);
        }

        public static void Error(string Content,Exception ex)
        {
            log.Error(Content, ex);
        }
    }
}
