using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceHoliday = double.Parse(Console.ReadLine());
            var numberOfPuzzles = double.Parse(Console.ReadLine());
            var numberDollsTalking = double.Parse(Console.ReadLine());
            var numberTeddyBears = double.Parse(Console.ReadLine());
            var numberMinions = double.Parse(Console.ReadLine());
            var numberTrucks = double.Parse(Console.ReadLine());

            var numberOfToys = numberOfPuzzles + numberDollsTalking + numberTeddyBears + numberMinions + numberTrucks;
            var priceTotal = numberOfPuzzles * 2.60 + numberDollsTalking * 3.0 + numberTeddyBears * 4.10 + numberMinions * 8.20 + numberTrucks * 2.0;

            if (numberOfToys >= 50)
            {
                priceTotal = priceTotal - (priceTotal * 0.25);
            }
            var rent = 0.10 * priceTotal;
            var profit = priceTotal - rent;

            if (profit >= priceHoliday)
            {
                Console.WriteLine($"Yes! {(profit - priceHoliday):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(priceHoliday - profit):f2} lv needed.");
            }
        }
    }
}
 