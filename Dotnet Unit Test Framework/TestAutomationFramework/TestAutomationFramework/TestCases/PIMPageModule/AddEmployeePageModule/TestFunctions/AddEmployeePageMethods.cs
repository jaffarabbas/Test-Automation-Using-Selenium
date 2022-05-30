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

namespace TestAutomationFramework.TestCases.PIMPageModule.AddEmployeePageModule.TestFunctions
{
    public class AddEmployeePageMethods : LoadDriverInitialiazer
    {
       
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
