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

namespace TestAutomationFramework.TestCases.PIMPageModule.AddEmployeePageModule.TestFunctions
{
    public class AddEmployeePageMethods : LoadDriverInitialiazer
    {
       
        public void AddEmployee(Dictionary<string, string> attributes)
        {
            try
            {
                LocatorsMethods.RefreshPage();
                //click navigation button
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["clickPIMById"]);
                LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["clickAddEmployeeById"]);
                HelperMethods.Wait(WaitTime.standerdWait);
                var addEmployeeLocators = LocatorsMethods.SetByLoacator("input", "id");
                HelperMethods.SetDictionaryScrapperLog(addEmployeeLocators);

                #region Fill Add Employee Form

                LocatorsMethods.SetSendKeys(addEmployeeLocators["firstName"], attributes["firstname"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["middleName"], attributes["middlename"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["lastName"], attributes["lastname"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["photofile"], attributes["profile"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["photofile"], attributes["profile"]);
                LocatorsMethods.SetClick(addEmployeeLocators["chkLogin"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["user_name"], attributes["newUsername"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["user_password"], attributes["userPassword"]);
                LocatorsMethods.SetSendKeys(addEmployeeLocators["re_password"], attributes["confirmPassowrd"]);
                LocatorsMethods.SetSendKeys(LocatorsMethods.GetLocater()["setDropdownStatusById"], attributes["statusDropdown"]);
                LocatorsMethods.SetClick(addEmployeeLocators["btnSave"]);

                #endregion
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        public string CheckAssertionMessage(Dictionary<string, string> attributes, string testcase)
        {
            if (testcase == AddEmployeeMetaData.TestCase001.Category)
            {
                if (Validation.CheckTestData(attributes["testData"]))
                {
                    return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["personal_txtEmpFirstName"]);
                }
                else
                {
                    return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["getTextAfterInvalidTest"]);
                }
            }
            return null;
        }

        #region ExtentReports Singleton Object

        private static AddEmployeePageMethods addEmployeePageMethodsObjects;

        public static AddEmployeePageMethods AddEmployeePageMethodsObjects
        {
            get
            {
                if (addEmployeePageMethodsObjects == null)
                {

                    addEmployeePageMethodsObjects = new AddEmployeePageMethods();
                }
                return addEmployeePageMethodsObjects;
            }
            set
            {
                addEmployeePageMethodsObjects = value;
            }
        }

        #endregion
    }
}
