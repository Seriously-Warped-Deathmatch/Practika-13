using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CreditAccount: BankAccount
    {
        public int CreditLimit
        {
            get { return CreditLimit; }
            set
            {
                if (value > 0)
                {
                    CreditLimit = value;
                }
                else
                {
                    CreditLimit = 0;
                }
            }
        }

        public int RepaymentPeriod // дней погашения кредитов
        {
            get { return RepaymentPeriod; }
            set
            {
                if (value > 0)
                {
                    RepaymentPeriod = value;
                }
                else
                {
                    RepaymentPeriod = 0;
                }
            }
        }
    }
}
