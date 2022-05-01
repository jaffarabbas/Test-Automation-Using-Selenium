using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TestAutomationFramework.TestCases.LoginPage.TestFunctions;
using LoadDriver;
using TestAutomationFramework.Constants;
using System.Windows.Forms;
using System.Data;
using TestAutomationFramework.LocatersMethods;

namespace TestAutomationFramework.TestCases
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]
    public class TestLoginPage
    {
        #region Instance Properties

        public static string browserConnection;
        public string username;
        public string password;
        public string locator;
        public string message;


        /// <summary>
        /// Object instances
        /// </summary>
        public static LoginPageMethods loginPageMethods;

        #endregion

        #region Text Context Inititalization

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        #endregion

        #region Initializations and Cleanups

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
            loginPageMethods = new LoginPageMethods();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }


        [TestInitialize]
        public void TestInit()
        {
            username = TestContext.DataRow["username"].ToString();
            password = TestContext.DataRow["password"].ToString();
            message = TestContext.DataRow["message"].ToString();
            locator = TestContext.DataRow["locator"].ToString();
            MessageBox.Show(locator);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        #endregion

        [TestMethod]
        [TestCategory("Login")]
        [DataSource(ApplicationConstant.xmlConnectionString, ApplicationConstant.xmlPath,"Login", DataAccessMethod.Sequential)]
        [Description("successfull login test with postive test data")]
        public void TestLoginWithPositiveData001()
        {
            LoadDriverInitialiazer.LoadWebDriver(browserConnection);
            loginPageMethods.Login(ApplicationConstant.mainUrl, username , password);
        }
    }
}
