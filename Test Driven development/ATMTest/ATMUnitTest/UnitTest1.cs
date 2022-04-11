using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ATMTest;

namespace ATMUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ATM atm = new ATM();
        Param param = new Param();
        public int pin = 1234;
        /// <summary>
        /// check correct pin 
        /// </summary>
        [TestMethod]
        public void TestPinTC00()
        {
            var actualValue = atm.pinCode;
            Assert.AreEqual(pin, actualValue);
        }
        /// <summary>
        /// check correct pin 
        /// </summary>
        [TestMethod]
        public void TestDefaultSwitchTC001()
        {
            param.pinCode = pin;
            param.choice = 7;
            string value = "Worng option choose";
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }
        /// <summary>
        /// check balance
        /// </summary>
        [TestMethod]
        public void TestBalanceTC002()
        {
            var ammount = 100;
            param.amout = 100;
            var value = "Your Current balance is : "+ammount;
            var actualValue = "Your Current balance is : "+param.amout;
            Assert.AreEqual(value, actualValue);
        }
        /// <summary>
        /// check min balance
        /// </summary>
        [TestMethod]
        public void TestMinBalanceTC003()
        {
            var ammount = 100;
            var value = "Your Current balance is insufficenet: " + ammount;
            var actualValue = "Your Current balance is insufficenet: ";
            Assert.AreEqual(value, actualValue);
        }
        /// <summary>
        /// check max balance
        /// </summary>
        /// <summary>
        /// check insufficenet
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC001()
        {
            var amount = 500;
            var amountWithdraw = 800;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.deposit = amountWithdraw;


            var value = "Your Current balance is insufficenet:" + amount;
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }


        /// <summary>
        /// check min balance
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC002()
        {
            var amount = 5000;
            var amountWithdraw = 50;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.deposit = amountWithdraw;


            var value = "Your withdraw amout is less than limit(100)";
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }


        /// <summary>
        /// check max balance
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC003()
        {
            var amount = 5000;
            var amountWithdraw = 1500;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.deposit = amountWithdraw;


            var value = "Your withdraw amout is great than limit(1000)";
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }


        /// <summary>
        /// withdraw Successfully
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC004()
        {
            var amount = 5000;
            var amountWithdraw = 900;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.deposit = amountWithdraw;


            String value = "Withdraw Successfully of amount:" + (param.amout - param.deposit);
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }
        /// <summary>
        /// check deposit
        /// </summary>
        [TestMethod]
        public void TestDepositTC005()
        {
            var amount = 5002;
            param.deposit = 5000;
            param.amout = 2;
            param.pinCode = 1234;
            param.choice = 3;
            var value = "Your Balance Deposit Successfully: " + amount;
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// check deposit
        /// </summary>
        [TestMethod]
        public void TestMinDepositTC006()
        {
            param.deposit = 0;
            param.pinCode = 1234;
            param.choice = 3;
            var value = "Please Select amount greater then 0: " + param.deposit;
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }
    }
}
