using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestAutomationFramework.TestCases.AssignLeavePageModule.TestFunctions;

namespace TestAutomationFramework.TestCases.AssignLeavePageModule
{
    [TestClass]
    public class AssignTestCases
    {
        [TestMethod]
        [TestCategory("Assign Leave")]
        //[DataSource(ApplicationConstant.xmlConnectionString, ApplicationConstant.xmlPath, "Login", DataAccessMethod.Sequential)]
        [Description("successfull Assign Leave test with postive test data")]
        public void TestAssignLeaveForm002()
        {
            AssignLeaveMethods.SubmitForm();
        }
    }
}
