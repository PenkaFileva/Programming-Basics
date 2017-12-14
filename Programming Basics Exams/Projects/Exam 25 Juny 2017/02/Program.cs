using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var time = double.Parse(Console.ReadLine()); //vreme za 1m

            var timeIvancho = distance * time;
            var time15m = Math.Floor(distance / 15) * 12.5;
            var totalTimeIvancho = timeIvancho + time15m;
            if (totalTimeIvancho<record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeIvancho:f2} seconds.");
            }
            else if (totalTimeIvancho >= record)
            {
                Console.WriteLine($"No, he failed! He was {(totalTimeIvancho - record):f2} seconds slower.");
            }

        }
    }
}
