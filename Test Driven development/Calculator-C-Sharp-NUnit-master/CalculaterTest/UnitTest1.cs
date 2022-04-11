using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculaterTest
{
    [TestClass]
    public class UnitTest1
    {
        public double value1;
        public double value2;

        #region Addition region
        /// <summary>
        /// id : 001
        /// description : addition
        /// input : 1,3
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAddition001()
        {
            value1 = 1;
            value2 = 3;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = 4;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 002
        /// description : addition with zero
        /// input : 0,0
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAdditionwithzero002()
        {
            value1 = 0;
            value2 = 0;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = 0;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 003
        /// description : addition with negative value both
        /// input : -1,-2
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAdditionwithNegativeValueBoth004()
        {
            value1 = -1;
            value2 = -2;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = -3;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 004
        /// description : addition with negative and positive value
        /// input : -1,2
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAdditionwithNegativeAndPostiveValueBoth005()
        {
            value1 = -1;
            value2 = 2;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = 1;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 005
        /// description : addition with decimal value
        /// input : 1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAdditionwithDecimalValueBoth006()
        {
            value1 = 1.1;
            value2 = 2.1;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = 3.2;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 006
        /// description : addition with decimal negative value
        /// input : -1.1,-2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAdditionwithDecimalNegativeValueBoth007()
        {
            value1 = -1.1;
            value2 = -2.1;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = -3.2;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 007
        /// description : addition with decimal negative value
        /// input : -1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Additon")]
        public void TestAdditionwithDecimalNegativeAndPostiveValueBoth008()
        {
            value1 = -1.1;
            value2 = 2.1;
            double addition = Calculator.Calulate.addition(value1, value2);
            double actualValue = 1;
            Assert.AreEqual(actualValue, addition);
        }
        #endregion

        #region Subtract region
        /// <summary>
        /// id : 009
        /// description : addition
        /// input : 1,3
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtraction009()
        {
            value1 = 1;
            value2 = 3;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = -2;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 010
        /// description : addition with zero
        /// input : 0,0
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtractionwithzero010()
        {
            value1 = 0;
            value2 = 0;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = 0;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 011
        /// description : addition with negative value both
        /// input : -1,-2
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtractionwithNegativeValueBoth011()
        {
            value1 = -1;
            value2 = -2;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = 1;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 012
        /// description : addition with negative and positive value
        /// input : -1,2
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtractionwithNegativeAndPostiveValueBoth0012()
        {
            value1 = -1;
            value2 = 2;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = -3;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 0013
        /// description : addition with decimal value
        /// input : 1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtractionwithDecimalValueBoth0013()
        {
            value1 = 1.1;
            value2 = 2.1;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = -1;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 014
        /// description : addition with decimal negative value
        /// input : -1.1,-2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtractionwithDecimalNegativeValueBoth014()
        {
            value1 = -1.1;
            value2 = -2.1;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = 1;
            Assert.AreEqual(actualValue, addition);
        }
        /// <summary>
        /// id : 015
        /// description : addition with decimal negative value
        /// input : -1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Subtraction")]
        public void TestSubtractionwithDecimalNegativeAndPostiveValueBoth015()
        {
            value1 = -1.1;
            value2 = 2.1;
            double addition = Calculator.Calulate.subtraction(value1, value2);
            double actualValue = -3.2;
            Assert.AreEqual(actualValue, addition);
        }
        #endregion

        #region Multiplication region
        /// <summary>
        /// id : 016
        /// description : multiplication
        /// input : 1,3
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplication016()
        {
            value1 = 1;
            value2 = 3;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = 3;
            Assert.AreEqual(actualValue, multiplication);
        }
        /// <summary>
        /// id : 017
        /// description : multiplication with zero
        /// input : 0,0
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplicationwithzero018()
        {
            value1 = 0;
            value2 = 0;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = 0;
            Assert.AreEqual(actualValue, multiplication);
        }
        /// <summary>
        /// id : 019
        /// description : multiplication with negative value both
        /// input : -1,-2
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplicationwithNegativeValueBoth019()
        {
            value1 = -1;
            value2 = -2;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = 2;
            Assert.AreEqual(actualValue, multiplication);
        }
        /// <summary>
        /// id : 020
        /// description : multiplication with negative and positive value
        /// input : -1,2
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplicationwithNegativeAndPostiveValueBoth020()
        {
            value1 = -1;
            value2 = 2;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = 2;
            Assert.AreEqual(actualValue, multiplication);
        }
        /// <summary>
        /// id : 021
        /// description : multiplication with decimal value
        /// input : 1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplicationwithDecimalValueBoth021()
        {
            value1 = 1.1;
            value2 = 2.1;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = 2.31;
            Assert.AreEqual(actualValue, multiplication);
        }
        /// <summary>
        /// id : 022
        /// description : multiplication with decimal negative value
        /// input : -1.1,-2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplicationwithDecimalNegativeValueBoth022()
        {
            value1 = -1.1;
            value2 = -2.1;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = -2.31;
            Assert.AreEqual(actualValue, multiplication);
        }
        /// <summary>
        /// id : 023
        /// description : multiplication with decimal negative value
        /// input : -1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Multiplication")]
        public void TestMultiplicationwithDecimalNegativeAndPostiveValueBoth023()
        {
            value1 = -1.1;
            value2 = 2.1;
            double multiplication = Calculator.Calulate.multiplication(value1, value2);
            double actualValue = -2.31;
            Assert.AreEqual(actualValue, multiplication);
        }
        #endregion

        #region Division region
        /// <summary>
        /// id : 024
        /// description : addition
        /// input : 1,3
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivision024()
        {
            value1 = 1;
            value2 = 3;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = 0.33;
            Assert.AreEqual(actualValue, division);
        }
        /// <summary>
        /// id : 025
        /// description : division with zero
        /// input : 0,0
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivisionwithzero025()
        {
            value1 = 0;
            value2 = 0;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = 0;
            Assert.AreEqual(actualValue, division);
        }
        /// <summary>
        /// id : 026
        /// description : division with negative value both
        /// input : -1,-2
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivisionwithNegativeValueBoth026()
        {
            value1 = -1;
            value2 = -2;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = 1;
            Assert.AreEqual(actualValue, division);
        }
        /// <summary>
        /// id : 027
        /// description : division with negative and positive value
        /// input : -1,2
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivisionwithNegativeAndPostiveValueBoth027()
        {
            value1 = -1;
            value2 = 2;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = -3;
            Assert.AreEqual(actualValue, division);
        }
        /// <summary>
        /// id : 028
        /// description : division with decimal value
        /// input : 1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivisionwithDecimalValueBoth028()
        {
            value1 = 1.1;
            value2 = 2.1;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = -1;
            Assert.AreEqual(actualValue, division);
        }
        /// <summary>
        /// id : 029
        /// description : division with decimal negative value
        /// input : -1.1,-2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivisionwithDecimalNegativeValueBoth029()
        {
            value1 = -1.1;
            value2 = -2.1;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = 1;
            Assert.AreEqual(actualValue, division);
        }
        /// <summary>
        /// id : 030
        /// description : division with decimal negative value
        /// input : -1.1,2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Division")]
        public void TestDivisionwithDecimalNegativeAndPostiveValueBoth030()
        {
            value1 = -1.1;
            value2 = 2.1;
            double division = Calculator.Calulate.division(value1, value2);
            double actualValue = -3.2;
            Assert.AreEqual(actualValue, division);
        }
        #endregion
    }
}