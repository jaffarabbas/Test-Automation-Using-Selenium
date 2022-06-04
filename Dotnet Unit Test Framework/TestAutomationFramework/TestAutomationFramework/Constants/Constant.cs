using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public const string XmlConnectionString = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        /// <summary>
        /// xml path for data driven
        /// </summary>
        public const string XmlPath = @"J:\Github\Test-Automation-Using-Selenium\Dotnet Unit Test Framework\TestAutomationFramework\TestAutomationFramework\DataClass\data.xml";
        /// <summary>
        /// traversing method
        /// </summary>
        public const DataAccessMethod AccessMethod = DataAccessMethod.Sequential;
        
        #endregion

        #region Xml Tags

        public const string TestCasesOfLogin = "Login";
        public const string TestCasesOfLogout = "Logout";
        public const string TestCasesOfAddEmployee = "AddEmployee";
        public const string TestCasesOfEmployeeList = "EmployeeList";

        #endregion

        #region AUT (Application Under Test) Urls

        public const string MainUrl = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";

        #endregion

        #region Extent Report Contants

        public const string ReportPath = @"J:\Github\Test-Automation-Using-Selenium\Dotnet Unit Test Framework\TestAutomationFramework\TestAutomationFramework\Files\Reports\";

        public const string ReportFilename = "TestReport.html";

        #endregion
    }
}
