using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace ParellelTestExicution
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Parellel Test")]
        public void ParellelExicutionTC1()
        {
            Thread.Sleep(5000);
        }

        [TestMethod]
        [TestCategory("Parellel Test")]
        [DoNotParallelize]
        public void ParellelExicutionTC2()
        {
            Thread.Sleep(5000);
        }

        [TestMethod]
        [TestCategory("Parellel Test")]
        public void ParellelExicutionTC3()
        {
            Thread.Sleep(5000);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [TestCategory("Parellel Test")]
        public void ParellelExicutionTC1()
        {
            Thread.Sleep(5000);
        }

        [TestMethod]
        [TestCategory("Parellel Test")]
        [DoNotParallelize]
        public void ParellelExicutionTC2()
        {
            Thread.Sleep(5000);
        }

        [TestMethod]
        [TestCategory("Parellel Test")]
        public void ParellelExicutionTC3()
        {
            Thread.Sleep(5000);
        }
    }
}
