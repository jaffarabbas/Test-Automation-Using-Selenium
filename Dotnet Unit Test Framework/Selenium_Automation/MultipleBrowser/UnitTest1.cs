using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MultipleBrowser
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
            driver.Url = "https://demoqa.com/browser-windows";
        }

        [TestMethod]
        public void TestMultipleBrowser01()
        {
            LoadTest();
            driver.FindElement(By.Id("windowButton")).Click();
            var handler = driver.WindowHandles;
            driver.SwitchTo().Window(handler[1]);
            string valueOfChildWindow = driver.FindElement(By.Id("sampleHeading")).Text;
            driver.SwitchTo().Window(handler[0]);
            var valueOfParent = driver.FindElement(By.ClassName("main-header")).Text;
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("document.getElementById('tabButton').innerHTML = '" + valueOfChildWindow + "';");
        }
    }
}
