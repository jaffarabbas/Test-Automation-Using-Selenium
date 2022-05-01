using LoadDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAutomationFramework.LocatersMethods
{
    public class LocatorsMethods : LoadDriverInitialiazer
    {
        /// <summary>
        /// It will return Dictionary with contains attribute of tags 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns>id:idpicker</returns>
        public static Dictionary<string,By> SetByLoacator(string tagName,string attribute)
        {
            Dictionary<string, By> locaterDictionary = new Dictionary<string, By>();
            var tagPicker = driver.FindElements(By.TagName(tagName));
            foreach(WebElement tag in tagPicker)
            {
                if(attribute == "id")
                {
                    locaterDictionary.Add(tag.GetAttribute(attribute).ToString(),By.Id(tag.GetAttribute(attribute).ToString()));
                }
            }
            return locaterDictionary;
        }

        public static void SetSendKeys(By attribute,string value)
        {
            driver.FindElement(attribute).SendKeys(value);
        }

        public static void SetClick(By attribute)
        {
            driver.FindElement(attribute).Click();
        }

        public static string GetText(By attribute)
        {
            return driver.FindElement(attribute).Text;
        }
    }
}
