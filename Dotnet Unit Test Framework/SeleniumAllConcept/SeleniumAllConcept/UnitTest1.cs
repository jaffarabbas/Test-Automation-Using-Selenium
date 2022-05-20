using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SeleniumAllConcept
{
    [TestClass]
    public class Automation
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


        #region Test Methods

        [TestMethod, TestCategory("Login")]
        public void Login_TestCase01()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys("Test");
            driver.FindElement(By.Id("password")).SendKeys("Test");
            driver.FindElement(By.Id("login")).Click();

            driver.Close();
        }

        [TestMethod]
        public void Login_HeadlessWithScreenShot()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys("Test");
            driver.FindElement(By.Id("password")).SendKeys("Test");
            driver.FindElement(By.Id("login")).Click();


            //Take the screenshot
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            //Save the screenshot
            string ScreenShotName = @"C:/Screenshot.png";
            image.SaveAsFile(ScreenShotName, ScreenshotImageFormat.Png);

            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        public void FindElements_TC()
        {
            IWebDriver driver = new ChromeDriver();

            List<IWebElement> allRows = new List<IWebElement>(driver.FindElements(By.TagName("option")));
            foreach (IWebElement row in allRows)
            {
                if (row.Text == "Adelaide" && row != null)
                {
                    row.Click();
                }
            }
        }

        [TestMethod]
        [DataRow("AmirTester", "AmirTester")]
        [DataRow("Incorrect", "Incorrect")]
        public void Login_DataDriven(string user, string pass)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();

            driver.Close();

        }

        [TestMethod]
        [DataRow("AmirTester", "AmirTester")]
        [DataRow("Incorrect", "Incorrect")]
        [TestCategory("DataDriven"), TestCategory("Login")]
        public void Login_DataDriven_KeywordDriven(string user, string pass)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();

            driver.Close();

        }

        [TestMethod]
        [DataRow("AmirTester", "AmirTester", "Welcome to AdactIn Group of Hotels", "welcome_menu")]
        [DataRow("Incorrect", "Incorrect", "Invalid Login details or Your Password might have expired. Click here to reset your password", "auth_error")]
        public void Login_DataDriven_WithAssert(string user, string pass, string message, string locator)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();

            string text = driver.FindElement(By.ClassName(locator)).Text;
            Assert.AreEqual(message, text);
            driver.Close();

        }

        [TestMethod, TestCategory("XML"), TestCategory("DataDriven")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"Data.xml", "AutomationTraining", DataAccessMethod.Sequential)]
        public void Login_DataDriven_ExternalFileXML_WithAssert()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys(TestContext.DataRow["username"].ToString());
            driver.FindElement(By.Id("password")).SendKeys(TestContext.DataRow["password"].ToString());
            driver.FindElement(By.Id("login")).Click();

            string text = driver.FindElement(By.ClassName(TestContext.DataRow["locator"].ToString())).Text;
            Assert.AreEqual(TestContext.DataRow["message"].ToString(), text);

            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [TestMethod, TestCategory("CSV"), TestCategory("DataDriven")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void Login_DataDriven_ExternalFileCSV_WithAssert()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://adactin.com/HotelApp/";
            driver.FindElement(By.Id("username")).SendKeys(TestContext.DataRow["username"].ToString());
            driver.FindElement(By.Id("password")).SendKeys(TestContext.DataRow["password"].ToString());
            driver.FindElement(By.Id("login")).Click();

            string text = driver.FindElement(By.ClassName(TestContext.DataRow["locator"].ToString())).Text;
            Assert.AreEqual(TestContext.DataRow["message"].ToString(), text);
            driver.Close();

        }

        #endregion

        #region Selenium Code

        [TestMethod]
        public void SeleniumCode()
        {
            IWebDriver driver = new ChromeDriver();
            //Locate Element
            var element = driver.FindElement(By.Id("id"));

            // Window Manage Window Commands
            driver.Manage().Window.Maximize();
            driver.Manage().Window.Minimize();
            driver.Manage().Window.FullScreen();

            // Browser Navigations Commands
            driver.Navigate().GoToUrl("http://www.adactin.com/HotelApp/");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            // DRIVER Url Command
            driver.Url = "http://www.google.com";
            string title = driver.Title;

            //Assert
            Assert.AreEqual(title, "Expected Title");

            // DRIVER FindElement/FindElements Commands
            driver.FindElement(By.Id("username"));
            int elementsCount = driver.FindElements(By.Id("username")).Count;

            // DRIVER Actions Commands
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).Submit();

            //Enter Text Using Javascript
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].value ='" + "EnteredText" + "';", element);

            //Actions
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();        //Move To Element
            action.DoubleClick(element).Perform();                  //Double Click Element
            action.ContextClick(element).Perform();                 //Right Click Element
            element.Clear();                                        //Clear Element
            element.Click();                                        //Click Element
            element.SendKeys("Test123");                            //Enter Text



            // DropDown Select by Text,Value,Index
            var selectdrpdown = new SelectElement(element);
            selectdrpdown.SelectByText("SelectedText");
            selectdrpdown.SelectByValue("SelectedText");
            selectdrpdown.SelectByIndex(0);

            // DropDown DeSelect by Text,Value,Index
            var deSelectdrpdown = new SelectElement(element);
            deSelectdrpdown.SelectByText("DeSelectedText");
            deSelectdrpdown.SelectByValue("DeSelectedText");
            deSelectdrpdown.SelectByIndex(0);

            // CheckBox checked
            if (!element.Selected)
            {
                if (element.GetAttribute("checked") == null)
                {
                    element.Click();
                }
            }


            // Get Element Text
            element.GetAttribute("value");
            element.GetAttribute("text");
            element.GetAttribute("innerHTML");


            // Element State
            string elementState = element.GetAttribute("Disabled");
            if (elementState == null)
            {
                elementState = "enabled";
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
            }


            // Scroll Top or Bottom
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document." + "headOrBody" + ".scrollHeight);");

            //Scroll To Element
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);


            // Browser Tab Switch
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //Window Switch
            var handlers = driver.WindowHandles;
            foreach (var handler in handlers)
            {
                driver.SwitchTo().Window(handler);
                driver.Url.Contains("textContains");
                driver.Title.Contains("textContains");
            }


            // TabOut From Element
            element.SendKeys("{Tab}");

            // Switch to IFrame index/frameName/FrameElement
            driver.SwitchTo().Frame(1);
            driver.SwitchTo().Frame("Name");
            driver.SwitchTo().Frame(element);

            //Switch to Default Content
            driver.SwitchTo().DefaultContent();

            // Switch to Alert
            IAlert alert = driver.SwitchTo().Alert();


            // DRIVER Tear Down Commands
            driver.Close();    // Close the browser window that the driver has focus of
            driver.Quit();     // Quits all browser windows and Calls Dispose()
            driver.Dispose();  // Closes all browser windows and safely ends the session

        }


        [TestMethod]
        public void ChromeOptionHeadless()
        {
            IWebDriver driver;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            driver = new ChromeDriver(chromeOptions);
            driver.Url = "http://www.google.com";
            driver.Close();
        }

        [TestMethod]
        public void ChromeOptionIncognito()
        {
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

            driver.Url = "http://www.google.com";
            driver.Close();
        }
        #endregion
    }
}
