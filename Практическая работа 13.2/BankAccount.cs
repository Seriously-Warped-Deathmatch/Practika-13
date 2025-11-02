using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class BankAccount
    {
        public string AccountNumber
        {
            get { return AccountNumber; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    AccountNumber = value;
                }
                else
                {
                    AccountNumber = "000 000";
                }
            }
        }

        public string OwnersName
        {
            get { return OwnersName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    OwnersName = value;
                }
                else
                {
                    OwnersName = "Неизвестно";
                }
            }
        }

        public int balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                { 
                    balance = value;
                }
                else
                {
                    balance = 0;
                }
            }
        }

    }
}
