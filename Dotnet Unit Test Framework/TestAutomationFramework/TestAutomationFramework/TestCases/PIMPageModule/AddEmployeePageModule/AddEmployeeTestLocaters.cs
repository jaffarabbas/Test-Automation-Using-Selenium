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
            LocatorsMethods.SetLocater("clickPIMById", By.Id("menu_recruitment_viewJobVacancy"));
            LocatorsMethods.SetLocater("clicAddEmployeeById", By.Id("menu_pim_addEmployee"));
        }
    }
}
