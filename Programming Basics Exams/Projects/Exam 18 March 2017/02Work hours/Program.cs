using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var numHours = int.Parse(Console.ReadLine());
            var numPeople = int.Parse(Console.ReadLine());
            var numDays = int.Parse(Console.ReadLine());

            var hours = numDays * numPeople * 8;
            if (hours >= numHours)
            {
                var diff = hours - numHours;
                Console.WriteLine($"{diff} hours left");
            }
            else if (hours < numHours)
            {
                var diff = numHours - hours;
                Console.WriteLine($"{diff} overtime");
                Console.WriteLine($"Penalties: {diff*numDays}");
            }
        }
    }
}
