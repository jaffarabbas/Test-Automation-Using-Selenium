using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OpenQaTest
{
    [TestClass]
    public class ValidateForm
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        public ValidateForm()
        {
            driver = new ChromeDriver();
            js = driver as IJavaScriptExecutor;
        }
        //load gernel url and global custom functons
        public void LoadTest()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/automation-practice-form";
        }

        #region Feilds functions
        public void SendValue(string id, string value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }
        public void TestNameFeilds(string firstname, string lastname)
        {
            SendValue("firstName", firstname);
            SendValue("lastName", lastname);
        }

        public void TestDatePicker(DateTime date)
        {
            //other method is using javascript exicutor
            //driver.FindElement(By.Id("dateOfBirthInput")).Click();
            //js.ExecuteScript("document.getElementById('dateOfBirthInput').value = null;");
            //SendValue("dateOfBirthInput",date);
            driver.FindElement(By.Id("dateOfBirthInput")).Click();
            driver.FindElement(By.CssSelector(".react-datepicker__month-select")).SendKeys(date.Month.ToString());
            driver.FindElement(By.CssSelector(".react-datepicker__year-select")).SendKeys(date.Year.ToString());
            driver.FindElement(By.CssSelector(".react-datepicker__day--017")).Click();

        }

        public void TestRCButton(string id)
        {
            IWebElement Button = driver.FindElement(By.Id(id));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(Button).Perform();
            // other method is using javascript exicutor
            js.ExecuteScript("arguments[0].click();", Button);
        }

        public void TestNumberFeild(string number)
        {
            SendValue("userNumber", number);
        }

        public void TestDropDown(string id, string value)
        {
            WebElement Selecter = (WebElement)driver.FindElement(By.Id(id));
            Selecter.SendKeys(value);
            Selecter.SendKeys(Keys.Enter);
        }

        public void TestCurrentAddress(string value)
        {
            SendValue("currentAddress", value);
        }

        public void TestFilePicker(string id, string url)
        {
            var filePicker = driver.FindElement(By.Id(id));
            filePicker.SendKeys(url);
        }

        #endregion

        [TestMethod]
        public void ValidateFormWithEmptyFeildsTC001()
        {
            LoadTest();
            //name feilds
            TestNameFeilds("Jaffar", "Abbas");
            //email
            driver.FindElement(By.Id("userEmail")).SendKeys("gamaportal8@gmail.com");
            //radio button
            TestRCButton("gender-radio-1");
            //number
            TestNumberFeild("1234567891");
            //Date 
            TestDatePicker(DateTime.Now);
            //Subject
            TestDropDown("subjectsInput", "English");
            //Check boxes
            TestRCButton("hobbies-checkbox-1");
            //File picker
            TestFilePicker("uploadPicture", @"C:\Users\gamap\Pictures\aboutPic1.png");
            //Address
            TestCurrentAddress("askldjaslkdjlkasjdlkaksjdlkasjdlkasd");
            //Dropdown
            TestDropDown("react-select-3-input", "Uttar Pradesh");
            TestDropDown("react-select-4-input", "Agra");
            //submit
            driver.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
            //testing
            string value = "Thanks for submitting the form";
            string actualValue = driver.FindElement(By.Id("example-modal-sizes-title-lg")).Text;
            Assert.AreEqual(value, actualValue);
        }
    }
}
