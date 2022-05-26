﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Constants
{
    public class LoginTestMetaData
    {
        public class TestCase001
        {
            /// <summary>
            /// priority of the test case
            /// </summary>
            public const int Priority = 1;
            /// <summary>
            /// category of the test case
            /// </summary>
            public const string LoginCategory = "Login";
            /// <summary>
            /// Owner of the test case
            /// </summary>
            public const string Owner = "Jaffar";
            /// <summary>
            /// Description of the test case
            /// </summary>
            public const string Description = "successfull login test with postive test data and negative test data and get Welcome string from dashboard and val;idation message from login";
        }
        public class TestCase002
        {
            /// <summary>
            /// priority of the test case
            /// </summary>
            public const int Priority = 1;
            /// <summary>
            /// category of the test case
            /// </summary>
            public const string LoginCategory = "Login";
            /// <summary>
            /// Owner of the test case
            /// </summary>
            public const string Owner = "Jaffar";
            /// <summary>
            /// Description of the test case
            /// </summary>
            public const string Description = "successfull logout test";
        }
    }
}
