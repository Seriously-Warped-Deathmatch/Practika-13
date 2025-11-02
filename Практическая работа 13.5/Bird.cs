using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Bird : Animals
    {
        public string TypeOfNesting
        {
            get { return TypeOfNesting; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    TypeOfNesting = value;
                }
                else
                {
                    TypeOfNesting = "неизвестно";
                }
            }
        }

        public int Wingspan
        {
            get { return Wingspan; } // см
            set
            {
                if (value > 0)
                {
                    Wingspan = value;
                }
                else
                {
                    Wingspan = 1;
                }
            }
        }
    }
}
