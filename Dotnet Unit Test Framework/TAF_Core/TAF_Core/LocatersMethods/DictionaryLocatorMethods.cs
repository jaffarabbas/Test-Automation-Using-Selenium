using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Constants;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.LocatersMethods
{
    public partial class LocatorsMethods
    {
        #region Locater instances

        private static Dictionary<string, By> byLocaterDictionary = new Dictionary<string, By>();

        #endregion

        #region Locator Dictionary from tag Automated

        /// <summary>
        /// It will return Dictionary with contains attribute of tags 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns>id:idpicker</returns>
        public static Dictionary<string, By> SetByLoacator(string tagName, string attribute)
        {
            var locaterDictionary = new Dictionary<string, By>();
            var tagPicker = GetDriver().FindElements(By.TagName(tagName));
            foreach (var tag in tagPicker)
            {
                var dictionaryData = tag.GetAttribute(attribute).ToString();
                //validation to remove redendency in the dictionary datastructure
                var dictionaryValidation = Validation.DictionaryValidation(locaterDictionary, dictionaryData, dictionaryData);
                if (attribute == Locaters.ById)
                    SetLocaterByDictionary(dictionaryData, By.Id(dictionaryData), dictionaryValidation, locaterDictionary);
                else if (attribute == Locaters.ByClass)
                    SetLocaterByDictionary(dictionaryData, By.ClassName(dictionaryData), dictionaryValidation, locaterDictionary);
            }
            return locaterDictionary;
        }

        //function to add locator in dictionary
        private static void SetLocaterByDictionary(string key, By value, bool validation, Dictionary<string, By> locaterDictionary)
        {
            if (validation)
                locaterDictionary.Add(key, value);
        }

        /// <summary>
        /// CLear Locator Dictionary from tag Automated
        /// </summary>
        /// <param name="locaterDictionary"></param>
        public static void ClearDictionary(Dictionary<string, By> locaterDictionary)
        {
            locaterDictionary.Clear();
        }

        #endregion

        #region Locater Dictionary Manual

        public static void SetLocater(string key, By locater)
        {
            var dictionaryValidation = !byLocaterDictionary.ContainsKey(key) && byLocaterDictionary != null;
            if (dictionaryValidation)
                byLocaterDictionary.Add(key, locater);
            else
                throw new Exception();
        }

        public static Dictionary<string, By> GetLocater()
        {
            return byLocaterDictionary;
        }

        /// <summary>
        /// CLear Locater Dictionary Manual 
        /// </summary>
        /// <param name="locaterDictionary"></param>
        public static void ClearDictionary()
        {
            byLocaterDictionary.Clear();
        }

        #endregion
    }
}
