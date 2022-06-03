using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesktopAppAutomation
{
    [TestClass]
    public class DSKAutomation : LoadDriver
    {
        public DSKAutomation()
        {
            InitializeDriver();
        }
        [TestMethod]
        public void TestAddition()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("+").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestSubtraction()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("-").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMultiplication()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("*").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestDivision()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("/").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestSin()
        {
            driver.FindElementByName("9").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("Sin").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestCos()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("0").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("Cos").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestTan()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("0").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("Tan").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestRoot()
        {
            driver.FindElementByName("3").Click();
            driver.FindElementByName("0").Click();
            driver.FindElementByName("Root").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestSqrt()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("0").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("Sqrt").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
        [TestMethod]
        public void TestPow()
        {
            driver.FindElementByName("1").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("Pow").Click();
            driver.FindElementByName("=").Click();
            driver.Close();
        }
    }
}
