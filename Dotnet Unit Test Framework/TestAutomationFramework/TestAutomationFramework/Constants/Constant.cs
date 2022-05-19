﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        /// xml tag name
        /// </summary>
        public const string TestCasesOfLogin = "Login";
        public const DataAccessMethod AccessMethod = DataAccessMethod.Sequential;
        #endregion

        #region AUT (Application Under Test) Urls

        public const string MainUrl = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";

        #endregion
    }
}
