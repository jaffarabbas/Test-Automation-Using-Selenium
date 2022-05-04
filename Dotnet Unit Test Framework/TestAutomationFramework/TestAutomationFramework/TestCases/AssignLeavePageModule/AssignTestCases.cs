using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using TestAutomationFramework.Constants;
using TestAutomationFramework.GlobalItems;
using TestAutomationFramework.TestCases.AssignLeavePageModule.TestFunctions;

namespace TestAutomationFramework.TestCases.AssignLeavePageModule
{
    [TestClass]
    public class AssignLeaveTestCases
    {
        //#region Instance Properties

        ///// <summary>
        ///// Object instances
        ///// </summary>
        //public static AssignLeaveMethods assignLeavePageMethods;

        //#endregion

        //#region Text Context Inititalization

        //public TestContext instance;
        //public TestContext TestContext
        //{
        //    set { instance = value; }
        //    get { return instance; }
        //}

        //#endregion

        //#region Initializations and Cleanups

        //[AssemblyInitialize]
        //public static void AssemblyInit(TestContext context)
        //{

        //}

        //[AssemblyCleanup]
        //public static void AssemblyCleanup()
        //{

        //}

        //[ClassInitialize]
        //public static void ClassInit(TestContext context)
        //{
        //    GlobalInstances.SetInstancesDictionary("browserConnection", ConfigurationManager.AppSettings.Get("ChromeBrowser"));
        //    GlobalInstances.SetInstancesDictionary("url", ApplicationConstant.mainUrl);
        //    //assignLeavePageMethods = new AssignLeaveMethods();
        //}

        //[ClassCleanup]
        //public static void ClassCleanup()
        //{

        //}

        //[TestInitialize]
        //public void TestInit()
        //{

        //}

        //[TestCleanup]
        //public void TestCleanup()
        //{

        //}

        //#endregion

        [TestMethod]
        [TestCategory("Assign Leave")]
        //[DataSource(ApplicationConstant.xmlConnectionString, ApplicationConstant.xmlPath, "Login", DataAccessMethod.Sequential)]A
        [Description("successfull Assign Leave test with postive test data")]
        public void TestAssignLeaveForm002()
        {
            //AssignLeaveMethods.SubmitForm();
        }
    }
}
