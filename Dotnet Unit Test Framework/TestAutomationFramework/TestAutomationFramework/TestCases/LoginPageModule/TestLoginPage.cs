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
        #region Instance Properties

        public static string browserConnection;
        public static string xmlConnectionString;
        public static string xmlPath;
        public static string url;
        public static string username;
        public static string password;
        public static string locator;
        public static string message;

        #endregion

        #region Initializations and Cleanups

        public static TestContext instance;
        public static TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
           
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            browserConnection = ConfigurationManager.AppSettings.Get("ChromeBrowser");
            xmlConnectionString = ConfigurationManager.AppSettings.Get("XMLFileConnectionString");
            xmlPath = ConfigurationManager.AppSettings.Get("XMLFilePath");
            url = TestContext.DataRow["url1"].ToString();
            username = TestContext.DataRow["username"].ToString();
            password = TestContext.DataRow["password"].ToString();
            message = TestContext.DataRow["message"].ToString();
            locator = TestContext.DataRow["locator"].ToString();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            
        }


        [TestInitialize]
        public void TestInit()
        {
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            
        }

        #endregion

        LoginPageMethods loginPageMethods = new LoginPageMethods();

        [TestMethod]
        [TestCategory("Login")]
        [DataSource(xmlConnectionString, @"", "Automation", DataAccessMethod.Sequential)]
        [Description("successfull login test")]
        public void TestMethod1()
        {
            LoadDriverInitialiazer.LoadWebDriver(browserConnection);
            loginPageMethods.Login(url,username, password,message,locator);
        }
    }
}
