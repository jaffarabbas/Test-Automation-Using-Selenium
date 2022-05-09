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
        public string url;
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
           
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        #endregion

        [TestMethod]
        [TestCategory("Login")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",@"..\", "MainUrl", DataAccessMethod.Sequential)]
        [Description("successfull login test with postive test data")]
        public void TestLoginWithPositiveData001()
        {
            url = TestContext.DataRow["url1"].ToString();
            //username = TestContext.DataRow["username"].ToString();
            //password = TestContext.DataRow["password"].ToString();
            //message = TestContext.DataRow["message"].ToString();
            //locator = TestContext.DataRow["locator"].ToString();
            LoadDriverInitialiazer.LoadWebDriver(browserConnection);
            loginPageMethods.Login(url, "","","","");
        }
        [TestMethod]
        public void tes()
        {
            MessageBox.Show(url);

            //LoadDriverInitialiazer.LoadWebDriver(browserConnection);
            //LoginPageMethods loginPage = new LoginPageMethods();
            //loginPage.Login(url, username, password, message, locator);
        }
    }
}
