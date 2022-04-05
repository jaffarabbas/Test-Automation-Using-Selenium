using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace TestProject
{
    public class Login
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            //IWebDriver driver1 = new InternetExplorerDriver();

            driver.Manage().Window.Maximize();

        }

        [Test]
        public void HotelLogin()
        {
            ////IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://adactinhotelapp.com/";

            ////IWebDriver driver1 = new InternetExplorerDriver();

            //driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("username")).SendKeys("saadsaghir");
            driver.FindElement(By.Id("password")).SendKeys("saadsaghir");

            driver.FindElement(By.Id("login")).Click();
            //Assert.Pass();
            driver.Quit();
            driver.Close();

            //Thread.Sleep(5000);
        }

        [Test]
        public void HotelLogin1()
        {

            //IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            //IWebDriver driver1 = new InternetExplorerDriver();

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("username")).SendKeys("saadsaghir");
            driver.FindElement(By.Id("password")).SendKeys("saadsaghir");

            driver.FindElement(By.Id("login")).Click();
            //Assert.Pass();
            driver.Quit();
            driver.Close();
        }
    }
}
