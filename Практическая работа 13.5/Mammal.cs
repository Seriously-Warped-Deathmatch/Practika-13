using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Mammal : Animals
    {
        public string TypeOfFur
        {
            get { return TypeOfFur; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    TypeOfFur = value;
                }
                else
                {
                    TypeOfFur = "неизвестно";
                }
            }
        }

        public int DurationOfPregnancy
        {
            get { return DurationOfPregnancy; } // дней
            set
            {
                if (value > 0)
                {
                    DurationOfPregnancy = value;
                }
                else
                {
                    DurationOfPregnancy = 1;
                }
            }
        }
    }
}
