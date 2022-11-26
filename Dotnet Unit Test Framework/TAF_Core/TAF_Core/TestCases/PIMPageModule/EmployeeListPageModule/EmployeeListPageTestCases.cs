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
using TestAutomationFramework.TestCases.PIMPageModule.EmployeeListPageModule.TestFunctions;

namespace TestAutomationFramework.TestCases.LoginPageModule
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]

    public partial class EmployeeListPageTestCases
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

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            LoadDriverInitialiazer.LoadWebDriver();
            //Initialized Class Locaters
            SetEmployeeListLocaters();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            InitializeReport.InitializeReportObject.ExtentFlush();
            GlobalInstances.ClearInstancesDictionary();
            LocatorsMethods.ClearDictionary();
        }

        [TestInitialize]
        public void TestInit()
        {
            GlobalInstances.SetInstancesDictionary("testData", TestContext.DataRow["testData"].ToString());
            GlobalInstances.SetInstancesDictionary("username", TestContext.DataRow["username"].ToString());
            GlobalInstances.SetInstancesDictionary("password", TestContext.DataRow["password"].ToString());
            GlobalInstances.SetInstancesDictionary("searchName", TestContext.DataRow["searchName"].ToString());
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
        [TestCategory(EmployeeListMetaData.TestCase001.Category)]
        [Priority(EmployeeListMetaData.TestCase001.Priority)]
        [DataSource(ApplicationConstant.XmlConnectionString, ApplicationConstant.XmlPath, ApplicationConstant.TestCasesOfEmployeeList, ApplicationConstant.AccessMethod)]
        [Description(EmployeeListMetaData.TestCase001.Description)]
        [Owner(EmployeeListMetaData.TestCase001.Owner)]
        public void Test004SearchInEmployeeListAndDelete()
        {
            try
            {
                #region Initialization

                InitializeReport.InitializeReportObject.CreateTest(TestContext.TestName, EmployeeListMetaData.TestCase001.Description);

                #endregion

                #region Working

                EmployeeListPageMethods.EmployeeListPageMethodsObjects.EmployeeList(GlobalInstances.GetInstancesDictionary());

                #endregion

                #region Checking Assertion


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
