using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Animals
    {
        public string View
        {
            get { return View; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    View = value;
                }
                else
                {
                    View = "Неизвестно";
                }
            }
        }

        public string LivingEnvironment
        {
            get { return LivingEnvironment; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    LivingEnvironment = value;
                }
                else
                {
                    LivingEnvironment = "неизвестно";
                }
            }
        }

        public string TheDiet
        {
            get { return TheDiet; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    TheDiet = value;
                }
                else
                {
                    TheDiet = "неизвестно";
                }
            }
        }

        public int Age
        {
            get { return Age; }
            set
            {
                if (value > 0)
                {
                    Age = value;
                }
                else
                {
                    Age = 1;
                }
            }
        }
    }
}
