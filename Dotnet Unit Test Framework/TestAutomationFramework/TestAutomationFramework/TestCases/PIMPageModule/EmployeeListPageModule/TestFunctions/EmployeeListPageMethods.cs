using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestAutomationFramework.LocatersMethods;
using TestAutomationFramework.LoggerHandler;
using TestAutomationFramework.Validations;
using TestAutomationFramework.Constants;
using TestAutomationFramework.Reporting;
using AventStack.ExtentReports;
using TestAutomationFramework.HelperMethod;

namespace TestAutomationFramework.TestCases.PIMPageModule.EmployeeListPageModule.TestFunctions
{
    public class EmployeeListPageMethods : LoadDriverInitialiazer
    {
        public void EmployeeList(Dictionary<string, string> attributes)
        {
            try
            {
                LocatorsMethods.RefreshPage();
                //click navigation button
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["clickPIMByIdFromList"]);
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["clickEmployeeList"]);
                HelperMethods.Wait(WaitTime.standerdWait);
                LocatorsMethods.SetSendKeys(LocatorsMethods.GetLocater()["empsearch_employee_name_empName"], attributes["searchName"]);
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["searchBtn"]);
                HelperMethods.Wait(WaitTime.standerdWait);
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["ohrmList_chkSelectAll"]);
                HelperMethods.Wait(WaitTime.standerdWait);
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["btnDelete"]);
                HelperMethods.Wait(WaitTime.standerdWait);
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["dialogDeleteBtn"]);
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        #region ExtentReports Singleton Object

        private static EmployeeListPageMethods employeeListPageMethodsObjects;

        public static EmployeeListPageMethods EmployeeListPageMethodsObjects
        {
            get
            {
                if (employeeListPageMethodsObjects == null)
                {

                    employeeListPageMethodsObjects = new EmployeeListPageMethods();
                }
                return employeeListPageMethodsObjects;
            }
            set
            {
                employeeListPageMethodsObjects = value;
            }
        }

        #endregion
    }
}
