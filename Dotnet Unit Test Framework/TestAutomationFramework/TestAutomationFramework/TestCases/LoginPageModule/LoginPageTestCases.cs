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
using TestAutomationFramework.TestCases.LoginPageModule;

namespace TestAutomationFramework.TestCases.LoginPageModule
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]

    public partial class LoginPageTestCases
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
            SetLoginLocaters();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalInstances.ClearInstancesDictionary();
            //LocatorsMethods.ClearDictionary();
        }

        [TestInitialize]
        public void TestInit()
        {
            GlobalInstances.SetInstancesDictionary("testData", TestContext.DataRow["testData"].ToString());
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

            string actualMessage = loginPageMethods.CheckAssertionMessage(GlobalInstances.GetInstancesDictionary());
            Assert.AreEqual(actualMessage, GlobalInstances.GetInstancesDictionary()["message"], "Assert Fail");

            #endregion
        }

        #endregion
    }
}
