using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Magazine : LibratiItem
    {
        public int IssueNumber
        {
            get { return IssueNumber; }
            set
            {
                if (value > 0)
                {
                    IssueNumber = value;
                }
                else
                {
                    IssueNumber = 0;
                }
            }
        }

        public int Periodicity
        {
            get { return Periodicity; }
            set
            {
                if (value > 0)
                {
                    Periodicity = value;
                }
                else
                {
                    Periodicity = 0;
                }
            }
        }
    }
}
