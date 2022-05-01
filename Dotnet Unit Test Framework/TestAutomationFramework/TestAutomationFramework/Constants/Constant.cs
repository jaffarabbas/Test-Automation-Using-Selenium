using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Constants
{
    public class ApplicationConstant
    {
        #region XML Constants

        /// <summary>
        /// xml connection string for data driven
        /// </summary>
        public const string xmlConnectionString = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        /// <summary>
        /// xml path for data driven
        /// </summary>
        public const string xmlPath = @"J:\Github\Test-Automation-Using-Selenium\Dotnet Unit Test Framework\TestAutomationFramework\TestAutomationFramework\DataClass\data.xml";

        #endregion

        #region AUT (Application Under Test) Urls

        public const string mainUrl = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";

        #endregion
    }
}
