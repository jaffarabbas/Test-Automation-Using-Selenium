using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Reporting;

namespace TestAutomationFramework.HelperMethod
{
    public partial class HelperMethods
    {
        public static void SetDictionaryScrapperLog(dynamic dictionary)
        {
            foreach (var value in dictionary)
            {
                InitializeReport.InitializeReportObject.CreateInfo("Locater Scrapper : \nKey : " + value.Key.ToString() + " Value : " + value.Value.ToString());
            }
        }
    }
}
