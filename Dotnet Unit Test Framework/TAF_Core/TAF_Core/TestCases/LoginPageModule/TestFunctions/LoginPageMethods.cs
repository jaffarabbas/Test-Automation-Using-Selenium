using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestAutomationFramework.LocatersMethods;
using TestAutomationFramework.LoggerHandler;
using TestAutomationFramework.Validations;
using TestAutomationFramework.Constants;
using TestAutomationFramework.Reporting;
using AventStack.ExtentReports;
using TestAutomationFramework.HelperMethod;

namespace TestAutomationFramework.TestCases.LoginPage.TestFunctions
{
    public class LoginPageMethods : LoadDriverInitialiazer
    {
        public void Login(Dictionary<string,string> attributes)
        {
            try
            {
                LocatorsMethods.RefreshPage();
                var loginLocators = LocatorsMethods.SetByLoacator("input", "id");
                LocatorsMethods.SetSendKeys(loginLocators["txtUsername"], attributes["username"]);
                LocatorsMethods.SetSendKeys(loginLocators["txtPassword"], attributes["password"]);
                LocatorsMethods.SetClick(loginLocators["btnLogin"]);
                LocatorsMethods.ClearDictionary(LocatorsMethods.SetByLoacator("input", "id"));
                LocatorsMethods.ClearDictionary(loginLocators);
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        public void LogOut()
        {
            LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["welcomeDropdownById"]);
            HelperMethods.Wait(WaitTime.standerdWait);
            LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["logoutBtnXpath"]);
        }

        public string CheckAssertionMessage(Dictionary<string, string> attributes,string testcase)
        {
            #region Login assertion

            if (testcase == LoginTestMetaData.TestCase001.Category)
            {
                if (Validation.CheckTestData(attributes["testData"]))
                {
                    return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["dashboardByXpath"]);

                }
                else
                {
                    return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["invalidById"]);
                }
            }


            #endregion

            #region Logout asserion

            if (testcase == LoginTestMetaData.TestCase002.Category)
            {
                return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["loginPanelTextById"]);
            }

            #endregion

            return null;
        }


        #region ExtentReports Singleton Object

        private static LoginPageMethods loginPageMethodsObjects;

        public static LoginPageMethods LoginPageMethodsObject
        {
            get
            {
                if (loginPageMethodsObjects == null)
                {
                    loginPageMethodsObjects = new LoginPageMethods();
                }
                return loginPageMethodsObjects;
            }
            set
            {
                loginPageMethodsObjects = value;
            }
        }

        #endregion
    }
}
