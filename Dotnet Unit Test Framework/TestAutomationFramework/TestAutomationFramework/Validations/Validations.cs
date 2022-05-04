using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Validations
{
    public class Validation
    {
        public static bool DictionaryValidation<T>(Dictionary<string, T> dictionary, string key, dynamic value)
        {
            return !dictionary.ContainsKey(key) && value != null && value != "";
        }
    }
}
