using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.LocatersMethods;

namespace TestAutomationFramework.TestCases.LoginPageModule
{
    public partial class EmployeeListPageTestCases
    {
        private static void SetEmployeeListLocaters()
        {
            LocatorsMethods.SetLocater("clickPIMByIdFromList", By.XPath("//*[@id='menu_pim_viewPimModule']"));
            LocatorsMethods.SetLocater("clickEmployeeList",By.XPath("//*[@id='menu_pim_viewEmployeeList']"));
            LocatorsMethods.SetLocater("empsearch_employee_name_empName", By.Id("empsearch_employee_name_empName"));
            LocatorsMethods.SetLocater("searchBtn", By.Id("searchBtn"));
            LocatorsMethods.SetLocater("ohrmList_chkSelectAll", By.Id("ohrmList_chkSelectAll"));
            LocatorsMethods.SetLocater("btnDelete", By.Id("btnDelete")); 
            LocatorsMethods.SetLocater("dialogDeleteBtn", By.Id("dialogDeleteBtn")); 
        }
    }
}
