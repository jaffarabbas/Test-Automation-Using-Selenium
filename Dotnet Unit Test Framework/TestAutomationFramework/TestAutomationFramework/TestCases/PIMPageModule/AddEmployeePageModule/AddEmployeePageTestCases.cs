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
using System.Threading;
using TestAutomationFramework.LocatersMethods;
using TestAutomationFramework.GlobalItems;
using TestAutomationFramework.TestCases.LoginPageModule;
using TestAutomationFramework.LoggerHandler;
using TestAutomationFramework.Reporting;
using AventStack.ExtentReports;
using TestAutomationFramework.TestCases.PIMPageModule.AddEmployeePageModule.TestFunctions;

namespace TestAutomationFramework.TestCases.PIMPageModule.AddEmployeePageModule
{
    /// <summary>
    /// Summary description for Add employee
    /// </summary>
    [TestClass]

    public partial class AddEmployeePageTestCases
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
            SetAddEmployeeLocaters();
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
            GlobalInstances.SetInstancesDictionary("firstname", TestContext.DataRow["firstname"].ToString());
            GlobalInstances.SetInstancesDictionary("middlename", TestContext.DataRow["middlename"].ToString());
            GlobalInstances.SetInstancesDictionary("lastname", TestContext.DataRow["lastname"].ToString());
            GlobalInstances.SetInstancesDictionary("profile", TestContext.DataRow["profile"].ToString());
            GlobalInstances.SetInstancesDictionary("newUsername", TestContext.DataRow["newUsername"].ToString());
            GlobalInstances.SetInstancesDictionary("userPassword", TestContext.DataRow["userPassword"].ToString());
            GlobalInstances.SetInstancesDictionary("confirmPassowrd", TestContext.DataRow["confirmPassowrd"].ToString());
            GlobalInstances.SetInstancesDictionary("statusDropdown", TestContext.DataRow["statusDropdown"].ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            GlobalInstances.ClearInstancesDictionary();
        }

        #endregion

        #region Test Cases

        [TestMethod]
        [TestCategory(AddEmployeeMetaData.TestCase001.Category)]
        [Priority(AddEmployeeMetaData.TestCase001.Priority)]
        [DataSource(ApplicationConstant.XmlConnectionString, ApplicationConstant.XmlPath, ApplicationConstant.TestCasesOfAddEmployee, ApplicationConstant.AccessMethod)]
        [Description(AddEmployeeMetaData.TestCase001.Description)]
        [Owner(AddEmployeeMetaData.TestCase001.Owner)]
        public void Test003AddEmployee()
        {
            try
            {
                #region Initialization

                InitializeReport.InitializeReportObject.CreateTest(TestContext.TestName, AddEmployeeMetaData.TestCase001.Description);

                #endregion

                #region Working

                LoginPageMethods.LoginPageMethodsObject.Login(GlobalInstances.GetInstancesDictionary());
                AddEmployeePageMethods.AddEmployeePageMethodsObjects.AddEmployee(GlobalInstances.GetInstancesDictionary());

                #endregion

                #region Checking Assertion

                string actualMessage = AddEmployeePageMethods.AddEmployeePageMethodsObjects.CheckAssertionMessage(GlobalInstances.GetInstancesDictionary(), AddEmployeeMetaData.TestCase001.Category);
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
