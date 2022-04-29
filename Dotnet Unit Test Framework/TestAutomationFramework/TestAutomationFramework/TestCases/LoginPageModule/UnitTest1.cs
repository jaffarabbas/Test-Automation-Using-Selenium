using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace TestAutomationFramework.TestCases.LoginPageModule
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
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "Login", DataAccessMethod.Sequential)]
        [Description("Test Login with Data driven from xml file data.xml")]
        [TestCategory("XML Driven Login")]
        public void TestMethod1()
        {
            string username = "";
            string password = "";
            string message = "";
            string locator = "";
            LoadTest();
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.ClassName("login_button")).Click();
            string messageValue = driver.FindElement(By.ClassName(locator)).Text;
            Assert.AreEqual(message, messageValue, "Assert Failed");
            driver.Close();
        }
    }
}
