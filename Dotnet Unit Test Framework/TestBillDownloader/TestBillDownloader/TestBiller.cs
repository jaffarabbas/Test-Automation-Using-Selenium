using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using TestBillDownloader.Constants;

namespace TestBillDownloader
{
    [TestClass]
    public class TestBiller
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        public string accountNumber;
        public string customerNumber;
        public string email;
        public string mobile;

        [TestMethod]
        [Obsolete]
        [DataSource(Paths.XmlConnectionString, Paths.XmlPath, "Data", DataAccessMethod.Sequential)]
        public void TestBillDownload()
        {
            accountNumber = TestContext.DataRow["accountNumber"].ToString();
            customerNumber = TestContext.DataRow["customerNumber"].ToString();
            email = TestContext.DataRow["email"].ToString();
            mobile = TestContext.DataRow["mobile"].ToString();
            
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", Paths.DownloadPath);
            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            IWebDriver driver = new ChromeDriver(chromeOptions);

            driver.Url = "https://staging.ke.com.pk:24555/";
            driver.Manage().Window.Maximize();
            
            driver.FindElement(By.Id("txtAccNo")).SendKeys(accountNumber);
            driver.FindElement(By.Id("txtConNo")).SendKeys(customerNumber);
            driver.FindElement(By.Id("txtEmailAdd")).SendKeys(email);
            driver.FindElement(By.Id("txtMobNo")).SendKeys(mobile);
            driver.FindElement(By.Id("txtimgcode")).SendKeys(driver.FindElement(By.Id("lblCaptcha")).Text);
            driver.FindElement(By.Id("btnViewBill")).Click();
            

            driver.FindElement(By.XPath("/html/body/form[4]/div[3]/div[9]/div/table/tbody/tr[2]/td[6]/input")).SendKeys(Keys.Enter);
        }
    }
}
