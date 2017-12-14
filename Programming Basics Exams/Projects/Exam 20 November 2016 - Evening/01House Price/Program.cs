using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaRoom1 = double.Parse(Console.ReadLine());
            var areaKitchen = double.Parse(Console.ReadLine());
            var priceKvM = double.Parse(Console.ReadLine());
            var areaBathroom = areaRoom1 / 2;
            var areaRoom2 = areaRoom1 + 0.10 * areaRoom1;
            var areaRoom3 = areaRoom2 + 0.10 * areaRoom2;
            var sumArea = areaKitchen + areaRoom1 + areaRoom2 + areaRoom3 + areaBathroom;
            var totalArea = sumArea + 0.05 * sumArea;
            var priceTotalArea = priceKvM * totalArea;
            Console.WriteLine($"{priceTotalArea:f2}");
        }
    }
}
