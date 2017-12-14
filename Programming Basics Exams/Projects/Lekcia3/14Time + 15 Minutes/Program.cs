using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesAfter = minutes + 15;

            if (minutesAfter > 59)
            {
                hour += 1;
                minutesAfter -= 60;
                if (hour > 23)
                {
                    hour = Math.Abs(24 - hour);
                }


            }
            Console.WriteLine($"{hour}:{minutesAfter:00}");

        }
    }
}
