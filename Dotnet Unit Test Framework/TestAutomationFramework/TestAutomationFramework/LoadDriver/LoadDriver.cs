using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.Constants;

namespace LoadDriver
{
    public class LoadDriverInitialiazer
    {
        public static string ExicuteBrowser;
        public static IWebDriver driver;
        public static IJavaScriptExecutor jsDriver;

        public LoadDriverInitialiazer()
        {
            
        }

        public static void LoadWebDriver()
        {
            ExicuteBrowser = ConfigurationManager.AppSettings.Get("CurrentBrowser");

            try
            {
                if (ExicuteBrowser == Browsers.ChromeBrowser)
                {
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments(ConfigurationManager.AppSettings.Get("MaximizeBrowserSize"));
                    IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
                    jsDriver = chromeDriver as IJavaScriptExecutor;
                    driver = chromeDriver;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
