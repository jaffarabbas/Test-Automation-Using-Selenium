using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace DropDownTesting
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
            driver.Url = "https://demoqa.com/select-menu";
        }
        [TestMethod]
        public void TestMethod1()
        {
            LoadTest();
            var element = driver.FindElement(By.Id("oldSelectMenu"));
            var selectDropDown = new SelectElement(element);

            selectDropDown.SelectByText("Green");
            selectDropDown.SelectByIndex(0);
            selectDropDown.SelectByValue("1");
        }
    }
}
