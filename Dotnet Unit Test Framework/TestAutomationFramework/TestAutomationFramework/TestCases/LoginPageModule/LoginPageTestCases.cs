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
using TestAutomationFramework.LoggerHandler;
using TestAutomationFramework.Reporting;
using AventStack.ExtentReports;

namespace TestAutomationFramework.TestCases.LoginPageModule
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]

    public partial class LoginPageTestCases
    {
        #region Instance Properties

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
            InitializeReport.InitializeReportObject.ExtentInitialize();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            LoadDriverInitialiazer.LoadWebDriver();
            //Initialized Class Locaters
            SetLoginLocaters();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalInstances.ClearInstancesDictionary();
            LocatorsMethods.ClearDictionary();
            InitializeReport.InitializeReportObject.ExtentFlush();
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
        [TestCategory(LoginTestMetaData.TestCase001.Category)]
        [Priority(LoginTestMetaData.TestCase001.Priority)]
        [DataSource(ApplicationConstant.XmlConnectionString, ApplicationConstant.XmlPath, ApplicationConstant.TestCasesOfLogin, ApplicationConstant.AccessMethod)]
        [Description(LoginTestMetaData.TestCase001.Description)]
        [Owner(LoginTestMetaData.TestCase001.Owner)]
        public void Test001LoginFunctionality()
        {
            try
            {
                #region Initialization

                InitializeReport.InitializeReportObject.CreateTest(TestContext.TestName, LoginTestMetaData.TestCase001.Description);

                #endregion

                #region Working

                LoginPageMethods.LoginPageMethodsObject.Login(GlobalInstances.GetInstancesDictionary());

                #endregion

                #region Checking Assertion

                string actualMessage = LoginPageMethods.LoginPageMethodsObject.CheckAssertionMessage(GlobalInstances.GetInstancesDictionary(), LoginTestMetaData.TestCase001.Category);
                Assert.AreEqual(actualMessage, GlobalInstances.GetInstancesDictionary()["message"], Errors.AssertionFailed);

                #endregion

                #region Reporting 

                InitializeReport.InitializeReportObject.CreateLog(Status.Pass, ExtentLogger.Passed);

                #endregion
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }


        [TestMethod]
        [TestCategory(LoginTestMetaData.TestCase002.Category)]
        [Priority(LoginTestMetaData.TestCase002.Priority)]
        [DataSource(ApplicationConstant.XmlConnectionString, ApplicationConstant.XmlPath, ApplicationConstant.TestCasesOfLogout, ApplicationConstant.AccessMethod)]
        [Description(LoginTestMetaData.TestCase002.Description)]
        [Owner(LoginTestMetaData.TestCase002.Owner)]
        public void Test002LogoutFunctionality()
        {
            try
            {
                #region Initialization

                InitializeReport.InitializeReportObject.CreateTest(TestContext.TestName, LoginTestMetaData.TestCase002.Description);

                #endregion

                #region Working

                LoginPageMethods.LoginPageMethodsObject.LogOut();

                #endregion

                #region Checking Assertion

                string actualMessage = LoginPageMethods.LoginPageMethodsObject.CheckAssertionMessage(GlobalInstances.GetInstancesDictionary(), LoginTestMetaData.TestCase002.Category);
                Assert.AreEqual(actualMessage, GlobalInstances.GetInstancesDictionary()["message"], Errors.AssertionFailed);

                #endregion

                #region Reporting 

                InitializeReport.InitializeReportObject.CreateLog(Status.Pass, ExtentLogger.Passed);

                #endregion
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        #endregion
    }
}
