using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Reporting;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.GlobalItems
{
    internal static class GlobalInstances
    {
        private static Dictionary<string, string> instancesDictionary = new Dictionary<string, string>(); 

        public static void SetInstancesDictionary(string key,string value)
        {
            if (!instancesDictionary.ContainsKey(key))

            {
                instancesDictionary.Add(key, value);
            }
        }

        public static Dictionary<string,string> GetInstancesDictionary()
        {
            return instancesDictionary;
        }

        public static void ClearInstancesDictionary()
        {
            instancesDictionary.Clear();
        }
    }
}
