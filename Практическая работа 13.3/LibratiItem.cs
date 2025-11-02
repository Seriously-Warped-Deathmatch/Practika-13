using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class LibratiItem
    {
        public string Title
        {
            get { return Title; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Title = value;
                }
                else
                {
                    Title = "Неизвестно";
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

        public int YearOfPublication
        {
            get { return YearOfPublication; }
            set
            {
                if (value > 1900)
                {
                    YearOfPublication = value;
                }
                else
                {
                    YearOfPublication = 0;
                }
            }
        }

        public bool Availability
        {
            get { return Availability;}
            set { Availability = value;}
        }
    }
}
