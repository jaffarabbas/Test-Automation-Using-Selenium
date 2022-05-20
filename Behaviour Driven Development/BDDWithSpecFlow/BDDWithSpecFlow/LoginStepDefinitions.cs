using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDDWithSpecFlow
{
    [Binding]
    public class LoginStepDefinitions
    {
        IWebDriver driver;
        public LoginStepDefinitions()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
        }

        [Given(@"Enter Username ""([^""]*)""")]
        public void GivenEnterUsername(string jaffarabbas)
        {
            driver.FindElement(By.Id("username")).SendKeys(jaffarabbas);
        }

        [Given(@"Enter Passowrd ""([^""]*)""")]
        public void GivenEnterPassowrd(string jaffarabbas)
        {
            driver.FindElement(By.Name("password")).SendKeys(jaffarabbas);
        }

        [When(@"When username and password entered Click login button")]
        public void WhenWhenUsernameAndPasswordEnteredClickLoginButton()
        {
            driver.FindElement(By.ClassName("login_button")).Click();
        }

        [Then(@"check welcome message and assert it")]
        public void ThenCheckWelcomeMessageAndAssertIt()
        {
            string value = driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", value, "Assertion Faild");
        }
    }
}
