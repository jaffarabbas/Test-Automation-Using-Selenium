using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.LoggerHandler
{
    public class LogHandler
    {
        private static LogHandler logHandler;
        private static readonly log4net.ILog logMaker = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Logger Singleton Object Method
        /// </summary>
        /// <returns>Logger Class Object</returns>
        public static LogHandler LogHandlerObject()
        {
            logHandler = new LogHandler();
            return logHandler;
        }
        /// <summary>
        /// Logger Object
        /// </summary>
        public log4net.ILog GetLogger()
        {
            return logMaker;
        }
    }
}
