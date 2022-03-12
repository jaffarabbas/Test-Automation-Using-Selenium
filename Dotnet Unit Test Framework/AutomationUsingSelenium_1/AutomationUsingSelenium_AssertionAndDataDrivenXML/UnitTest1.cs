using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace AutomationUsingSelenium_AssertionAndDataDrivenXML
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
            driver.Url = "https://adactinhotelapp.com/";
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
            MessageBox.Show("Assembly Initialization");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("Assembly CleanUp");
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            MessageBox.Show("Class Initialization");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("Class CleanUp");
        }


        [TestInitialize]
        public void TestInit()
        {
            MessageBox.Show("Test Initialization");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            MessageBox.Show("Test CleanUp");
        }

        #endregion
        
        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",@"data.xml","Login",DataAccessMethod.Sequential)]
        [Description("Test Login with Data driven from xml file data.xml")]
        [TestCategory("XML Driven Login")]
        public void TestMethod1()
        {
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            LoadTest();
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.ClassName("login_button")).Click();
            string messageValue = driver.FindElement(By.ClassName(locator)).Text;
            Assert.AreEqual(message, messageValue,"Assert Failed");
            driver.Close();
        }
    }
}
