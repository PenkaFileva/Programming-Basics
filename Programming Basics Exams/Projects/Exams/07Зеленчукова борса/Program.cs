using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVegetables = double.Parse(Console.ReadLine());
            var priceFruits = double.Parse(Console.ReadLine());
            var quantityVegetables = double.Parse(Console.ReadLine());
            var quantityFruits = double.Parse(Console.ReadLine());

            var total = (priceVegetables * quantityVegetables + priceFruits * quantityFruits) / 1.94;

            Console.WriteLine(total);
        }
    }
}
