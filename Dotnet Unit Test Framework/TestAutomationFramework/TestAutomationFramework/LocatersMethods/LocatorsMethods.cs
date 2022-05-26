using LoadDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomationFramework.LoggerHandler;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.LocatersMethods
{
    public partial class LocatorsMethods : LoadDriverInitialiazer
    {
        #region Selinium Locators

        public static void SetSendKeys(By attribute, string value)
        {
            try
            {
                GetDriver().FindElement(attribute).SendKeys(value);
            }
            catch(Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
            }
        }

        public static void SetClick(By attribute)
        {
            try
            {
                GetDriver().FindElement(attribute).Click();
            }
            catch (Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
            }
        }

        public static string GetText(By attribute)
        {
            try
            {
                return GetDriver().FindElement(attribute).Text;
            }
            catch (Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
                return null;
            }
        }

        public static void RefreshPage()
        {
            try
            {
                GetDriver().Navigate().Refresh();
            }
            catch (Exception error)
            {
                LogHandler.LogHandlerObject().GetLogger().Error(error.ToString());
            }
        }

        #endregion
    }
}
