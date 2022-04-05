using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        public void Setup()
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";

            //IWebDriver driver1 = new InternetExplorerDriver();

            driver.Manage().Window.Maximize();

        }
        [TestMethod]
        public void TestMethod1()
        {
            Setup();

            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");

            driver.FindElement(By.Id("login-button")).Click();
            //drawer button
            driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            //logout
            driver.FindElement(By.Id("logout_sidebar_link")).Click();
            //Assert.Pass();
            driver.Quit();
            driver.Close();
        }
    }
}
