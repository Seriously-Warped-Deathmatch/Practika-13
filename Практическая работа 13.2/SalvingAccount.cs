using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SalvingAccount : BankAccount
    {
        public int TheInterestRate
        {
            get { return TheInterestRate; }
            set
            {
                if (value > -1000)
                {
                    TheInterestRate = value;
                }
                else
                {
                    TheInterestRate = 0;
                }
            }
        }
    }
}
