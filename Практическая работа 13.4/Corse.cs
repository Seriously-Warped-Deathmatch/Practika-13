using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Corse
    {
        public string Name
        {
            get { return Name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Name = value;
                }
                else
                {
                    Name = "Неизвестно";
                }
            }
        }

        public string Author
        {
            get { return Author; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Author = value;
                }
                else
                {
                    Author = "неизвестно";
                }
            }
        }

        public string Description
        {
            get { return Description; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Description = value;
                }
                else
                {
                    Description = "описание отсуствует";
                }
            }
        }

        public int Price
        {
            get { return Price; }
            set
            {
                if (value > 0)
                {
                    Price = value;
                }
                else
                {
                    Price = 0;
                }
            }
        }
    }
}
