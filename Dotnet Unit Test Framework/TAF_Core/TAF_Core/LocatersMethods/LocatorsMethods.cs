using AventStack.ExtentReports;
using LoadDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.Constants;
using TestAutomationFramework.LoggerHandler;
using TestAutomationFramework.Reporting;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.LocatersMethods
{
    public partial class LocatorsMethods : LoadDriverInitialiazer
    {
        #region Selinium Locators

        public static void SetSendKeys(By attribute, string value)
        {
            try
            {
                GetDriver().FindElement(attribute).SendKeys(value);
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild("Send Value " + value.ToString() + " to " +attribute.ToString() + "Locater"));
            }
            catch(Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        public static void SetSendKeys(By attribute, dynamic value)
        {
            try
            {
                GetDriver().FindElement(attribute).SendKeys(value);
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild("Send Value " + value.ToString() + " to " + attribute.ToString() + "Locater"));
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        public static void SetClick(By attribute)
        {
            try
            {
                GetDriver().FindElement(attribute).Click();
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild("Clicked Locater : "+attribute.ToString()));
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        public static string GetText(By attribute)
        {
            try
            {
                string textvalue = GetDriver().FindElement(attribute).Text;
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild("Get Text : "+ textvalue + " from Locater : " + attribute.ToString()));
                return textvalue;
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
                return null;
            }
        }

        public static void RefreshPage()
        {
            try
            {
                GetDriver().Navigate().Refresh();
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild("Page Refreashed"));
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        #endregion
    }
}
