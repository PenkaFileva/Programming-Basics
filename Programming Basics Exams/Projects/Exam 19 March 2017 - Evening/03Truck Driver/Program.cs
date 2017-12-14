using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            var km = double.Parse(Console.ReadLine());
            var price = 0.0;
            if (km <= 5000)
            {
                switch (season)
                {
                    case "Spring": price = 0.75; break;
                    case "Summer": price = 0.90; break;
                    case "Autumn": price = 0.75; break;
                    case "Winter": price = 1.05; break;
                }
            }
            else if (km <= 10000)
            {
                switch (season)
                {
                    case "Spring": price = 0.95; break;
                    case "Summer": price = 1.10; break;
                    case "Autumn": price = 0.95; break;
                    case "Winter": price = 1.25; break;
                }
            }
            else if (km <= 20000)
            {
                switch (season)
                {
                    case "Spring": price = 1.45; break;
                    case "Summer": price = 1.45; break;
                    case "Autumn": price = 1.45; break;
                    case "Winter": price = 1.45; break;
                }
            }
            var salary = km * price * 4;
            var pureProfit = salary - salary * 0.10;
            Console.WriteLine($"{pureProfit:f2}");
        }
    }
}