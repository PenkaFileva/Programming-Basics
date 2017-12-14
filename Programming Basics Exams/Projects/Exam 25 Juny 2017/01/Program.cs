using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var confectioner = int.Parse(Console.ReadLine());
            var cake = int.Parse(Console.ReadLine());
            var gofreta = int.Parse(Console.ReadLine());
            var pancake = int.Parse(Console.ReadLine());

            var sum = (cake*45.0 + gofreta*5.80 + pancake*3.20) * confectioner * days;
            var sum1 = sum / 8;
            var totalSum = sum - sum1;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
