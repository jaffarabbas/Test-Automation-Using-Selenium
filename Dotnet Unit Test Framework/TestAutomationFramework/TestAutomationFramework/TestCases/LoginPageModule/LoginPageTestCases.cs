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
using TestAutomationFramework.GlobalItems;

namespace TestAutomationFramework.TestCases
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]

    public class LoginPageTestCases
    {
        #region Instance Properties

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
            GlobalInstances.instancesDictionary.Add("browserConnection", ConfigurationManager.AppSettings.Get("ChromeBrowser"));
            GlobalInstances.instancesDictionary.Add("url", ApplicationConstant.mainUrl);
            loginPageMethods = new LoginPageMethods();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalInstances.instancesDictionary.Clear();
        }

        [TestInitialize]
        public void TestInit()
        {
            GlobalInstances.instancesDictionary.Add("username", TestContext.DataRow["username"].ToString());
            GlobalInstances.instancesDictionary.Add("password", TestContext.DataRow["password"].ToString());
            GlobalInstances.instancesDictionary.Add("message", TestContext.DataRow["message"].ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        #endregion

        #region Test Cases

        [TestMethod]
        [TestCategory("Login")]
        [DataSource(ApplicationConstant.xmlConnectionString, ApplicationConstant.xmlPath, "Login", DataAccessMethod.Sequential)]
        [Description("successfull login test with postive test data and get Welcome string from dashboard")]
        public void TestLoginWithPositiveData001()
        {
            #region Initialization

            LoadDriverInitialiazer.LoadWebDriver(GlobalInstances.instancesDictionary["browserConnection"]);

            #endregion

            #region Working

            loginPageMethods.Login(GlobalInstances.instancesDictionary);

            #endregion

            #region Checking Assertion

            string[] actualMessage = loginPageMethods.CheckPageIsNavigate().Split(' ');
            Assert.AreEqual(actualMessage[0], GlobalInstances.instancesDictionary["message"], "Assert Fail");

            #endregion

            #region Flushing

            GlobalInstances.instancesDictionary.Clear();

            #endregion 
        }

        #endregion
    }
}
