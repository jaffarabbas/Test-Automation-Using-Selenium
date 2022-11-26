using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.ConfigrationMethods
{
    public class ConfigureArrayScrapper
    {
        public static string[] GetConfigrationArray(string configrationArray)
        {
            return configrationArray != null ? ConfigurationManager.AppSettings[configrationArray].Split(',') : new string[]  { "" };
        }
    }
}
