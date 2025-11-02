using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Manager : Employee
    {
        Employee employee = new Employee {Post = "мененежер" };
        public int SizeTeam
        {
            get { return SizeTeam; }
            set
            {
                if (value > 0)
                {
                    SizeTeam = value;
                }
                else
                {
                    SizeTeam = 0;
                }
            }
        }

        public void sovet()
        {
            Console.WriteLine($"{Name} с командой из {SizeTeam} проводят совещание.");
        }
    }
}
