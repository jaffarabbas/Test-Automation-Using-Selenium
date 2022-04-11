using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordValidator;
using System.Collections.Generic;

namespace PasswordValidatorTest
{
    [TestClass]
    public class UnitTest1
    {
        Dictionary<int, string> errorLog = new Dictionary<int, string>();
        public UnitTest1()
        {
            errorLog.Add(0, "null");
            errorLog.Add(-1, "password is less than 8");
            errorLog.Add(-2, "password dosn't contain Uppercase");
            errorLog.Add(-3, "password dosn't contain lowercase");
            errorLog.Add(-4, "password dosn't contain number");
        }
        PassowrdValidatorClass validator = new PassowrdValidatorClass();
        [TestMethod]
        public void TestPasswordAllConditionTrue()
        {
            validator.password = "Ab12345667";
            int a = validator.Validator();
            Assert.AreEqual(1, a);
        }
        [TestMethod]
        public void TestPasswordIsNull()
        {
            validator.password = "";
            int a = validator.Validator();
            Assert.AreEqual(0, a, errorLog[0]);
        }
        [TestMethod]
        public void TestPasswordisLess8()
        {
            validator.password = "werwer";
            int a = validator.Validator();
            Assert.AreEqual(-1, a, errorLog[-1]);
        }
        [TestMethod]
        public void TestPasswordIsLower()
        {
            validator.password = "dsfsdfsdfds";
            int a = validator.Validator();
            Assert.AreEqual(-2, a, errorLog[-2]);
        }
        [TestMethod]
        public void TestPasswordIsUpper()
        {
            validator.password = "DSAASDSSAD";
            int a = validator.Validator();
            Assert.AreEqual(-3, a, errorLog[-3]);
        }
        [TestMethod]
        public void TestPasswordIsDigit()
        {
            validator.password = "ASASbbbnsbnsd";
            int a = validator.Validator();
            Assert.AreEqual(-4, a, errorLog[-4]);
        }
    }
}