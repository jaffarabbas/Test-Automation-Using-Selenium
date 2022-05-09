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

        private TestContext TestContext
        {
            set => instance = value;
            get => instance;
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
            LoadDriverInitialiazer.LoadWebDriver();
            loginPageMethods = new LoginPageMethods();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalInstances.ClearInstancesDictionary();
        }

        [TestInitialize]
        public void TestInit()
        {
            GlobalInstances.SetInstancesDictionary("url", ApplicationConstant.MainUrl);
            GlobalInstances.SetInstancesDictionary("username", TestContext.DataRow["username"].ToString());
            GlobalInstances.SetInstancesDictionary("password", TestContext.DataRow["password"].ToString());
            GlobalInstances.SetInstancesDictionary("message", TestContext.DataRow["message"].ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            GlobalInstances.ClearInstancesDictionary();
        }

        #endregion

        #region Test Cases

        [TestMethod]
        [TestCategory("Login")]
        [DataSource(ApplicationConstant.XmlConnectionString, ApplicationConstant.XmlPath, "Login", DataAccessMethod.Sequential)]
        [Description("successfull login test with postive test data and get Welcome string from dashboard")]
        public void TestLoginWithPositiveData001()
        {
            #region Initialization


            #endregion

            #region Working

            loginPageMethods.Login(GlobalInstances.GetInstancesDictionary());

            #endregion

            #region Checking Assertion

            string[] actualMessage = loginPageMethods.CheckPageIsNavigate().Split(' ');
            Assert.AreEqual(actualMessage[0], GlobalInstances.GetInstancesDictionary()["message"], "Assert Fail");

            #endregion
        }

        #endregion
    }
}
