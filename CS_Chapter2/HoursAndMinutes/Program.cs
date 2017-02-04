using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutestot = 531, hours = minutestot/60, minutes = minutestot%60;
            Console.WriteLine("Hours: " + hours + "\nMinutes: " + minutes);
        }
    }
}
