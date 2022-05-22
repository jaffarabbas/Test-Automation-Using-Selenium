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
            GetDriver().FindElement(attribute).SendKeys(value);
        }

        public static void SetClick(By attribute)
        {
            GetDriver().FindElement(attribute).Click();
        }

        public static string GetText(By attribute)
        {
            return GetDriver().FindElement(attribute).Text;
        }

        public static void RefreshPage()
        {
            GetDriver().Navigate().Refresh();
        }

        #endregion
    }
}
