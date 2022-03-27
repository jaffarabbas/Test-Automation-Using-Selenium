using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumBasics.TestInitialize;

namespace SeleniumBasics
{
    public class Form : GenericsMethods
    {

        #region Initialize

        LoadDriver wbDriver = LoadDriver.InitializeDriver();

        Form()
        {
            wbDriver.RunDriver("https://demoqa.com/automation-practice-form");
        }

        #endregion

        #region Feilds functions
        public void TestNameFeilds(string firstname, string lastname)
        {
            SendValue(By.Id("firstName"), firstname,wbDriver.webDriver);
            SendValue(By.Id("lastName"), lastname, wbDriver.webDriver);
        }

        public void TestDatePicker(DateTime date)
        {
            //other method is using javascript exicutor
            //driver.FindElement(By.Id("dateOfBirthInput")).Click();
            //js.ExecuteScript("document.getElementById('dateOfBirthInput').value = null;");
            //SendValue("dateOfBirthInput",date);
            wbDriver.webDriver.FindElement(By.Id("dateOfBirthInput")).Click();
            wbDriver.webDriver.FindElement(By.CssSelector(".react-datepicker__month-select")).SendKeys(date.Month.ToString());
            wbDriver.webDriver.FindElement(By.CssSelector(".react-datepicker__year-select")).SendKeys(date.Year.ToString());
            wbDriver.webDriver.FindElement(By.CssSelector(".react-datepicker__day--017")).Click();

        }

        public void TestRCButton(By id)
        {
            IWebElement Button = wbDriver.webDriver.FindElement(id);
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(Button).Perform();
            // other method is using javascript exicutor
            wbDriver.js.ExecuteScript("arguments[0].click();", Button);
        }

        public void TestNumberFeild(string number)
        {
            SendValue(By.Id("userNumber"), number, wbDriver.webDriver);
        }

        public void TestDropDown(By id, string value)
        {
            WebElement Selecter = (WebElement)wbDriver.webDriver.FindElement(id);
            Selecter.SendKeys(value);
            Selecter.SendKeys(Keys.Enter);
        }

        public void TestCurrentAddress(string value)
        {
            SendValue(By.Id("currentAddress"), value, wbDriver.webDriver);
        }

        public void TestFilePicker(By id, string url)
        {
            var filePicker = wbDriver.webDriver.FindElement(id);
            filePicker.SendKeys(url);
        }

        #endregion
    }
}
