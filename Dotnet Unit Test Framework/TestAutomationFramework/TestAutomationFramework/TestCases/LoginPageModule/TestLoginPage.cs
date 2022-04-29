using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TestAutomationFramework.TestCases.LoginPage.TestFunctions;
using LoadDriver;
using TestAutomationFramework.Constants;
using System.Windows.Forms;

namespace TestAutomationFramework.TestCases
{
    /// <summary>
    /// Summary description for LoginPage
    /// </summary>
    [TestClass]
    public class TestLoginPage
    {
        #region Instance Properties

        //public static string browserConnection;
        public static string url;
        //public static string username;
        //public static string password;
        //public static string locator;
        //public static string message;


        /// <summary>
        /// Object instances
        /// </summary>
        //public static LoginPageMethods loginPageMethods;

        #endregion

        #region Text Context Inititalization

        public static TestContext instance;
        public static TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        #endregion

        #region Initializations and Cleanups

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            MessageBox.Show("Ass");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            
            MessageBox.Show("Class");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }


        [TestInitialize]
        public void TestInit()
        {

        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        #endregion

        [TestMethod]
        [TestCategory("Login")]
        //[DataSource(ApplicationConstant.xmlConnectionString, @"TestAutomationFramework\DataClass\data.xml", "Automation", DataAccessMethod.Sequential)]
        [Description("successfull login test with postive test data")]
        public void TestLoginWithPositiveData001()
        {
            //browserConnection = ConfigurationManager.AppSettings.Get("ChromeBrowser");
            url = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";
            //username = TestContext.DataRow["username"].ToString();
            //password = TestContext.DataRow["password"].ToString();
            //message = TestContext.DataRow["message"].ToString();
            //locator = TestContext.DataRow["locator"].ToString();
            //loginPageMethods = new LoginPageMethods();
            LoginPageMethods loginPage = new LoginPageMethods();
            LoadDriverInitialiazer.LoadWebDriver("Chrome");
            //Console.WriteLine(url+"\n"+username+"\n"+password+"\n"+message+"\n"+message);
            loginPage.Login(url, "", "", "", "");
        }
        [TestMethod]
        public void tes()
        {
            //LoadDriverInitialiazer.LoadWebDriver(browserConnection);
            //LoginPageMethods loginPage = new LoginPageMethods();
            //loginPage.Login(url, username, password, message, locator);
        }
    }
}
