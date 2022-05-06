using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.LocatersMethods
{
    public partial class LocatorsMethods
    {
        #region Locator Dictionary

        /// <summary>
        /// It will return Dictionary with contains attribute of tags 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns>id:idpicker</returns>
        public static Dictionary<string, By> SetByLoacator(string tagName, string attribute)
        {
            Dictionary<string, By> locaterDictionary = new Dictionary<string, By>();
            var tagPicker = driver.FindElements(By.TagName(tagName));
            foreach (WebElement tag in tagPicker)
            {
                string dictionaryData = tag.GetAttribute(attribute).ToString();
                //validation to remove redendency in the dictionary datastructure
                bool dictionaryValidation = Validation.DictionaryValidation(locaterDictionary, dictionaryData, dictionaryData);
                if (attribute == "id")
                    SetLocaterByDictionary(dictionaryData, By.Id(dictionaryData), dictionaryValidation, locaterDictionary);
                else if (attribute == "class")
                    SetLocaterByDictionary(dictionaryData, By.ClassName(dictionaryData), dictionaryValidation, locaterDictionary);
            }
            return locaterDictionary;
        }

        //function to add locator in dictionary
        public static void SetLocaterByDictionary(string key, By value, bool validation, Dictionary<string, By> locaterDictionary)
        {
            if (validation)
                locaterDictionary.Add(key, value);
        }

        //clear the dictionary
        public static void ClearDictionary(Dictionary<string, By> locaterDictionary)
        {
            locaterDictionary.Clear();
        }

        #endregion
    }
}
