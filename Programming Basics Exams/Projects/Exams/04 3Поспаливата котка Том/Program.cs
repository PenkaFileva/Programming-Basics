using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int workingDays = 365 - holidays;
            var totalMinGame = holidays * 127 + workingDays * 63;
            var diff = totalMinGame - 30000;
            var hours = Math.Abs(diff) / 60;
            var min = Math.Abs(diff) % 60;
            if (diff>0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
            }
            else if(diff<=0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, min);
            }

        }
    }
}
