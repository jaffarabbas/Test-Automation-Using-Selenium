using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTest
{
    public class ATM
    {
        public int pinCode = 1234;
        public string BankTransaction(Param param)
        {
            string result = "";
            int amount = 5000;
            if (pinCode == param.pinCode)
            {
                switch (param.choice)
                {
                    case 1:
                        result = "Your Current balance is : " + param.amout;
                        break;
                    case 2:

                        if (param.deposit < 100)
                        {
                            result = "Your withdraw amout is less than limit(100)";
                        }
                        else if (param.deposit > 1000)
                        {
                            result = "Your withdraw amout is great than limit(1000)";
                        }
                        else if (param.deposit > param.amout)
                        {
                            result = "Your Current balance is insufficenet:" + param.amout;
                        }
                        else
                        {
                            param.amout = param.amout - param.deposit;
                            result = "Withdraw Successfully of amount:" + param.amout;
                        }
                        break;
                    case 3:
                        result = param.amout > 0 ? "Your Balance Deposit Successfully: " + (param.amout + param.deposit) : "Please Select amount greater then 0: " + (param.amout + param.deposit);
                        break;
                    default:
                        result = "Worng option choose";
                        break;
                }
            }
            else
                {
                    result = "Incorrect Pin";
                }
                return result;
            }
        }
        public class Param
        {
            public int pinCode { get; set; }
            public int choice { get; set; }
            public int deposit { get; set; }
            public int amout { get; set; }
        }
}