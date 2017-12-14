using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaHouse = double.Parse(Console.ReadLine());
            var numWindows = int.Parse(Console.ReadLine());
            var kvmStiroporOnePackage = double.Parse(Console.ReadLine());
            var priceOnePackage = double.Parse(Console.ReadLine());

            var areaWindows = numWindows * 2.4;
            var realArea = (areaHouse - areaWindows)+ (areaHouse - areaWindows)*0.10;
            var numPackage = Math.Ceiling(realArea / kvmStiroporOnePackage);
            var sum = numPackage * priceOnePackage;

            if (sum <= budget)
            {
                Console.WriteLine($"Spent: {sum:f2}");
                Console.WriteLine($"Left: {(budget-sum):f2}");
            }
            else if (sum > budget)
            {
                Console.WriteLine($"Need more: {(sum-budget):f2}");
            }
        }
    }
}
