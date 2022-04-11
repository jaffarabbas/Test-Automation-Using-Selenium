using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDClass4;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Class1 emiObject = new Class1();
        /// <summary>
        /// bmi < 19 and gneder female underweight
        /// </summary>
        [TestMethod]
        [TestCategory("KG")]
        public void FemaleUnderWeight()
        {
            string ExpectedValue = "UnderWeight";
            string value = emiObject.CaclulateBMI(18, 4, "f");
            Assert.AreEqual(ExpectedValue, value);
        }

        /// <summary>
        /// bmi >=19 and <= 24 and gneder female normal
        /// </summary>
        [TestMethod]
        [TestCategory("KG")]
        public void FemaleNormal()
        {
            string ExpectedValue2 = "Normal";
            string value = emiObject.CaclulateBMI(77, 2, "f");
            Assert.AreEqual(ExpectedValue2, value);
        }

        /// <summary>
        /// bmi > 24 and gneder female overweight
        /// </summary>
        [TestMethod]
        [TestCategory("KG")]
        public void FemaleOver()
        {
            string ExpectedValue3 = "Over";
            string value = emiObject.CaclulateBMI(202, 2, "f");
            Assert.AreEqual(ExpectedValue3, value);
        }

        /// <summary>
        /// bmi < 20 and gneder male underweight
        /// </summary>
        [TestMethod]
        [TestCategory("KG")]
        public void MaleUnderWeight()
        {
            string ExpectedValue = "UnderWeight";
            string value = emiObject.CaclulateBMI(60, 4, "m");
            Assert.AreEqual(ExpectedValue, value);
        }

        /// <summary>
        /// bmi >= 20 and <= 25 and gneder male normal
        /// </summary>
        [TestMethod]
        [TestCategory("KG")]
        public void MaleNormal()
        {
            string ExpectedValue2 = "Normal";
            string value = emiObject.CaclulateBMI(80, 2, "m");
            Assert.AreEqual(ExpectedValue2, value);
        }

        /// <summary>
        /// bmi > 25 and gneder male overweight
        /// </summary>
        [TestMethod]
        [TestCategory("KG")]
        public void MaleOverWeight()
        {
            string ExpectedValue3 = "Over";
            string value = emiObject.CaclulateBMI(200,2, "m");
            Assert.AreEqual(ExpectedValue3, value);
        }

        /// <summary>
        /// bmi < 19 and gneder female underweight Pound
        /// </summary>
        [TestMethod]
        [TestCategory("Pound")]
        public void FemaleUnderWeightPound()
        {
            string ExpectedValue = "UnderWeight";
            string value = emiObject.CaclulateBMIPound(18, 4, "f");
            Assert.AreEqual(ExpectedValue, value);
        }

        /// <summary>
        /// bmi >=19 and <= 24 and gneder female normal Pound
        /// </summary>
        [TestMethod]
        [TestCategory("Pound")]
        public void FemaleNormalPound()
        {
            string ExpectedValue2 = "Normal";
            string value = emiObject.CaclulateBMIPound(77, 2, "f");
            Assert.AreEqual(ExpectedValue2, value);
        }

        /// <summary>
        /// bmi > 24 and gneder female overweight Pound
        /// </summary>
        [TestMethod]
        [TestCategory("Pound")]
        public void FemaleOverPound()
        {
            string ExpectedValue3 = "Over";
            string value = emiObject.CaclulateBMIPound(202, 2, "f");
            Assert.AreEqual(ExpectedValue3, value);
        }

        /// <summary>
        /// bmi < 20 and gneder male underweight Pound
        /// </summary>
        [TestMethod]
        [TestCategory("Pound")]
        public void MaleUnderWeightPound()
        {
            string ExpectedValue = "UnderWeight";
            string value = emiObject.CaclulateBMIPound(60, 4, "m");
            Assert.AreEqual(ExpectedValue, value);
        }

        /// <summary>
        /// bmi >= 20 and <= 25 and gneder male normal Pound
        /// </summary>
        [TestMethod]
        [TestCategory("Pound")]
        public void MaleNormalPound()
        {
            string ExpectedValue2 = "Normal";
            string value = emiObject.CaclulateBMIPound(80, 2, "m");
            Assert.AreEqual(ExpectedValue2, value);
        }

        /// <summary>
        /// bmi > 25 and gneder male overweight Pound
        /// </summary>
        [TestMethod]
        [TestCategory("Pound")]
        public void MaleOverWeightPound()
        {
            string ExpectedValue3 = "Over";
            string value = emiObject.CaclulateBMIPound(200, 2, "m");
            Assert.AreEqual(ExpectedValue3, value);
        }
    }
}
