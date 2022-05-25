using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.Constants;

namespace LoadDriver
{
    public partial class LoadDriverInitialiazer
    {
        /// <summary>
        /// Dictionary that store browser driver 
        /// </summary>
        private static Dictionary<string, dynamic> BrowserDriver = new Dictionary<string, dynamic>();
        /// <summary>
        /// Set browsers to the dictionary
        /// </summary>
        /// <param name="browserOptions"></param>
        private static void SetBrowserDriver(dynamic browserOptions)
        {
            BrowserDriver.Add(Browsers.ChromeBrowser, new ChromeDriver());
            BrowserDriver.Add(Browsers.FireFoxBrowser, new FirefoxDriver());
        }
    }
}
