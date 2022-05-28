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

        private ExtentReports extentReports = null;
        private ExtentTest extentTest = null;

        public void ExtentInitialize()
        {
            try
            {
                var report = new ExtentHtmlReporter(ApplicationConstant.ReportPath + ApplicationConstant.ReportFilename);
                extentReports = new ExtentReports();
                extentReports.AttachReporter(report);
            }
            catch (Exception error)
            {
                CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
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
                CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
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
                CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
                return null;
            }
        }

        public void ExtentFlush()
        {
            extentReports.Flush();
        }

        public void CreateTest(string testname,string info)
        {
            extentTest = extentReports.CreateTest(testname).Info(info);
        }

        public void CreateLog(Status status,string message)
        {
            extentTest.Log(status,message);
        }

        public void CreateInfo(string message)
        {
            extentTest.Info(message);
        }

        #endregion

        #region ExtentReports Singleton Object

        private static InitializeReport initializeReport;

        public static InitializeReport InitializeReportObject
        {
            get
            {
                if(initializeReport == null)
                {
                    initializeReport = new InitializeReport();
                }
                return initializeReport;
            }
            set
            {
                initializeReport = value;
            }
        }

        #endregion
    }
}
