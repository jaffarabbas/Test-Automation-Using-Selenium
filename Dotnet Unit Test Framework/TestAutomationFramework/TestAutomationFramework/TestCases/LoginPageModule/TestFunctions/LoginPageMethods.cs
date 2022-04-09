using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadDriver;

namespace TestAutomationFramework.TestCases.LoginPage.TestFunctions
{
    public class LoginPageMethods : LoadDriverInitialiazer
    {
        public void Login(string url,string username,string password)
        {
            driver.Url = url;
        }
    }
}
