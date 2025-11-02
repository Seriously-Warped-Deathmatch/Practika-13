using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CheckingAccount: BankAccount
    {
        public int overdraft
        {
            get { return overdraft; }
            set
            {
                if (value > - 1000)
                {
                    overdraft = value;
                }
                else
                {
                    overdraft = 0;
                }
            }
        }
    }
}
