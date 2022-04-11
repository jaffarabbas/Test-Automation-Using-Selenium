using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_Class_Practice;

namespace Tester
{
    [TestClass]
    [TestCategory("Calculator")]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionWithWorngInput()
        {
            Class1 o = new Class1();
            int value = o.add(4, 5);
            int expectedValue = 5;
            Assert.AreEqual(expectedValue, value);
        }


        [TestMethod]
        public void AdditionWithRightInput()
        {
            Class1 o = new Class1();
            int value = o.add(4, 5);
            int expectedValue = 9;
            Assert.AreEqual(expectedValue, value);
        }
    }
}
