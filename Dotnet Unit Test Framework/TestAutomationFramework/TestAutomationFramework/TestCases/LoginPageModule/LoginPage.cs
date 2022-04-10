using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TestAutomationFramework.TestCases.LoginPage.TestFunctions;
using LoadDriver;

namespace TestAutomationFramework.TestCases
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]
    public class LoginPageTestClass
    {
        LoginPageMethods loginPageMethods = new LoginPageMethods();

        [TestMethod]
        public void TestMethod1()
        {
            LoadDriverInitialiazer.LoadWebDriver(ConfigurationManager.AppSettings.Get("ChromeBrowser"));
            loginPageMethods.Login("https://opensource-demo.orangehrmlive.com/index.php/auth/login","","");
        }
    }
}
