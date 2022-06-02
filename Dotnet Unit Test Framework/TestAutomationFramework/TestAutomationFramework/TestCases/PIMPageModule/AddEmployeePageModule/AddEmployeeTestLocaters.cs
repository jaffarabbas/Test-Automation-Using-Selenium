using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.LocatersMethods;

namespace TestAutomationFramework.TestCases.PIMPageModule.AddEmployeePageModule
{
    public partial class AddEmployeePageTestCases
    {
        private static void SetAddEmployeeLocaters()
        {
            LocatorsMethods.SetLocater("clickPIMById", By.XPath("//*[@id='menu_pim_viewPimModule']"));
            LocatorsMethods.SetLocater("clickAddEmployeeById", By.Id("menu_pim_addEmployee"));
            LocatorsMethods.SetLocater("setDropdownStatusById", By.Id("status"));
            LocatorsMethods.SetLocater("getTextAfterAddEmployee", By.XPath("//*[@id='pdMainContainer']/div[1]/h1"));
            LocatorsMethods.SetLocater("getTextAfterInvalidTest",By.XPath("//*[@id='content']/div/div[1]/h1"));
        }
    }
}
