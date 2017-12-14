using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Abs(x2 - x1);
            var haight = Math.Abs(y1 - y2);
            var area = width * haight;
            var perimeter = (width + haight) * 2;
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine($"Perimeter ={perimeter}");

        }
    }
}
