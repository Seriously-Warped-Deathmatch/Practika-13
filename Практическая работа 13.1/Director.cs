using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Director: Employee
    {
        Employee employee = new Employee { Post = "директор" };
        public string Department
        {
            get { return Department; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Department = value;
                }
                else
                {
                    Department = "неизвестно";
                }
            }
        }

        public void budget()
        {
            Console.WriteLine($"{Name} утверждает бюджет в отделе {Department}.");
        }
    }
}
