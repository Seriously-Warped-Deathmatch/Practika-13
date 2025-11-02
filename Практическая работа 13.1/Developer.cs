using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Developer : Employee
    {
        Employee employee = new Employee { Post = "программист" };
        public string ProgrammingLanguage
        {
            get { return ProgrammingLanguage; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    ProgrammingLanguage = value;
                }
                else
                {
                    ProgrammingLanguage = "C#";
                }
            }
        }

        public void WriteTheCode()
        {
            Console.WriteLine($"{Name} пишет программу на {ProgrammingLanguage}.");
        }
    }
}
