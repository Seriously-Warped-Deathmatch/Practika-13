using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Fish : Animals
    {
        public string TypeOfScales
        {
            get { return TypeOfScales; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    TypeOfScales = value;
                }
                else
                {
                    TypeOfScales = "неизвестно";
                }
            }
        }

        public int HabitatDepth // в метрах
        {
            get { return HabitatDepth; }
            set
            {
                if (value > 0) 
                {
                    HabitatDepth = value;
                }
                else
                {
                    HabitatDepth = 1;
                }
            }
        }
    }
}
