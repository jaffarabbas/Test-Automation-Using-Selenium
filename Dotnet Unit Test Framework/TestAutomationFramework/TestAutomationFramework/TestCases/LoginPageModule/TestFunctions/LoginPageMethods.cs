using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestAutomationFramework.LocatersMethods;

namespace TestAutomationFramework.TestCases.LoginPage.TestFunctions
{
    public class LoginPageMethods : LoadDriverInitialiazer
    {
        public void Login(Dictionary<string,string> attributes)
        {
            try
            {
                driver.Url = attributes["url"];
                var loginLocators = LocatorsMethods.SetByLoacator("input","id");
                LocatorsMethods.SetSendKeys(loginLocators["txtUsername"],attributes["username"]);
                LocatorsMethods.SetSendKeys(loginLocators["txtPassword"],attributes["password"]);
                LocatorsMethods.SetClick(loginLocators["btnLogin"]);
                LocatorsMethods.ClearDictionary(LocatorsMethods.SetByLoacator("input", "id"));
                LocatorsMethods.ClearDictionary(loginLocators);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string CheckPageIsNavigate()
        {
            try
            {
                var dashboardLocators = LocatorsMethods.SetByLoacator("a", "id");
                var messageValue = LocatorsMethods.GetText(dashboardLocators["welcome"]);
                LocatorsMethods.ClearDictionary(LocatorsMethods.SetByLoacator("a", "id"));
                LocatorsMethods.ClearDictionary(dashboardLocators);
                return messageValue;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
