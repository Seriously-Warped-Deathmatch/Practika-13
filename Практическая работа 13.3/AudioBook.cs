using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class AudioBook : LibratiItem
    {
        public double duration // В минутах
        {
            get { return duration; }
            set
            {
                if (value > 0)
                {
                    duration = value;
                }
                else
                {
                    duration = 0;
                }
            }
        }

        public string Speaker
        {
            get { return Speaker; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Speaker = value;
                }
                else
                {
                    Speaker = "неизвестно";
                }
            }
        }
    }
}
