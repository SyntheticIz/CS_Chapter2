using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter how many eggs were laid week " + (i+1) + ".");
                String scan = Console.ReadLine();
                int num = Convert.ToInt32(scan);
                Console.WriteLine("During week " + (i + 1) + " there were " + num + " eggs which made " + (num / 12) + " dozens of eggs with " + (num % 12) + " eggs left.");
            }
        }
    }
}
