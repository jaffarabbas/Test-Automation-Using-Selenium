using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAutomationFramework.Constants;
using TestAutomationFramework.Reporting;
using TestAutomationFramework.Validations;

namespace TestAutomationFramework.HelperMethod
{
    public partial class HelperMethods
    {
        public static void Wait(int miliSeconds)
        {
            try
            {
                if (Validation.CheckIntegers(miliSeconds))
                {
                    Thread.Sleep(miliSeconds);
                }
            }
            catch(Exception error)
            {
                InitializeReport.InitializeReportObject.CreateLog(Status.Error, ExtentLogger.Error + error.ToString());
            }
        }
    }
}
