using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationUsingSelenium_1
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
        [TestCategory("Login")]
        public void TestMethod001()
        {
            LoadTest();
            driver.FindElement(By.Id("username")).SendKeys("JaffarAbbas");
            driver.FindElement(By.Name("password")).SendKeys("JaffarAbbas");
            driver.FindElement(By.ClassName("login_button")).Click();
            //driver.Close();
        }

        [TestMethod]
        public void TestMethod002()
        {
        }
    }
}
