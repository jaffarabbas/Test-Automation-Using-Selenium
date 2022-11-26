using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Constants;
using TestAutomationFramework.LoggerHandler;

namespace LoadDriver
{
    public partial class LoadDriverInitialiazer
    {
        private static string ExicuteBrowser;
        private static IWebDriver driver;
        private static IJavaScriptExecutor jsDriver;

        /// <summary>
        /// getter function for driver
        /// </summary>
        /// <returns></returns>
        protected static IWebDriver GetDriver()
        {
            return driver;
        }

        /// <summary>
        /// getter function for js driver
        /// </summary>
        /// <returns></returns>
        protected static IJavaScriptExecutor GetJsDriver()
        {
            return jsDriver;
        }

        /// <summary>
        /// set driver url 
        /// </summary>
        /// <param name="url"></param>
        private static void SetDriverUrl(string url)
        {
            driver.Url = url;
        }

        /// <summary>
        /// Close driver
        /// </summary>
        public static void CloseDriver()
        {
            driver.Close();
        }

        /// <summary>
        /// Load driver dynamically only by a keyword e.g Chrome it will intialize chrome driver
        /// with it options dynamiclly 
        /// </summary>
        public static void LoadWebDriver()
        {
            //Set keyword for browser initialization
            ExicuteBrowser = ConfigurationManager.AppSettings.Get(Settings.CurrentBrowser);
            try
            {
                //set browser 
                //SetBrowserDriver(SetBrowserOptions(ExicuteBrowser));
                if(ExicuteBrowser == Browsers.ChromeBrowser)
                {
                    driver = new ChromeDriver(SetBrowserOptions(ExicuteBrowser));
                }
                else if(ExicuteBrowser == Browsers.FireFoxBrowser)
                {
                    driver = new FirefoxDriver(SetBrowserOptions(ExicuteBrowser));
                }
                SetDriverUrl(ConfigurationManager.AppSettings.Get(Settings.MainUrl));
                //foreach (var browser in BrowserDriver)
                //{
                //    MessageBox.Show(browser.Key.ToString());
                //    if (browser.Key == ExicuteBrowser)
                //    {
                //        MessageBox.Show(browser.Value);
                //        driver = browser[ExicuteBrowser];
                //        SetDriverUrl(ConfigurationManager.AppSettings.Get(Settings.MainUrl));
                //        break;
                //    }
            //}
            }catch(Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
            }
        }
    }
}
