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
        public void Login(string url,string username,string password)
        {
            driver.Url = url;
            Dictionary<string,By> loginLocators = LocatorsMethods.SetByLoacator("input","id");
            LocatorsMethods.SetSendKeys(loginLocators["txtUsername"],username);
            LocatorsMethods.SetSendKeys(loginLocators["txtPassword"],password);
            LocatorsMethods.SetClick(loginLocators["btnLogin"]);
        }
    }
}
