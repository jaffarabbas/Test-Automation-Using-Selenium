//using LoadDriver;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Configuration;
//using TestAutomationFramework.Constants;
//using TestAutomationFramework.GlobalItems;
//using TestAutomationFramework.LocatersMethods;
//using TestAutomationFramework.TestCases.AssignLeavePageModule.TestFunctions;

//namespace TestAutomationFramework.TestCases.AssignLeavePageModule
//{
//    [TestClass]
//    public class AssignLeaveTestCases
//    {
//        #region Instance Properties

//        /// <summary>
//        /// Object instances
//        /// </summary>
//        public static AssignLeaveMethods assignLeavePageMethods;

//        #endregion

//        #region Text Context Inititalization

//        public TestContext instance;
//        public TestContext TestContext
//        {
//            set { instance = value; }
//            get { return instance; }
//        }

//        #endregion

//        #region Initializations and Cleanups

//        [AssemblyInitialize]
//        public static void AssemblyInit(TestContext context)
//        {

//        }

//        [AssemblyCleanup]
//        public static void AssemblyCleanup()
//        {

//        }

//        [ClassInitialize]
//        public static void ClassInit(TestContext context)
//        {
//            LoadDriverInitialiazer.LoadWebDriver();
//            assignLeavePageMethods = new AssignLeaveMethods();
//        }

//        [ClassCleanup]
//        public static void ClassCleanup()
//        {
//            GlobalInstances.ClearInstancesDictionary();
//            LocatorsMethods.ClearDictionary();
//        }

//        [TestInitialize]
//        public void TestInit()
//        {

//        }

//        [TestCleanup]
//        public void TestCleanup()
//        {
//            GlobalInstances.ClearInstancesDictionary();
//        }

//        #endregion

//        [TestMethod]
//        [TestCategory(LoginTestMetaData.LoginCategory)]
//        [Priority(LoginTestMetaData.Priority)]
//        [DataSource(ApplicationConstant.XmlConnectionString, ApplicationConstant.XmlPath, ApplicationConstant.TestCasesOfLogin, ApplicationConstant.AccessMethod)]
//        [Description(LoginTestMetaData.Description)]
//        [Owner(LoginTestMetaData.Owner)]
//        public void TestAssignLeaveForm002()
//        {
//            //AssignLeaveMethods.SubmitForm();
//        }
//    }
//}
