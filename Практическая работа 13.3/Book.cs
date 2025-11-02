using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Book : LibratiItem
    {
        public int NumberOfPages
        {
            get { return NumberOfPages; }
            set
            {
                if (value > 0)
                {
                    NumberOfPages = value;
                }
                else
                {
                    NumberOfPages = 0;
                }
            }
        }
        public int ISBN
        {
            get { return ISBN; }
            set
            {
                if (value > 0)
                {
                    ISBN = value;
                }
                else
                {
                    ISBN = 0;
                }
            }
        }
    }
}
