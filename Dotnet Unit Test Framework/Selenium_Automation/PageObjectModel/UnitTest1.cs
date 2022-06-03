using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PageObjectModel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Login")]
        [DataRow("Jaffarabbas", "Jaffarabbas", "auth_error", "Invalid Login details or Your Password might have expired. Click here to reset your password")]
        public void TestMethod1(string username, string password, string locator, string expectedMessage)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LoginWithInvalidUserNameAndPassoword(username, password, locator, expectedMessage);
        }
    }
}
