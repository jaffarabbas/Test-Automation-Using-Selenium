using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.LocatersMethods;

namespace TestAutomationFramework.TestCases.LoginPageModule
{
    public partial class LoginPageTestCases
    {
        public static void SetLoginLocaters()
        {
            LocatorsMethods.SetLocater("dashboardByXpath", By.XPath("//*[@id='content']/div/div[1]/h1"));
            LocatorsMethods.SetLocater("invalidById",By.Id("spanMessage"));
        }
    }
}
