using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class VideoCorse : Corse
    {
        public int NumberOfVideos
        {
            get { return NumberOfVideos; }
            set
            {
                if (value > 0)
                {
                    NumberOfVideos = value;
                }
                else
                {
                    NumberOfVideos = 0;
                }
            }
        }

        public int TotalDuration
        {
            get { return TotalDuration; }
            set
            {
                if (value > 0)
                {
                    TotalDuration = value;
                }
                else
                {
                    TotalDuration = 0;
                }
            }
        }


    }
}
