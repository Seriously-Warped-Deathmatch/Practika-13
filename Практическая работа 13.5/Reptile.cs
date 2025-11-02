using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Reptile : Animals
    {
        public string SkinType
        {
            get { return SkinType; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    SkinType = value;
                }
                else
                {
                    SkinType = "неизвестно";
                }
            }
        }

        public int AmbientTemperature
        {
            get { return AmbientTemperature; }
            set
            {
                if (value > - 273) // температура абсолютного нуля
                {
                    AmbientTemperature = value;
                }
                else
                {
                    AmbientTemperature = 1;
                }
            }
        }
    }
}
