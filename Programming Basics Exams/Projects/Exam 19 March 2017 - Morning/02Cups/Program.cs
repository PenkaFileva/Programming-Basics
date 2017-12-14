using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCups = int.Parse(Console.ReadLine());
            var numPeople = int.Parse(Console.ReadLine());
            var numDays = int.Parse(Console.ReadLine());

            var hours = numDays * numPeople * 8;
            var realCraftedCups = Math.Floor(hours / 5.0);
            if (realCraftedCups >= numCups)
            {
                var diff = realCraftedCups - numCups;
                var money = diff * 4.20;
                Console.WriteLine($"{money:f2} extra money");
            }
            else if (realCraftedCups < numCups)
            {
                var diff = numCups - realCraftedCups;
                var money = diff * 4.20;
                Console.WriteLine($"Losses: {money:f2}");
            }
        }
    }
}
