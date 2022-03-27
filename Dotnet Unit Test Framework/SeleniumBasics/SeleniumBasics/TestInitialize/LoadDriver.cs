using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasics.TestInitialize
{
    public class LoadDriver
    {
        private static LoadDriver driver = new LoadDriver();
        public IWebDriver webDriver;
        public IJavaScriptExecutor js;
        public LoadDriver(){}
        /// <summary>
        /// Single ton pattern for initialize only one object of load driver class
        /// </summary>
        public static LoadDriver InitializeDriver()
        {
            return driver;
        }
        /// <summary>
        /// Run Url for driver and exicute web drivers
        /// </summary>ss
        public void RunDriver(String url)
        {
            webDriver = new ChromeDriver();
            js = webDriver as IJavaScriptExecutor;
            webDriver.Url = url;
        }
    }
}
