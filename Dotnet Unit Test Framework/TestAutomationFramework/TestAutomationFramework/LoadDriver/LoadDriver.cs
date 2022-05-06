using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDriver
{
    public class LoadDriverInitialiazer
    {
        public static string ExicuteBrowser;
        public static IWebDriver driver;
        public static IJavaScriptExecutor jsDriver;

        public LoadDriverInitialiazer()
        {
            ExicuteBrowser = ConfigurationManager.AppSettings.Get("ChromeBrowser");
        }

        public static void LoadWebDriver()
        {
            try
            {
                if (ExicuteBrowser == "Chrome")
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
