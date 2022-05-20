using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BDDWithSpecFlow
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        public UnitTest1()
        {
            driver = new ChromeDriver();
        }
        public void LoadTest()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
        }

        [TestMethod]
        [TestCategory("Logger Login")]
        [DataRow("jaffarabbas", "jaffarabbas", "welcome_menu", "Welcome to Adactin Group of Hotels")]
        //[DataRow("Jaffarabbas", "Jaffarabbas", "auth_error", "Invalid Login details or Your Password might have expired. Click here to reset your password")]
        public void LoginCombineTC03(string username, string password, string locator, string expectedMessage)
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
