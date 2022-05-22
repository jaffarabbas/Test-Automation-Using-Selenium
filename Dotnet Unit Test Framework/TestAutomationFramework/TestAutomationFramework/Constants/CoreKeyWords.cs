using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Constants
{
    public class Browsers
    {
        public static string ChromeBrowser = "Chrome";
        public static string FireFoxBrowser = "Chrome";
        public static string EdgeBrowser = "Chrome";
    }

    public class BrowserOptions
    {
        public static string ChromeOptions = "Chrome";
    }

    public class Locaters
    {
        public static string ById = "id";
        public static string ByClass = "class";
        public static string ByName = "name";   
        public static string ByXPath = "xpath";
        public static string ByUrl = "url"; 
        public static string ByTitle = "title"; 
        public static string ByDescription = "description";
    }

    public class TestData
    {
        public static string PositiveTestData = "positive";
        public static string NegativeTestData = "negative";
    }

    public class Errors
    {
        public static string AssertionFailed = "Assertion Failed";
    }

    public class Settings 
    {
        public static string CurrentBrowser = "CurrentBrowser";
        public static string MainUrl = "MainUrl";
    }
}
