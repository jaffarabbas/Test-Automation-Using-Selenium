using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestEfrotech
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        public UnitTest1()
        {
            driver = new ChromeDriver();
        }
        public void LoadTest()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "";
        }
        #region Initializations and Cleanups

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
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

        public void CLickattendance()
        {
            driver.FindElement(By.XPath("/html/body/form/div[3]/header/nav/div[1]/div[2]/ul/li[2]/ul/li[1]/a")).Click();
            driver.FindElement(By.XPath("/html/body/form/div[3]/header/nav/div[1]/div[2]/ul/li[2]/ul/li[1]/ul/li[1]/a")).Click();
        }

        public void CLickLeave()
        {
            driver.FindElement(By.XPath("/html/body/form/div[3]/header/nav/div[1]/div[2]/ul/li[2]/ul/li[2]/a")).Click();
            driver.FindElement(By.XPath("/html/body/form/div[3]/header/nav/div[1]/div[2]/ul/li[2]/ul/li[2]/ul/li[2]/a")).Click();
        }
        public void ClickDropDown(String module)
        {
            driver.FindElement(By.XPath("/html/body/form/div[3]/header/nav/div[1]/div[2]/ul/li[2]/a")).Click();
            if(module == "attendance")
            {
                CLickattendance();
            }else if(module == "leave")
            {
                CLickLeave();
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            //string password = TestContext.DataRow["password"].ToString();
            //string message = TestContext.DataRow["message"].ToString();
            //string locator = TestContext.DataRow["locator"].ToString();
            LoadTest();
            driver.FindElement(By.Id("txtPin")).SendKeys("");
            driver.FindElement(By.Id("txtUserName")).SendKeys("");
            driver.FindElement(By.Id("txtPassword")).SendKeys("");
            driver.FindElement(By.Id("btnLogin")).Click();

            ClickDropDown("attendance");
            ClickDropDown("leave");
            Thread.Sleep(5000);
            //string messageValue = driver.FindElement(By.ClassName(locator)).Text;
            //Assert.AreEqual(message, messageValue, "Assert Failed");
            driver.Close();

        }
    }
}
