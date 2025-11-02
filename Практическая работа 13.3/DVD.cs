using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class DVD : LibratiItem
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

        public double rating // 10- бальная система оценивания (например 5.39)
        {
            get { return rating; }
            set
            {
                if (value > 0 && value < 10)
                {
                    rating = value;
                }
                else
                {
                    rating = 0;
                }
            }
        }
    }
}
