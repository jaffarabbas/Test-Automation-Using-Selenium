using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.GlobalItems
{
    internal static class GlobalInstances
    {
        private static Dictionary<string, string> instancesDictionary = new Dictionary<string, string>(); 

        public static void SetInstancesDictionary(string key,string value)
        {
            if (Validation.DictionaryValidation(instancesDictionary, key, value))
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
