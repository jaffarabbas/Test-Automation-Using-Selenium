using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_Class_5;

namespace TDD_Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// distance match actual value
        /// </summary>
        [TestMethod]
        [TestCategory("Distance test")]
        public void PositiveDistance()
        {
            DistanceClass distance = new DistanceClass();
            var value = 50;
            var actualValue = distance.Ditance(10, 5);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// distance should greater then 0
        /// </summary>
        [TestMethod]
        [TestCategory("Distance test")]
        public void NonZeroDistance()
        {
            DistanceClass distance = new DistanceClass();
            var value = 0;
            var actualValue = distance.Ditance(10, 5);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// distance shouldnot be negative
        /// </summary>
        [TestMethod]
        [TestCategory("Distance test")]
        public void NegativeDistance()
        {
            DistanceClass distance = new DistanceClass();
            var value = -50;
            var actualValue = distance.Ditance(10, 5);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// distance match actual value
        /// </summary>
        [TestMethod]
        [TestCategory("Distance test")]
        public void PositiveDistance4Cordination()
        {
            DistanceClass distance = new DistanceClass();
            var value = 2.23;
            double[] x = { 2, 3 };
            double[] y = { 5, 7 };
            var actualValue = distance.CordinateDistance(x,y);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// distance should greater then 0
        /// </summary>
        [TestMethod]
        [TestCategory("Distance test")]
        public void NonZeroDistance4Cordination()
        {
            DistanceClass distance = new DistanceClass();
            var value = 10;
            double[] x = { 1, 5 };
            double[] y = { 5, 5 };
            var actualValue = distance.CordinateDistance(x, y);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// distance shouldnot be negative
        /// </summary>
        [TestMethod]
        [TestCategory("Distance test")]
        public void NegativeDistance4Cordination()
        {
            DistanceClass distance = new DistanceClass();
            var value = -10;
            double[] x = { 1, 5 };
            double[] y = { 5, 5 };
            var actualValue = distance.CordinateDistance(x, y);
            Assert.AreEqual(value, actualValue);
        }
    }
}
