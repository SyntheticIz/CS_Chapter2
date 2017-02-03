using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] week = new int[5];
            week[0] = 69;
            week[1] = 86;
            week[2] = 72;
            week[3] = 27;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("During week " + (i + 1) + " there were " + week[i] + " eggs which made " + (week[i] / 12) + " dozens of eggs with " + (week[i] % 12) + " eggs left.");
            }
        }
    }
}
