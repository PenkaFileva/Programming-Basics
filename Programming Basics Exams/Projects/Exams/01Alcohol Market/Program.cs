using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfWhiskey = double.Parse(Console.ReadLine());
            var quantityBeer = double.Parse(Console.ReadLine());
            var quantityWine = double.Parse(Console.ReadLine());
            var quantityBrandy = double.Parse(Console.ReadLine());
            var quantityWiskey = double.Parse(Console.ReadLine());

            double priceBrandy = priceOfWhiskey / 2.0;
            double priceBeer = priceBrandy - (0.80 * priceBrandy);
            double priceWine = priceBrandy - (0.40 * priceBrandy);

            var totalSum = (quantityBeer * priceBeer) + (priceBrandy * quantityBrandy) + (priceWine * quantityWine) + (priceOfWhiskey * quantityWiskey);

            Console.WriteLine($"{totalSum:f2}");


        }
    }
}
