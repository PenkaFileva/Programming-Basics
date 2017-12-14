using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumria = double.Parse(Console.ReadLine()); //na kg
            var priceCaca = double.Parse(Console.ReadLine());    // na kg
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidy = double.Parse(Console.ReadLine());

            var pricePlamud = (priceSkumria + 0.60 * priceSkumria)* kgPalamud;
            var priceSafrid = (priceCaca + 0.80 * priceCaca)* kgSafrid;
            var priceMidy = kgMidy * 7.50;
            var totaPrice = pricePlamud + priceSafrid + priceMidy;

            Console.WriteLine($"{totaPrice:f2}");
        }
    }
}
