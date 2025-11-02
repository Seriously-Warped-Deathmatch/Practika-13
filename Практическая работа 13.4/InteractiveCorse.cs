using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class InteractiveCorse
    {
        public int NumberOfExercises
        {
            get { return NumberOfExercises; }
            set
            {
                if (value > 0)
                {
                    NumberOfExercises = value;
                }
                else
                {
                    NumberOfExercises = 0;
                }
            }
        }
        public string VerificationSystem
        {
            get { return VerificationSystem; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    VerificationSystem = value;
                }
                else
                {
                    VerificationSystem = "неизвестно";
                }
            }
        }
    }
}
