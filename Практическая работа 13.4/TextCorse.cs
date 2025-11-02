using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class TextCorse : Corse
    {
        public int NumberOfChapters
        {
            get { return NumberOfChapters; }
            set
            {
                if (value > 0)
                {
                    NumberOfChapters = value;
                }
                else
                {
                    NumberOfChapters = 0;
                }
            }
        }

        public int TheTotalVoluameOfTheText
        {
            get { return TheTotalVoluameOfTheText; }
            set
            {
                if (value > 0)
                {
                    TheTotalVoluameOfTheText = value;
                }
                else
                {
                    TheTotalVoluameOfTheText = 0;
                }
            }
        }
    }
}
