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
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
            }
        }

        public string CheckAssertionMessage(Dictionary<string, string> attributes)
        {
             return (Validation.CheckTestData(attributes["testData"])) ? LocatorsMethods.GetText(LocatorsMethods.GetLocater()["dashboardByXpath"]) : LocatorsMethods.GetText(LocatorsMethods.GetLocater()["invalidById"]);
        }
    }
}
