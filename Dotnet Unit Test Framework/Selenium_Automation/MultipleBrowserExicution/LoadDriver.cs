using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleBrowserExicution
{
    public class LoadDriver
    {
        public IWebDriver driver;
        //private string ExecutionBrowser = ConfigurationManager.AppSettings.Get("ExecutionBrowser");

        public void InitializeDriver(string browser)
        {
            if(browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "FireFox")
            {
                //FirefoxOptions options = new FirefoxOptions();
                //options.AddArguments("--headless");
                driver = new FirefoxDriver();
            }
        }
    }
}
