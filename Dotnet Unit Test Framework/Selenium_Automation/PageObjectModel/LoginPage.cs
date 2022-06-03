using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class LoginPage : LoadDriver
    {
        public void LoginWithInvalidUserNameAndPassoword(string username, string password, string locator, string expectedMessage)
        {
            LoadTest();
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.ClassName("login_button")).Click();
            string value = driver.FindElement(By.ClassName(locator)).Text;
            Assert.AreEqual(expectedMessage, value, "Assertion Faild");
            driver.Close();
        }
    }
}
