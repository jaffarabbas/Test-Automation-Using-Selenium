using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParellelTestExicution
{
    [TestClass]
    public class ValidateLogin
    {
        IWebDriver driver;
        public ValidateLogin()
        {
            driver = new ChromeDriver();
        }
        public void LoadTest()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
        }

        [TestMethod]
        [TestCategory("Login")]
        [DataRow("Jaffarabbas", "Jaffarabbas", "auth_error", "Invalid Login details or Your Password might have expired. Click here to reset your password")]
        public void LoginWithInvalidUserNameAndPassowordTC01(string username, string password, string locator, string expectedMessage)
        {
            LoadTest();
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.ClassName("login_button")).Click();
            string value = driver.FindElement(By.ClassName(locator)).Text;
            Assert.AreEqual(expectedMessage, value, "Assertion Faild");
            driver.Close();
        }

        [TestMethod]
        [TestCategory("Login")]
        [DataRow("jaffarabbas", "jaffarabbas", "welcome_menu", "Welcome to Adactin Group of Hotels")]
        public void LoginWithValidUserNameAndPassowordTC02(string username, string password, string locator, string expectedMessage)
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
