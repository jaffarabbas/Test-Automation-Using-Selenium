using LoadDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.LocatersMethods
{
    public partial class LocatorsMethods : LoadDriverInitialiazer
    {
        #region Selinium Locators

        public static void SetSendKeys(By attribute, string value)
        {
            driver.FindElement(attribute).SendKeys(value);
        }

        public static void SetClick(By attribute)
        {
            driver.FindElement(attribute).Click();
        }

        public static string GetText(By attribute)
        {
            return driver.FindElement(attribute).Text;
        }

        public static void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        #endregion
    }
}
