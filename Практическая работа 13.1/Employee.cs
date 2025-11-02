using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
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
                    Name = "Неизвестный";
                }
            }
        }

        public string Post
        {
            get { return Post; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Post = value;
                }
                else
                {
                    Post = "неизвестно";
                }
            }
        }

        public int Salary
        {
            get { return Salary; }
            set
            {
                if (value > 0)
                {
                    Salary = value;
                }
                else
                {
                    Salary = 0;
                }
            }
        }

        public string Date
        {
            get { return Date; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Date = value;
                }
                else
                {
                    Date = "02.11.2025";
                }
            }
        }
    }
}
