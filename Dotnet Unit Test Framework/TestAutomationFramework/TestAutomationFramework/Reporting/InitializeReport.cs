using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.Constants;
using TestAutomationFramework.LoggerHandler;

namespace TestAutomationFramework.Reporting
{
    public class InitializeReport
    {
        #region ExtentReport Methods

        private ExtentReports extentReports;
        private ExtentTest extentTest;

        public void ExtentInitialize()
        {
            try
            {
                MessageBox.Show("asd");
                var report = new ExtentHtmlReporter(@"Report.html");
                extentReports = new ExtentReports();
                extentReports.AttachReporter(report);
            }
            catch (Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
            }
        }

        public ExtentReports GetExtentReports()
        {
            try
            {
                return extentReports;
            }
            catch (Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
                return null;
            }
        }


        public ExtentTest GetExtentTest()
        {
            try
            {
                return extentTest;
            }
            catch (Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
                return null;
            }
        }

        public void ExtentFlush()
        {
            extentReports.Flush();
        }

       
        #endregion

        #region ExtentReports Singleton Object

        //private static InitializeReport initializeReport;

        //public static InitializeReport InitializeReportObject()
        //{
        //    initializeReport = new InitializeReport();
        //    return initializeReport;
        //}

        #endregion
    }
}
