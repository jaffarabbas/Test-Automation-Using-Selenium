using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace MultipleBrowserExicution
{
    [TestClass]
    public class MultipleBrowser
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoadDriver driver = new LoadDriver();
            driver.InitializeDriver("Chrome");
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            driver.driver.Url = "https://pizzamax.com.pk/";

            driver.driver.Manage().Window.Maximize();
            WebElement dropdown = (WebElement)driver.driver.FindElement(By.Id("city-control"));
            string searchText = "Rawalpindi";
            dropdown.Click(); // assuming you have to click the "dropdown" to open it
            WebElement dropdown2 = (WebElement)driver.driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/form/div[1]/div/div[2]/ul"));
            dropdown2.FindElement(By.CssSelector("li[value=" + searchText + "]")).SendKeys(Keys.Enter);
            //var options = dropdown.FindElements(By.TagName("li"));
            //MessageBox.Show(options.Count.ToString());
            //foreach (WebElement option in options)
            //{
            //    MessageBox.Show(option.Text);
            //    if (option.Text.Equals(searchText))
            //    {
            //        MessageBox.Show("asd");
            //        option.Click(); // click the desired option
            //        break;
            //    }
            //}
        }
    }
}