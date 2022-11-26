using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.ConfigrationMethods;
using TestAutomationFramework.Constants;

namespace LoadDriver
{
    public partial class LoadDriverInitialiazer
    {
        /// <summary>
        /// Browser option object
        /// </summary>
        private static Dictionary<string, dynamic> browserOptionObjects = new Dictionary<string, dynamic>();

        /// <summary>
        /// Set Browser in Dictionary
        /// </summary>
        private static void SetBrowserDictionary()
        {
            browserOptionObjects.Add(BrowserOptions.ChromeOptions, new ChromeOptions());
            browserOptionObjects.Add(BrowserOptions.FireFoxOptions, new FirefoxOptions());
        }
        /// <summary>
        /// A generaize function for setting browser arguments
        /// </summary>
        /// <param name="browser"></param>
        /// <returns></returns>
        private static dynamic SetBrowserOptions(string browser)
        {
            //set browsers dictionary
            SetBrowserDictionary();
            //itrating broswer from dictionary
            foreach (var browserValue in browserOptionObjects)
            {
                //selecting browser from parameter 
                if(browserValue.Key == browser)
                {
                    //adding configration with respect to browser
                    foreach (var options in ConfigureArrayScrapper.GetConfigrationArray(browserValue.Key))
                    {
                        browserValue.Value.AddArguments(options);
                    }
                    return browserValue.Value;
                }
            }
            return null;
        }
    }
}
