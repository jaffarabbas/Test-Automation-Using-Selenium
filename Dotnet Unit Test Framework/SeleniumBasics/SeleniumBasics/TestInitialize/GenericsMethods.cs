using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasics.TestInitialize
{
    public class GenericsMethods
    {
        public void SendValue(By id, string value,IWebDriver wbDriver)
        {
            wbDriver.FindElement(id).SendKeys(value);
        }
    }
}
