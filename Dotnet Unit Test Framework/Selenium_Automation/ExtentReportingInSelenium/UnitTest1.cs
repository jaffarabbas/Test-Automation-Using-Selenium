using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtentReportingInSelenium
{
    [TestClass]
    public class ExtentRunner
    {

        public ExtentReports extentReports = null;
        public void load()
        {
            var report = new ExtentHtmlReporter(@"J:\Github\Test-Automation-Using-Selenium\Dotnet Unit Test Framework\AutomationUsingSelenium_1\ExtentReportingInSelenium\Report\report.html");      
            extentReports = new ExtentReports();
            extentReports.AttachReporter(report);
        }
        public ExtentRunner()
        {
            load();
        }
        [TestMethod]
        public void TestReporter()
        {
            ExtentTest extentTest = null;
            try
            {
                extentTest = extentReports.CreateTest("test1").Info("1");
                int a = 4;
                int b = 4;
                int c = a + b;
                Assert.AreEqual(c, 8);

                extentTest.Log(Status.Pass, "Test Passed");
                extentReports.Flush();
            }
            catch (Exception e)
            {
                extentTest.Log(Status.Fail, "Test Failed" + e.ToString());
                extentReports.Flush();
            }
        }

        [TestMethod]
        public void TestReporter2()
        {
            ExtentTest extentTest = null;
            try
            {
                extentTest = extentReports.CreateTest("test2").Info("2");
                int a = 7;
                int b = 4;
                int c = a + b;
                Assert.AreEqual(c, 11);

                extentTest.Log(Status.Pass, "Test Pass");

            }
            catch (Exception e)
            {
                extentTest.Log(Status.Fail, "Test Failed" + e.ToString());
            }
        }

        ~ExtentRunner()
        {
            extentReports.Flush();
        }

    }
}
