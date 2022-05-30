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

namespace TestAutomationFramework.TestCases.PIMPageModule.AddEmployeePageModule
{
    /// <summary>
    /// Summary description for LoginPage
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

        #region Test Cases

        [TestMethod]
        public void Test()
        {

        }

        #endregion
    }
}
