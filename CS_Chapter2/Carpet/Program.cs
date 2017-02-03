using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25, width = 42, area = length * width;
            double costsf = 3, total = area * costsf;
            Console.WriteLine("For a " + length + " by " + width + " room with carpet priced at $" + costsf + " per square foot it will cost $" + total + ".");
        }
    }
}
