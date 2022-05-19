using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LogingInSeleniumApp
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        IWebDriver driver;
        public UnitTest1()
        {
            driver = new ChromeDriver();
            log.Info("driver Initialized");
        }
        public void LoadTest()
        {
            driver.Manage().Window.Maximize();
            log.Info("driver maximized");
            driver.Url = "https://adactinhotelapp.com/";
            log.Info("Driver url set");
        }

        [TestMethod]
        [TestCategory("Logger Login")]
        [DataRow("Jaffarabbas", "Jaffarabbas", "auth_error", "Invalid Login details or Your Password might have expired. Click here to reset your password")]
        public void LoginWithInvalidUserNameAndPassowordTC01(string username, string password, string locator, string expectedMessage)
        {
            log.Info("Test case started");
            LoadTest();
            log.Info("Loadtest call");
            driver.FindElement(By.Id("username")).SendKeys(username);
            log.Info("Username set");
            driver.FindElement(By.Name("password")).SendKeys(password);
            log.Info("Password set");
            driver.FindElement(By.ClassName("login_button")).Click();
            log.Info("login button click set");
            string value = driver.FindElement(By.ClassName(locator)).Text;
            log.Info("locater set");
            Assert.AreEqual(expectedMessage, value, "Assertion Faild");
            log.Info("Assertion start");
            driver.Close();
            log.Info("driver close");
        }

        [TestMethod]
        [TestCategory("Logger Login")]
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
