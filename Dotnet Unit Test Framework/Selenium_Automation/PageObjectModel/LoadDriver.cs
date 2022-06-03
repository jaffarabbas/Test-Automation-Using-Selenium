using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class LoadDriver
    {
        public static IWebDriver driver;
        public LoadDriver()
        {
            driver = new ChromeDriver();
        }
        public static void LoadTest()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
        }
    }
}
