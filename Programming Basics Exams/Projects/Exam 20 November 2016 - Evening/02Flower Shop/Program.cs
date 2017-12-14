using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var numMagnolii = double.Parse(Console.ReadLine());
            var numZumbiuli = double.Parse(Console.ReadLine());
            var numRose = double.Parse(Console.ReadLine());
            var numKaktusi = double.Parse(Console.ReadLine());
            var priceGift = double.Parse(Console.ReadLine());
            var sum = numMagnolii*3.25 + numZumbiuli*4.00 + numRose*3.50 + numKaktusi*8.00;
            var totalSum = sum - sum * 0.05;
            if (totalSum >= priceGift)
            {
                var diff = totalSum - priceGift;
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }
            else if (totalSum < priceGift)
            {
                var diff = priceGift - totalSum;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(diff)} leva.");
            }
        }
    }
}
