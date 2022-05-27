﻿using System;
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

namespace TestAutomationFramework.TestCases.LoginPage.TestFunctions
{
    public class LoginPageMethods : LoadDriverInitialiazer
    {
        public void Login(Dictionary<string,string> attributes)
        {
            try
            {
                LocatorsMethods.RefreshPage();
                var loginLocators = LocatorsMethods.SetByLoacator("input", "id");
                LocatorsMethods.SetSendKeys(loginLocators["txtUsername"], attributes["username"]);
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild(attributes["username"]));
                LocatorsMethods.SetSendKeys(loginLocators["txtPassword"], attributes["password"]);
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.EnterInTextFeild(attributes["password"]));
                LocatorsMethods.SetClick(loginLocators["btnLogin"]);
                InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.CLickedButton(loginLocators["btnLogin"].ToString()));
                LocatorsMethods.ClearDictionary(LocatorsMethods.SetByLoacator("input", "id"));
                LocatorsMethods.ClearDictionary(loginLocators);
            }
            catch (Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }

        public void LogOut()
        {
            LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["welcomeDropdownById"]);
            InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.CLickedButton(LocatorsMethods.GetLocater()["welcomeDropdownById"].ToString()));
            Thread.Sleep(2000);
            LocatorsMethods.SetClick(LocatorsMethods.GetLocater()["logoutBtnXpath"]);
            InitializeReport.InitializeReportObject.CreateInfo(ExtentActions.CLickedButton(LocatorsMethods.GetLocater()["logoutBtnXpath"].ToString()));
        }

        public string CheckAssertionMessage(Dictionary<string, string> attributes,string testcase)
        {
            #region Login assertion

            if (testcase == LoginTestMetaData.TestCase001.LoginCategory)
            {
                if (Validation.CheckTestData(attributes["testData"]))
                {
                    return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["dashboardByXpath"]);
                }
                else
                {
                    return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["invalidById"]);
                }
            }


            #endregion

            #region Logout asserion

            if (testcase == LoginTestMetaData.TestCase002.LoginCategory)
            {
                return LocatorsMethods.GetText(LocatorsMethods.GetLocater()["loginPanelTextById"]);
            }

            #endregion

            return null;
        }
    }
}